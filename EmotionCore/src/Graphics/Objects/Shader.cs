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

            // Fix for MacOS.
            if (CurrentPlatform.OS == PlatformName.Mac)
            {
                source = source.Replace("#version 300 es", "#version 330");
                Context.Log.Warning("Shader version changed from '300 es' to '330' because Mac platform was detected.", MessageSource.GL);
            }

            // Fix for missing GL_ARB_gpu_shader5.
            if ((CurrentPlatform.OS == PlatformName.Windows || CurrentPlatform.OS == PlatformName.Linux) && Renderer.Shader5ExtensionMissing)
            {
                source = source.Replace("#version 300 es", "#version 400");
                Context.Log.Warning("Shader version changed from '300 es` to 400' because the Shader5 extension is missing.", MessageSource.GL);
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