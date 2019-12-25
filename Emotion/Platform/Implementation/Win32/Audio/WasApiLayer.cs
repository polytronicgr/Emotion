﻿#region Using

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Emotion.Audio;
using Emotion.Common;
using Emotion.IO;
using Emotion.Standard.Audio;
using Emotion.Standard.Logging;
using WinApi.ComBaseApi.COM;

#endregion

namespace Emotion.Platform.Implementation.Win32.Audio
{
    internal class WasApiLayer : AudioLayer
    {
        private WasApiAudioContext _parent;
        private Thread _thread;
        private bool _alive;
        private WasApiLayerContext _layerContext;
        private volatile bool _updateDevice;

        private ManualResetEvent _playWait = new ManualResetEvent(false);

        public WasApiLayer(string name, WasApiAudioContext parent) : base(name)
        {
            _parent = parent;
            _alive = true;
            SetDevice(_parent.DefaultDevice);
            _thread = new Thread(LayerThread);
            _thread.Start();
            while (!_thread.IsAlive)
            {
            }
        }

        private void LayerThread()
        {
            if (Thread.CurrentThread.Name == null) Thread.CurrentThread.Name = $"Audio Layer - {Name}";
            while (_alive && !Engine.Stopped)
            {
                // If not playing, wait for it to start playing.
                if (Status != PlaybackStatus.Playing)
                {
                    _playWait.WaitOne();
                    continue;
                }
                
                if (_playlist.Count == 0 || _currentTrack == -1 || _currentTrack > _playlist.Count - 1) Debug.Assert(false);

                // Get the number of frames the buffer can hold total.
                var frameCount = (int) _layerContext.BufferSize;

                // Check if the context is initialized.
                if (!_layerContext.Initialized)
                {
                    FillBuffer(_layerContext.RenderClient, (int) _layerContext.BufferSize);
                    _layerContext.Start();
                }

                // Start if not started.
                if (!_layerContext.Started) _layerContext.Start();

                // Wait until more of the buffer is requested.
                bool success = _layerContext.WaitHandle.WaitOne(_layerContext.TimeoutPeriod);
                if (!success)
                {
                    Engine.Log.Warning($"Layer {Name} audio context timeout.", MessageSource.Audio);
                    continue;
                }

                // Get more frames.
                int error = _layerContext.AudioClient.GetCurrentPadding(out int padding);
                if (error != 0) Engine.Log.Warning($"Couldn't get device padding, error {error}.", MessageSource.Audio);
                if (!FillBuffer(_layerContext.RenderClient, frameCount - padding)) continue;
                // If done, reset the audio client.
                Task.Delay(_layerContext.TimeoutPeriod).Wait();
                _layerContext.Stop();
                _layerContext.Reset();
            }
        }

        /// <summary>
        /// Fill a render client buffer.
        /// </summary>
        /// <param name="client">The client to fill.</param>
        /// <param name="bufferFrameCount">The number of samples to fill with.</param>
        /// <returns>Whether the buffer has been read to the end.</returns>
        private unsafe bool FillBuffer(IAudioRenderClient client, int bufferFrameCount)
        {
            if (bufferFrameCount == 0) return false;

            int error = client.GetBuffer(bufferFrameCount, out IntPtr bufferPtr);
            if (error != 0) Engine.Log.Warning($"Couldn't get device buffer, error {error}.", MessageSource.Audio);
            var buffer = new Span<byte>((void*) bufferPtr, bufferFrameCount * _layerContext.AudioClientFormat.SampleSize);

            int frames = GetDataForCurrentTrack(_layerContext.AudioClientFormat, bufferFrameCount, buffer);

            error = client.ReleaseBuffer(frames, frames == 0 ? AudioClientBufferFlags.Silent : AudioClientBufferFlags.None);
            if (error != 0) Engine.Log.Warning($"Couldn't release device buffer, error {error}.", MessageSource.Audio);
            return frames == 0;
        }

        private void SetDevice(WasApiAudioDevice device)
        {
            _layerContext = device.CreateLayerContext();
        }

        public void DefaultDeviceChanged(WasApiAudioDevice newDevice)
        {
            _updateDevice = true;
        }

        protected override void InternalStatusChange(PlaybackStatus oldStatus, PlaybackStatus newStatus)
        {
            switch(newStatus)
            {
                case PlaybackStatus.NotPlaying:
                    _playWait.Reset();
                    break;
                case PlaybackStatus.Paused when oldStatus == PlaybackStatus.Playing:
                    _playWait.Reset();
                    _layerContext.Stop();
                    break;
                case PlaybackStatus.Playing:
                    _playWait.Set();
                    break;
            }
        }

        public override void Dispose()
        {
            _alive = false;
            _playWait.Set();
            _layerContext.Stop();
            _layerContext = null;
            _parent = null;

            if(_thread.IsAlive) _thread.Abort();
        }
    }
}