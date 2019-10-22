﻿#region Using

using System;
using System.IO;
using System.Xml.Serialization;
using Emotion.Common;
using Emotion.Common.Threading;
using Emotion.Game.Animation;
using Emotion.Graphics.Shading;
using Emotion.Standard.Logging;

#endregion

namespace Emotion.IO
{
    /// <summary>
    /// A file in XML structure.
    /// </summary>
    /// <typeparam name="T">The class to deserialize to.</typeparam>
    public class XMLAsset<T> : Asset
    {
        /// <summary>
        /// The contents of the file.
        /// </summary>
        public T Content { get; protected set; }

        /// <summary>
        /// The serializer used for the file.
        /// </summary>
        public static XmlSerializer Serializer = new XmlSerializer(typeof(T));

        protected override void CreateInternal(byte[] data)
        {
            try
            {
                // Deserialize the shader description.
                using var stream = new MemoryStream(data);
                Content = (T)Serializer.Deserialize(stream);
            } 
            catch(Exception ex)
            {
                Engine.Log.Error(new Exception($"Couldn't parse XML asset of type {GetType()}!", ex));
            }
        }

        protected override void DisposeInternal()
        {

        }
    }
}