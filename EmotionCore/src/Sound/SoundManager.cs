﻿// Emotion - https://github.com/Cryru/Emotion

#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Emotion.Engine;
using Emotion.Engine.Threading;
using Emotion.IO;
using OpenTK.Audio;
using OpenTK.Audio.OpenAL;

#endregion

namespace Emotion.Sound
{
    public class SoundManager
    {
        private AudioContext _audioContext;
        private Dictionary<string, SoundLayer> _layers;
        private Queue<Action> _soundThreadActions;

        public SoundManager()
        {
            _layers = new Dictionary<string, SoundLayer>();
            _soundThreadActions = new Queue<Action>();

            Thread soundThread = new Thread(SoundThreadLoop);
            soundThread.Start();
            while (!soundThread.IsAlive)
            {
            }
        }

        private void SoundThreadLoop()
        {
            _audioContext = new AudioContext();
            ALThread.BindThread();

            // Setup listener.
            AL.Listener(ALListener3f.Position, 0, 0, 0);
            AL.Listener(ALListener3f.Velocity, 0, 0, 0);

            while (Context.IsRunning)
            {
                // Update running playbacks.
                lock (_layers)
                {
                    foreach (KeyValuePair<string, SoundLayer> layer in _layers)
                    {
                        layer.Value.Update();
                    }
                }

                // Run queued actions.
                ALThread.Run();

                Task.Delay(1).Wait();
            }

            // Dispose of the audio context.
            _audioContext.Dispose();
        }

        #region API

        /// <summary>
        /// Plays the specified file on the specified layer.
        /// If the layer doesn't exist it is created.
        /// If sometimes else is playing on that layer it will be forcefully stopped.
        /// </summary>
        /// <param name="file">The file to play.</param>
        /// <param name="layer">The layer to play on.</param>
        /// <returns>The layer the sound is playing on.</returns>
        [SuppressMessage("ReSharper", "ImplicitlyCapturedClosure")]
        public SoundLayer Play(SoundFile file, string layer)
        {
            // Check whether the layer exists, and create it if it doesn't.
            SoundLayer playBackLayer = GetLayer(layer) ?? CreateLayer(layer);

            // Check if the layer has anything playing on it.
            if (playBackLayer.Status != SoundStatus.Stopped) playBackLayer.StopPlayingAll();

            playBackLayer.QueuePlay(file);

            return playBackLayer;
        }

        /// <summary>
        /// Plays the specified file on the specified layer.
        /// If the layer doesn't exist it is created.
        /// If sometimes else is playing on that layer this file will be appended to it.
        /// </summary>
        /// <param name="file">The file to play.</param>
        /// <param name="layer">The layer to play on.</param>
        /// <returns>The layer the sound is playing on.</returns>
        [SuppressMessage("ReSharper", "ImplicitlyCapturedClosure")]
        public SoundLayer PlayQueue(SoundFile file, string layer)
        {
            // Check whether the layer exists, and create it if it doesn't.
            SoundLayer playBackLayer = GetLayer(layer) ?? CreateLayer(layer);

            playBackLayer.QueuePlay(file);

            return playBackLayer;
        }

        /// <summary>
        /// Returns the sound layer object of the requested name or null if none exists.
        /// </summary>
        /// <param name="layer">The name of the layer to look for.</param>
        /// <returns>The layer with the specified name, or null if not found.</returns>
        public SoundLayer GetLayer(string layer)
        {
            SoundLayer playBackLayer;

            lock (_layers)
            {
                _layers.TryGetValue(layer, out playBackLayer);
            }

            return playBackLayer;
        }

        /// <summary>
        /// Creates the sound layer.
        /// </summary>
        /// <param name="layer">The name of the layer to create.</param>
        /// <returns>The created layer.</returns>
        public SoundLayer CreateLayer(string layer)
        {
            SoundLayer playBackLayer = new SoundLayer(layer);

            lock (_layers)
            {
                _layers.Add(layer, playBackLayer);
            }

            return playBackLayer;
        }

        #endregion
    }
}