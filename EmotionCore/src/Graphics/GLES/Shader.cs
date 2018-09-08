﻿// Emotion - https://github.com/Cryru/Emotion

#region Using

using System;
using Emotion.Utils;
using OpenTK.Graphics.ES30;
using Soul;

#endregion

namespace Emotion.Graphics.GLES
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

        #region Defaults

        public static Shader DefaultVertex;
        public static Shader DefaultFragment;

        #endregion

        /// <summary>
        /// Load defaults.
        /// </summary>
        static Shader()
        {
            string defaultVertex = Utilities.ReadEmbeddedResource("Emotion.Embedded.Shaders.DefaultVertex.glsl");
            string defaultFrag = Utilities.ReadEmbeddedResource("Emotion.Embedded.Shaders.DefaultFrag.glsl");
            DefaultVertex = new Shader(ShaderType.VertexShader, defaultVertex);
            DefaultFragment = new Shader(ShaderType.FragmentShader, defaultFrag);

            Helpers.CheckError("making default shaders");
        }

        /// <summary>
        /// Create, add source, and compile a new shader.
        /// </summary>
        /// <param name="type">The type of shader to create.</param>
        /// <param name="source">The shader string source.</param>
        public Shader(ShaderType type, string source)
        {
            Type = type;

            // Fix for MacOS.
            if (CurrentPlatform.OS == PlatformID.MacOSX) source = source.Replace("#version 300 es", "#version 330");

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