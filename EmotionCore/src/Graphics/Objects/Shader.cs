﻿// Emotion - https://github.com/Cryru/Emotion

#region Using

using System;
using Emotion.Debug;
using Emotion.Engine;
using Emotion.Libraries;
using OpenTK.Graphics.ES30;

#endregion

namespace Emotion.Graphics.Objects
{
    /// <summary>
    /// A Shader is a user-defined program designed to run on some stage of a graphics processor.
    /// </summary>
    public sealed class Shader
    {
        #region Properties

        /// <summary>
        /// The type of shader this is.
        /// </summary>
        public ShaderType Type;

        /// <summary>
        /// The shader's internal id.
        /// </summary>
        public int Pointer { get; private set; }

        #endregion

        /// <summary>
        /// Create, add source, and compile a new shader.
        /// </summary>
        /// <param name="type">The type of shader to create.</param>
        /// <param name="source">The shader string source.</param>
        public Shader(ShaderType type, string source)
        {
            Type = type;

            // Check if a version override is set.
            if (!string.IsNullOrEmpty(Context.Flags.RenderFlags.ShaderVersionOverride))
            {
                source = source.Replace("#version 300 es", Context.Flags.RenderFlags.ShaderVersionOverride);
            }

            // Fix for those who cannot bind more than one texture. This number usually means that the
            // "GL_ARB_gpu_shader5" extension is both missing and shader version "400" is not supported.
            if (Context.Flags.RenderFlags.TextureArrayLimit == 1)
            {
                source = source.Replace("int(Tid)", "0");
                Context.Log.Warning("Shader texture sampling changed to index 0 as the TextureArrayLimit flag is set to 1.", MessageSource.GL);
            }

            // Create and compile the shader.
            Pointer = GL.CreateShader(type);
            GL.ShaderSource(Pointer, source);
            GL.CompileShader(Pointer);

            // Check compilation status.
            string compileStatus = GL.GetShaderInfoLog(Pointer);
            if (compileStatus != "") throw new Exception("Failed to compile shader " + Pointer + " : " + compileStatus);
        }

        /// <summary>
        /// Deletes the shader.
        /// </summary>
        public void Destroy()
        {
            GL.DeleteShader(Pointer);
        }
    }
}