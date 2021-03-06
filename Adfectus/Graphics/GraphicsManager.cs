﻿#region Using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using Adfectus.Common;
using Adfectus.IO;
using Adfectus.Primitives;

#endregion

namespace Adfectus.Graphics
{
    /// <summary>
    /// Abstracts and manages the OpenGL functions.
    /// </summary>
    public abstract class GraphicsManager
    {
        /// <summary>
        /// The resolution to render at.
        /// </summary>
        [Obsolete("Use Engine.Renderer.CurrentTarget.Size")]
        public Vector2 RenderSize { get => Engine.Renderer.BaseTarget.Size; }

        /// <summary>
        /// The viewport.
        /// </summary>
        public Rectangle Viewport { get; protected set; }

        #region Shader Data

        /// <summary>
        /// The location of vertices within the shader.
        /// </summary>
        public readonly uint VertexLocation = 0;

        /// <summary>
        /// The location of the texture UV within the shader.
        /// </summary>
        public readonly uint UvLocation = 1;

        /// <summary>
        /// The location of the texture id within the shader.
        /// </summary>
        public readonly uint TidLocation = 2;

        /// <summary>
        /// The location of the colors within the shader.
        /// </summary>
        public readonly uint ColorLocation = 3;

        /// <summary>
        /// List of shader versions to fallback on when creating.
        /// first.
        /// </summary>
        public List<string> ShaderVersionsList = new List<string>
        {
            "400",
            "330",
            "300 es"
        };

        #endregion

        #region Render State

        /// <summary>
        /// The currently bound data buffer.
        /// </summary>
        public uint BoundDataBuffer { get; protected set; }

        /// <summary>
        /// The currently bound vertex array buffer.
        /// </summary>
        public uint BoundVertexArrayBuffer { get; protected set; }

        /// <summary>
        /// The currently bound index buffer.
        /// </summary>
        public uint BoundIndexBuffer { get; protected set; }

        /// <summary>
        /// The shader currently bound.
        /// </summary>
        public ShaderProgram CurrentShader { get; protected set; }

        #endregion

        #region Cache

        /// <summary>
        /// The default IBO for quad stream buffers. Is an index of 012230 up to MaxRender * 6
        /// </summary>
        public uint DefaultQuadIbo { get; protected set; }

        /// <summary>
        /// The default ibo. Is an index of 0..MaxRender
        /// </summary>
        public uint DefaultIbo { get; protected set; }

        protected ShaderProgram _defaultProgram;

        #endregion

        #region Init

        /// <summary>
        /// Setups the graphics manager for use.
        /// </summary>
        /// <param name="renderSize">The resolution to render at.</param>
        public abstract void Setup(Vector2 renderSize);

        /// <summary>
        /// Create the default shader.
        /// </summary>
        protected void CreateDefaultShader()
        {
            _defaultProgram = Engine.AssetLoader.Get<ShaderAsset>("Shaders/DefaultShader.xml").Shader;
            BindShaderProgram(_defaultProgram);

            CheckError("default shader setup");

            if (CurrentShader == null && _defaultProgram == null) ErrorHandler.SubmitError(new Exception("Couldn't create default shaders."));
        }

        /// <summary>
        /// Create the default quad ibo.
        /// </summary>
        protected void CreateDefaultIbo()
        {
            // Create default quad ibo.
            ushort[] indices = new ushort[Engine.Flags.RenderFlags.MaxRenderable * 6];
            uint offset = 0;
            for (int i = 0; i < indices.Length; i += 6)
            {
                indices[i] = (ushort) (offset + 0);
                indices[i + 1] = (ushort) (offset + 1);
                indices[i + 2] = (ushort) (offset + 2);
                indices[i + 3] = (ushort) (offset + 2);
                indices[i + 4] = (ushort) (offset + 3);
                indices[i + 5] = (ushort) (offset + 0);

                offset += 4;
            }

            DefaultQuadIbo = CreateDataBuffer();
            BindIndexBuffer(DefaultQuadIbo);
            UploadToIndexBuffer(indices);

            CheckError("default quad ibo setup");

            DefaultIbo = Engine.GraphicsManager.CreateDataBuffer();
            ushort[] iboData = new ushort[Engine.Flags.RenderFlags.MaxRenderable];
            for (ushort i = 0; i < iboData.Length; i++)
            {
                iboData[i] = i;
            }

            Engine.GraphicsManager.BindIndexBuffer(DefaultIbo);
            Engine.GraphicsManager.UploadToIndexBuffer(iboData);

            CheckError("default ibo setup");
        }

        #endregion

        /// <summary>
        /// Check for GL errors.
        /// </summary>
        [Conditional("DEBUG")]
        public abstract void CheckError(string location = "");

        /// <summary>
        /// Reset the GL state to the default one.
        /// </summary>
        public abstract void DefaultGLState();

        /// <summary>
        /// Reset the state and defaults.
        /// </summary>
        public virtual void ResetState()
        {
            // Reset bound buffers. Some drivers unbind objects when swapping buffers.
            BoundDataBuffer = 0;
            BoundVertexArrayBuffer = 0;
            BoundIndexBuffer = 0;
            CurrentShader = null;
            BindShaderProgram(_defaultProgram);
        }

        /// <summary>
        /// Enables or disabled depth testing.
        /// </summary>
        /// <param name="enable">Whether to enable or disable depth testing. Is on by default.</param>
        public abstract void StateDepthTest(bool enable);

        /// <summary>
        /// Enables or disables scissor testing (clipping).
        /// </summary>
        /// <param name="enable">Whether to enable or disable clip testing. Is on by default.</param>
        public abstract void StateClip(bool enable);

        /// <summary>
        /// Set the scissor region.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public abstract void SetClipRect(int x, int y, int width, int height);

        /// <summary>
        /// Set the viewport within the window.
        /// </summary>
        /// <param name="x">X position of the viewport.</param>
        /// <param name="y">Y position of the viewport.</param>
        /// <param name="width">Width of the viewport.</param>
        /// <param name="height">Height of the viewport.</param>
        public abstract void SetViewport(int x, int y, int width, int height);

        /// <summary>
        /// Clears the framebuffer. Must be run on the GL thread.
        /// </summary>
        public abstract void ClearScreen();

        #region Texture API

        /// <summary>
        /// Create a texture.
        /// </summary>
        /// <returns>The pointer to the texture object.</returns>
        public abstract uint CreateTexture();

        /// <summary>
        /// Delete a texture.
        /// </summary>
        /// <param name="pointer">The pointer of the texture to delete.</param>
        public abstract void DeleteTexture(uint pointer);

        /// <summary>
        /// Binds a texture object.
        /// </summary>
        /// <param name="texture">The texture object to bind.</param>
        /// <param name="slot">The slot to bind it to.</param>
        /// <returns>Whether the binding was performed.</returns>
        public abstract bool BindTexture(Texture texture, uint slot = 0);

        /// <summary>
        /// Binds a texture object.
        /// </summary>
        /// <param name="pointer">A pointer to the texture object to bind.</param>
        /// <param name="slot">The slot to bind it to.</param>
        /// <returns>Whether the binding was performed.</returns>
        public abstract bool BindTexture(uint pointer, uint slot = 0);

        /// <summary>
        /// Set the mask of the currently bound texture.
        /// This will apply to all pixels of the texture.
        /// </summary>
        /// <param name="r">The mask for the red channel.</param>
        /// <param name="g">The mask for the green channel.</param>
        /// <param name="b">The mask for the blue channel.</param>
        /// <param name="a">The mask for the alpha channel.</param>
        public abstract void SetTextureMask(uint r = 0xff000000, uint g = 0x00ff0000, uint b = 0x0000ff00, uint a = 0x000000ff);

        /// <summary>
        /// Upload a byte array to the currently bound texture.
        /// </summary>
        /// <param name="data">The byte array of pixels to upload.</param>
        /// <param name="size">The size of the texture.</param>
        /// <param name="internalFormat">The internal pixel format of the texture.</param>
        /// <param name="pixelFormat">The pixel format of the texture.</param>
        public unsafe void UploadToTexture(byte[] data, Vector2 size, TextureInternalFormat internalFormat, TexturePixelFormat pixelFormat)
        {
            fixed (byte* d = &data[0])
            {
                UploadToTexture((IntPtr) d, size, internalFormat, pixelFormat);
            }
        }

        /// <summary>
        /// Upload data to the currently bound texture.
        /// </summary>
        /// <param name="data">A pointer to the list of pixels to upload.</param>
        /// <param name="size">The size of the texture.</param>
        /// <param name="internalFormat">The internal pixel format of the texture.</param>
        /// <param name="pixelFormat">The pixel format of the texture.</param>
        public abstract void UploadToTexture(IntPtr data, Vector2 size, TextureInternalFormat internalFormat, TexturePixelFormat pixelFormat);

        /// <summary>
        /// Toggle smoothing on the currently bound texture.
        /// </summary>
        /// <param name="smooth">Whether to alias (smooth) the texture.</param>
        public abstract void SetTextureSmooth(bool smooth);

        #endregion

        #region Data Buffer

        /// <summary>
        /// Create a new data buffer.
        /// </summary>
        public abstract uint CreateDataBuffer();

        /// <summary>
        /// Bind a data buffer.
        /// </summary>
        /// <param name="bufferId">The id of the data buffer to bind.</param>
        /// <returns>Whether the binding was changed.</returns>
        public abstract bool BindDataBuffer(uint bufferId);

        /// <summary>
        /// Upload data to the currently bound data buffer.
        /// </summary>
        /// <typeparam name="T">The type of data to upload.</typeparam>
        /// <param name="data">The data to upload.</param>
        public abstract void UploadToDataBuffer<T>(T[] data) where T : struct;

        /// <summary>
        /// Upload data to the currently bound data buffer.
        /// </summary>
        /// <param name="data">The data to upload.</param>
        /// <param name="size">The size of the data to upload.</param>
        public abstract void UploadToDataBuffer(IntPtr data, uint size);

        /// <summary>
        /// Map data in the currently bound data buffer.
        /// </summary>
        /// <param name="data">The data to map.</param>
        /// <param name="size">The data size.</param>
        /// <param name="offset">Offset of the data.</param>
        public abstract void MapDataBuffer(IntPtr data, uint size, uint offset = 0);

        /// <summary>
        /// Destroy a data buffer.
        /// </summary>
        /// <param name="bufferId">The id of the data buffer to destroy.</param>
        public abstract void DestroyDataBuffer(uint bufferId);

        #endregion

        #region Vertex Array Buffer

        /// <summary>
        /// Create a new vertex array buffer.
        /// </summary>
        /// <returns>The id of the created vertex array buffer. Or 0 if creation failed.</returns>
        public abstract uint CreateVertexArrayBuffer();

        /// <summary>
        /// Bind a vertex array buffer.
        /// </summary>
        /// <param name="bufferId">The id of the vertex array buffer to bind.</param>
        /// <returns>Whether the binding was changed.</returns>
        public abstract bool BindVertexArrayBuffer(uint bufferId);

        /// <summary>
        /// Attach a data buffer to the vertex array data. Overwrites the currently bound data buffer and vertex array buffer.
        /// </summary>
        /// <param name="dataBufferId">The data buffer to attach to the vertex array.</param>
        /// <param name="vertexArrayBufferId">The vertex array buffer to attach to.</param>
        /// <param name="shaderIndex">The index of the buffer data for the shader.</param>
        /// <param name="componentCount">The component count of the buffer. For instance Vector3 is three components of type float.</param>
        /// <param name="dataType">The type of data within the buffer.</param>
        /// <param name="normalized">Whether the value is normalized.</param>
        /// <param name="stride">The byte offset between consecutive vertex attributes.</param>
        /// <param name="offset">The offset of the first piece of data.</param>
        public abstract void AttachDataBufferToVertexArray(uint dataBufferId, uint vertexArrayBufferId, uint shaderIndex, uint componentCount, DataType dataType, bool normalized, uint stride,
            IntPtr offset);

        /// <summary>
        /// Destroy a vertex array buffer.
        /// </summary>
        /// <param name="bufferId">The id of the vertex array buffer to destroy.</param>
        public abstract void DestroyVertexArrayBuffer(uint bufferId);

        #endregion

        #region Index Buffer

        /// <summary>
        /// Bind a data buffer as an index buffer.
        /// </summary>
        /// <param name="bufferId">The id of the data buffer to bind as an index buffer.</param>
        /// <returns>Whether the binding was changed.</returns>
        public abstract bool BindIndexBuffer(uint bufferId);

        /// <summary>
        /// Upload data to the currently bound index buffer.
        /// </summary>
        /// <typeparam name="T">The type of data to upload.</typeparam>
        /// <param name="data">The data to upload.</param>
        public abstract void UploadToIndexBuffer<T>(T[] data) where T : struct;

        /// <summary>
        /// Upload data to the currently bound index buffer.
        /// </summary>
        /// <param name="data">The data to upload.</param>
        /// <param name="size">The size of the data to upload.</param>
        public abstract void UploadToIndexBuffer(IntPtr data, uint size);

        /// <summary>
        /// Map data in the currently bound index buffer.
        /// </summary>
        /// <param name="data">The data to map.</param>
        /// <param name="size">The data size.</param>
        /// <param name="offset">Offset of the data.</param>
        public abstract void MapIndexBuffer(IntPtr data, uint size, uint offset = 0);

        #endregion

        #region Shader

        /// <summary>
        /// Compile a vertex shader and fragment shader into a shader program.
        /// </summary>
        /// <param name="vert">The vertex shader source to compile. If empty or null the default one will be used.</param>
        /// <param name="frag">The fragment shader source to compile. If empty or null the default one will be used.</param>
        /// <returns>A shader program implementation.</returns>
        public abstract ShaderProgram CreateShaderProgram(string vert, string frag);

        /// <summary>
        /// Bind a shader as the current shader.
        /// </summary>
        /// <param name="shaderProgram">The shader to bind, or null to bind the default one.</param>
        /// <returns>Whether the binding was changed.</returns>
        public abstract bool BindShaderProgram(ShaderProgram shaderProgram);

        #endregion

        #region RenderTargets and Sampling

        /// <summary>
        /// Create a render target.
        /// </summary>
        /// <param name="size">The size of the target.</param>
        /// <param name="smooth">Whether the target's texture will use smoothing.</param>
        /// <param name="internalFormat">The internal format of the target's texture. Is Rgba by default.</param>
        /// <param name="pixelFormat">The pixel format of the target's texture. Is Rgba by default.</param>
        /// <param name="attachStencil">Whether to attach a stencil buffer to the render target.</param>
        /// <returns>The created render target.</returns>
        public abstract RenderTarget CreateRenderTarget(Vector2 size, bool smooth = false, TextureInternalFormat internalFormat = TextureInternalFormat.Rgba,
            TexturePixelFormat pixelFormat = TexturePixelFormat.Rgba, bool attachStencil = false);

        /// <summary>
        /// Create a render target to be used for Multi-sampling.
        /// </summary>
        /// <param name="samples">The number of samples.</param>
        /// <param name="size">The size of the target.</param>
        /// <param name="internalFormat">The internal format of the target's texture. Is Rgba by default.</param>
        /// <param name="attachStencil">Whether to attach a stencil buffer to the render target.</param>
        /// <returns>The created MS render target.</returns>
        public abstract RenderTarget CreateMSAARenderTarget(int samples, Vector2 size, TextureInternalFormat internalFormat = TextureInternalFormat.Rgba, bool attachStencil = false);

        /// <summary>
        /// Bind a render target, causing subsequent calls to refer to it.
        /// </summary>
        /// <param name="t">The target to bind.</param>
        public abstract void BindRenderTarget(RenderTarget t);

        /// <summary>
        /// Copy data from one render target to another. This overwrites any data in the destination.
        /// </summary>
        /// <param name="source">The target to copy from.</param>
        /// <param name="dest">The target to copy to.</param>
        /// <param name="sourceRect">The location to copy from in the source.</param>
        /// <param name="destRect">The location to copy to in the destination.</param>
        /// <param name="smooth">Whether to smoothly copy.</param>
        public abstract void CopyRenderTarget(RenderTarget source, RenderTarget dest, Rectangle? sourceRect = null, Rectangle? destRect = null, bool smooth = false);

        #endregion

        #region Stencil Test

        /// <summary>
        /// Enable or disable stencil testing. Off by default.
        /// Also sets the stencil state to default, clears the buffer, and submits any content in the renderer.
        /// </summary>
        /// <param name="enable"></param>
        public abstract void StateStencilTest(bool enable);

        /// <summary>
        /// Set the stencil state to the default.
        /// Mask - 0xFF (Draw)
        /// Always 0xFF
        /// Keep Keep Replace
        /// </summary>
        public abstract void StencilModeDefault();

        /// <summary>
        /// Start drawing to the stencil buffer.
        /// Sets the state to
        /// Mask - 0xFF (Draw)
        /// Always - value
        /// </summary>
        /// <param name="value">The value to draw. Any subsequent draw calls will cause this value to be written to the stencil buffer.</param>
        public abstract void StencilStartDraw(int value = 0xFF);

        /// <summary>
        /// Starts drawing to the stencil buffer with the following state:
        /// Mask - 0x00 (No Draw)
        /// Greater - threshold
        /// </summary>
        /// <param name="threshold">The threshold to cut off at. Anything of less value in the stencil buffer will not be rendered by subsequent draw calls.</param>
        public abstract void StencilModeCutOutFrom(int threshold = 0xFF);

        /// <summary>
        /// Starts drawing to the stencil buffer with the following state:
        /// Mask - 0x00 (No Draw)
        /// Less - threshold
        /// </summary>
        /// <param name="filter">The filter to add at. Only that of greater value in the stencil buffer will be rendered by subsequent draw calls.</param>
        public abstract void StencilModeMask(int filter = 0xFF);

        /// <summary>
        /// Sets the stencil mode to a custom mode.
        /// </summary>
        /// <param name="mask">The mask to be AND-ed to the buffer data.</param>
        /// <param name="mode">The stencil function mode.</param>
        /// <param name="funcRef">The value to compare against.</param>
        /// <param name="modeMask">The stencil function mask.</param>
        public abstract void StencilModeCustom(uint mask, string mode = "Always", int funcRef = 1, uint modeMask = 0xFF);

        #endregion

        #region Other

        /// <summary>
        /// Create a streaming buffer used for drawing any vertices.
        /// </summary>
        /// <param name="vbo">The data buffer of the buffer in vertices.</param>
        /// <param name="vao">The vao to use.</param>
        /// <param name="ibo">The index buffer to attach to the stream buffer.</param>
        /// <param name="objectSize">The size in vertices of individual objects in the buffer.</param>
        /// <param name="size">The size of the buffer in vertices.</param>
        /// <param name="indicesPerObject">The indices per object.</param>
        /// <param name="polygonMode">
        /// Whether the buffer should be in polygon mode. Off by default. If not in polygon mode it is in
        /// triangle mode.
        /// </param>
        /// <returns>A streaming buffer used for drawing vertices.</returns>
        public abstract StreamBuffer CreateStreamBuffer(uint vbo, uint vao, uint ibo, uint objectSize, uint size, uint indicesPerObject, bool polygonMode = false);

        /// <summary>
        /// Create a streaming buffer used for drawing any vertices.
        /// </summary>
        /// <param name="objectSize">The size in vertices of individual objects in the buffer.</param>
        /// <param name="size">The size of the buffer in vertices.</param>
        /// <param name="ibo">The index buffer to attach to the stream buffer.</param>
        /// <param name="indicesPerObject">The indices per object.</param>
        /// <param name="polygonMode">
        /// Whether the buffer should be in polygon mode. Off by default. If not in polygon mode it is in
        /// triangle mode.
        /// </param>
        /// <returns>A streaming buffer used for drawing vertices.</returns>
        public StreamBuffer CreateStreamBuffer(uint objectSize, uint size, uint ibo, uint indicesPerObject, bool polygonMode = false)
        {
            StreamBuffer streamBuffer = null;

            GLThread.ExecuteGLThread(() =>
            {
                // First create the vbo.
                uint vbo = CreateDataBuffer();
                BindDataBuffer(vbo);
                UploadToDataBuffer(IntPtr.Zero, (uint) (size * objectSize * VertexData.SizeInBytes));

                // Create the vao.
                uint vao = CreateVertexArrayBuffer();
                GenerateDefaultVao(vao, vbo);

                // Check if using the default ibo.
                if (ibo == 0) ibo = DefaultIbo;

                // Create a GL stream buffer.
                streamBuffer = CreateStreamBuffer(vbo, vao, ibo, objectSize, size, indicesPerObject, polygonMode);
            });

            return streamBuffer;
        }

        /// <summary>
        /// Create a streaming buffer used for drawing 2d quads.
        /// </summary>
        /// <param name="size">The size of the buffer in vertices.</param>
        /// <returns>A streaming buffer used for drawing 2d quads.</returns>
        public StreamBuffer CreateQuadStreamBuffer(uint size)
        {
            StreamBuffer streamBuffer = null;

            GLThread.ExecuteGLThread(() =>
            {
                // First create the vbo.
                uint vbo = CreateDataBuffer();
                BindDataBuffer(vbo);
                UploadToDataBuffer(IntPtr.Zero, (uint) (size * 4 * VertexData.SizeInBytes));

                // Create the vao.
                uint vao = CreateVertexArrayBuffer();
                GenerateDefaultVao(vao, vbo);

                // Create a GL stream buffer.
                streamBuffer = CreateStreamBuffer(vbo, vao, DefaultQuadIbo, 4, size, 6);
            });

            return streamBuffer;
        }

        /// <summary>
        /// Get actual currently bound index buffer. Skipping the cache.
        /// </summary>
        /// <returns>The id of the currently bound index buffer.</returns>
        public abstract uint GetBoundIndexBuffer();

        /// <summary>
        /// Get actual currently bound data buffer. Skipping the cache.
        /// </summary>
        /// <returns>The id of the currently bound data buffer.</returns>
        public abstract uint GetBoundDataBuffer();

        /// <summary>
        /// Get actual currently bound vertex array buffer. Skipping the cache.
        /// </summary>
        /// <returns>The id of the currently bound vertex array buffer.</returns>
        public abstract uint GetBoundVertexArrayBuffer();

        public abstract uint GetBoundRenderTarget();

        /// <summary>
        /// Generates the default VAO.
        /// </summary>
        /// <param name="vao">Id of the vao to set.</param>
        /// <param name="vbo">Id of the vbo to fill.</param>
        public void GenerateDefaultVao(uint vao, uint vbo)
        {
            BindVertexArrayBuffer(vao);
            AttachDataBufferToVertexArray(vbo, vao, VertexLocation, 3, DataType.Float, false, (uint) VertexData.SizeInBytes, Marshal.OffsetOf(typeof(VertexData), "Vertex"));
            AttachDataBufferToVertexArray(vbo, vao, UvLocation, 2, DataType.Float, false, (uint) VertexData.SizeInBytes, Marshal.OffsetOf(typeof(VertexData), "UV"));
            AttachDataBufferToVertexArray(vbo, vao, TidLocation, 1, DataType.Float, true, (uint) VertexData.SizeInBytes, Marshal.OffsetOf(typeof(VertexData), "Tid"));
            AttachDataBufferToVertexArray(vbo, vao, ColorLocation, 4, DataType.UnsignedByte, true, (uint) VertexData.SizeInBytes,
                Marshal.OffsetOf(typeof(VertexData), "Color"));
            BindVertexArrayBuffer(0);
            BindDataBuffer(0);
        }

        #endregion
    }
}