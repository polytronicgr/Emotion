#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective

#region Using

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Emotion.Platform.Helpers;
using Khronos;

#endregion

// ReSharper disable StringLiteralTypo
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer
// ReSharper disable InvalidXmlDocComment
// ReSharper disable CommentTypo
namespace OpenGL
{
    public partial class Gl
    {
        /// <summary>
        /// [GL4|GLES3.2] Gl.Clear: Indicates the depth buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const uint DEPTH_BUFFER_BIT = 0x00000100;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Clear: Indicates the stencil buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const uint STENCIL_BUFFER_BIT = 0x00000400;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Clear: Indicates the buffers currently enabled for color writing.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const uint COLOR_BUFFER_BIT = 0x00004000;

        /// <summary>
        /// [GL] Value of GL_FALSE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int FALSE = 0;

        /// <summary>
        /// [GL] Value of GL_TRUE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TRUE = 1;

        /// <summary>
        /// [GL2.1] Gl.Begin: Treats each vertex as a single point. Vertex n defines point n. N points are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int POINTS = 0x0000;

        /// <summary>
        /// [GL2.1] Gl.Begin: Treats each pair of vertices as an independent line segment. Vertices 2⁢n-1 and 2⁢n define line n. N2
        /// lines are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LINES = 0x0001;

        /// <summary>
        /// [GL2.1] Gl.Begin: Draws a connected group of line segments from the first vertex to the last, then back to the first.
        /// Vertices n and n+1 define line n. The last line, however, is defined by vertices N and 1. N lines are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LINE_LOOP = 0x0002;

        /// <summary>
        /// [GL2.1] Gl.Begin: Draws a connected group of line segments from the first vertex to the last. Vertices n and n+1 define
        /// line n. N-1 lines are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LINE_STRIP = 0x0003;

        /// <summary>
        /// [GL2.1] Gl.Begin: Treats each triplet of vertices as an independent triangle. Vertices 3⁢n-2, 3⁢n-1, and 3⁢n define
        /// triangle n. N3 triangles are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int TRIANGLES = 0x0004;

        /// <summary>
        /// [GL2.1] Gl.Begin: Draws a connected group of triangles. One triangle is defined for each vertex presented after the
        /// first two vertices. For odd n, vertices n, n+1, and n+2 define triangle n. For even n, vertices n+1, n, and n+2 define
        /// triangle n. N-2 triangles are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TRIANGLE_STRIP = 0x0005;

        /// <summary>
        /// [GL2.1] Gl.Begin: Draws a connected group of triangles. One triangle is defined for each vertex presented after the
        /// first two vertices. Vertices 1, n+1, and n+2 define triangle n. N-2 triangles are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TRIANGLE_FAN = 0x0006;

        /// <summary>
        /// [GL2.1] Gl.Begin: Treats each group of four vertices as an independent quadrilateral. Vertices 4⁢n-3, 4⁢n-2, 4⁢n-1, and
        /// 4⁢n define quadrilateral n. N4 quadrilaterals are drawn.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_4_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int QUADS = 0x0007;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Never passes.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Always fails.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Always fails.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Never passes.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Always fails.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Always fails.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int NEVER = 0x0200;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Passes if the incoming depth value is less than the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Passes if the incoming depth value is less than the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LESS = 0x0201;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Passes if the incoming depth value is equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Passes if the incoming depth value is equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int EQUAL = 0x0202;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Passes if the incoming depth value is less than or equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Passes if the incoming depth value is less than or equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LEQUAL = 0x0203;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Passes if the incoming depth value is greater than the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Passes if the incoming depth value is greater than the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int GREATER = 0x0204;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Passes if the incoming depth value is not equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Passes if the incoming depth value is not equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int NOTEQUAL = 0x0205;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Passes if the incoming depth value is greater than or equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Passes if the incoming depth value is greater than or equal to the stored depth value.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int GEQUAL = 0x0206;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DepthFunc: Always passes.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFunc: Always passes.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.StencilFuncSeparate: Always passes.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DepthFunc: Always passes.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFunc: Always passes.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.StencilFuncSeparate: Always passes.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int ALWAYS = 0x0207;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Sets the stencil buffer value to 0.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Sets the stencil buffer value to 0.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
        [RequiredByFeature("GL_NV_register_combiners")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int ZERO = 0;

        /// <summary>
        /// [GL] Value of GL_ONE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int ONE = 1;

        /// <summary>
        /// [GL] Value of GL_SRC_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int SRC_COLOR = 0x0300;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_SRC_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int ONE_MINUS_SRC_COLOR = 0x0301;

        /// <summary>
        /// [GL] Value of GL_SRC_ALPHA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int SRC_ALPHA = 0x0302;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_SRC_ALPHA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int ONE_MINUS_SRC_ALPHA = 0x0303;

        /// <summary>
        /// [GL] Value of GL_DST_ALPHA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int DST_ALPHA = 0x0304;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_DST_ALPHA symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int ONE_MINUS_DST_ALPHA = 0x0305;

        /// <summary>
        /// [GL] Value of GL_DST_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int DST_COLOR = 0x0306;

        /// <summary>
        /// [GL] Value of GL_ONE_MINUS_DST_COLOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int ONE_MINUS_DST_COLOR = 0x0307;

        /// <summary>
        /// [GL] Value of GL_SRC_ALPHA_SATURATE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
        public const int SRC_ALPHA_SATURATE = 0x0308;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DrawBuffer: No color buffers are written.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.DrawBuffers: The fragment shader output value is not written into any color buffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DrawBuffers: The fragment shader output value is not written into any color buffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_VERSION_4_6")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
        [RequiredByFeature("GL_NV_register_combiners")]
        [RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
        public const int NONE = 0;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DrawBuffer: Only the front left color buffer is written.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.DrawBuffers: The fragment shader output value is written into the front left color buffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int FRONT_LEFT = 0x0400;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DrawBuffer: Only the front right color buffer is written.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.DrawBuffers: The fragment shader output value is written into the front right color buffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int FRONT_RIGHT = 0x0401;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DrawBuffer: Only the back left color buffer is written.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.DrawBuffers: The fragment shader output value is written into the back left color buffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int BACK_LEFT = 0x0402;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DrawBuffer: Only the back right color buffer is written.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.DrawBuffers: The fragment shader output value is written into the back right color buffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int BACK_RIGHT = 0x0403;

        /// <summary>
        /// [GL4] Gl.DrawBuffer: Only the front left and front right color buffers are written. If there is no front right color
        /// buffer, only the front left color buffer is written.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int FRONT = 0x0404;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.DrawBuffer: Only the back left and back right color buffers are written. If there is no back right color
        ///     buffer, only the back left color buffer is written.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.DrawBuffers: The fragment shader output value is written into the back color buffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
        public const int BACK = 0x0405;

        /// <summary>
        /// [GL4] Gl.DrawBuffer: Only the front left and back left color buffers are written. If there is no back left color
        /// buffer,
        /// only the front left color buffer is written.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int LEFT = 0x0406;

        /// <summary>
        /// [GL4] Gl.DrawBuffer: Only the front right and back right color buffers are written. If there is no back right color
        /// buffer, only the front right color buffer is written.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int RIGHT = 0x0407;

        /// <summary>
        /// [GL4] Gl.DrawBuffer: All the front and back color buffers (front left, front right, back left, back right) are written.
        /// If there are no back color buffers, only the front left and front right color buffers are written. If there are no
        /// right
        /// color buffers, only the front left and back left color buffers are written. If there are no right or back color
        /// buffers,
        /// only the front left color buffer is written.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int FRONT_AND_BACK = 0x0408;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetError: No error has been recorded. The value of this symbolic constant is guaranteed to be 0.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetGraphicsResetStatus: Indicates that the GL context has not been in a reset state since the last
        ///     call.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_4_5")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
        [RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
        public const int NO_ERROR = 0;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetError: An unacceptable value is specified for an enumerated argument. The offending command is
        /// ignored and has no other side effect than to set the error flag.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int INVALID_ENUM = 0x0500;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetError: A numeric argument is out of range. The offending command is ignored and has no other side
        /// effect than to set the error flag.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int INVALID_VALUE = 0x0501;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetError: The specified operation is not allowed in the current state. The offending command is
        /// ignored
        /// and has no other side effect than to set the error flag.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int INVALID_OPERATION = 0x0502;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetError: There is not enough memory left to execute the command. The state of the GL is undefined,
        /// except for the state of the error flags, after this error is recorded.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int OUT_OF_MEMORY = 0x0505;

        /// <summary>
        /// [GL] Value of GL_CW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int CW = 0x0900;

        /// <summary>
        /// [GL] Value of GL_CCW symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
        [RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
        public const int CCW = 0x0901;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the point size as specified by Gl.PointSize. The initial value is 1.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the point size as specified by Gl.PointSize.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int POINT_SIZE = 0x0B11;

        /// <summary>
        /// [GL4] Gl.Get: data returns two values: the smallest and largest supported sizes for antialiased points. The smallest
        /// size must be at most 1, and the largest size must be at least 1. See Gl.PointSize.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int POINT_SIZE_RANGE = 0x0B12;

        /// <summary>
        /// [GL4] Gl.Get: data returns one value, the size difference between adjacent supported sizes for antialiased points. See
        /// Gl.PointSize.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int POINT_SIZE_GRANULARITY = 0x0B13;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single boolean value indicating whether antialiasing of lines is enabled. The initial
        ///     value
        ///     is Gl.FALSE. See Gl.LineWidth.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, draw lines with correct filtering. Otherwise, draw aliased lines. See
        ///     Gl.LineWidth.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether line antialiasing is enabled. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.LineWidth.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int LINE_SMOOTH = 0x0B20;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the line width as specified with Gl.LineWidth. The initial value is 1.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LINE_WIDTH = 0x0B21;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns two values: the smallest and largest supported widths for antialiased lines. See
        /// Gl.LineWidth.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int LINE_WIDTH_RANGE = 0x0B22;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the width difference between adjacent supported widths for antialiased lines.
        /// See Gl.LineWidth.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int LINE_WIDTH_GRANULARITY = 0x0B23;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns two values: symbolic constants indicating whether front-facing and back-facing polygons
        /// are rasterized as points, lines, or filled polygons. The initial value is Gl.FILL. See Gl.PolygonMode.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
        public const int POLYGON_MODE = 0x0B40;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single boolean value indicating whether antialiasing of polygons is enabled. The initial
        /// value is Gl.FALSE. See Gl.PolygonMode.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int POLYGON_SMOOTH = 0x0B41;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single boolean value indicating whether polygon culling is enabled. The initial
        /// value is Gl.FALSE. See Gl.CullFace.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int CULL_FACE = 0x0B44;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single value indicating the mode of polygon culling. The initial value is Gl.BACK.
        /// See Gl.CullFace.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int CULL_FACE_MODE = 0x0B45;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating whether clockwise or counterclockwise
        ///     polygon
        ///     winding is treated as front-facing. The initial value is Gl.CCW. See Gl.FrontFace.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single value indicating the winding order of polygon front faces. The initial
        ///     value is
        ///     Gl.CCW. See Gl.FrontFace.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int FRONT_FACE = 0x0B46;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns two values: the near and far mapping limits for the depth buffer. Integer values, if
        ///     requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most
        ///     positive
        ///     representable integer value, and -1.0 returns the most negative representable integer value. The initial value is
        ///     (0,
        ///     1). See Gl.DepthRange.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns two values: the near and far mapping limits for the depth buffer. Integer values, if
        ///     requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most
        ///     positive
        ///     representable integer value, and -1.0 returns the most negative representable integer value. The initial value is
        ///     (0,
        ///     1). See Gl.DepthRangef.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int DEPTH_RANGE = 0x0B70;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single boolean value indicating whether depth testing of fragments is enabled. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.DepthFunc and Gl.DepthRange.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns a single boolean value indicating whether depth testing of fragments is enabled. The
        ///     initial value is Gl.FALSE. See Gl.DepthFunc and Gl.DepthRangef.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int DEPTH_TEST = 0x0B71;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single boolean value indicating if the depth buffer is enabled for writing. The
        /// initial value is Gl.TRUE. See Gl.DepthMask.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int DEPTH_WRITEMASK = 0x0B72;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the value that is used to clear the depth buffer. Integer values, if
        ///     requested,
        ///     are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive
        ///     representable integer value, and -1.0 returns the most negative representable integer value. The initial value is
        ///     1. See
        ///     Gl.ClearDepth.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the value that is used to clear the depth buffer. Integer values, if
        ///     requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most
        ///     positive
        ///     representable integer value, and -1.0 returns the most negative representable integer value. The initial value is
        ///     1. See
        ///     Gl.ClearDepthf.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int DEPTH_CLEAR_VALUE = 0x0B73;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the symbolic constant that indicates the depth comparison function. The
        /// initial value is Gl.LESS. See Gl.DepthFunc.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int DEPTH_FUNC = 0x0B74;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single boolean value indicating whether stencil testing of fragments is enabled.
        /// The initial value is Gl.FALSE. See Gl.StencilFunc and Gl.StencilOp.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_TEST = 0x0B90;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the index to which the stencil bitplanes are cleared. The initial value
        /// is
        /// 0. See Gl.ClearStencil.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_CLEAR_VALUE = 0x0B91;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what function is used to compare the
        /// stencil reference value with the stencil buffer value. The initial value is Gl.ALWAYS. See Gl.StencilFunc. This stencil
        /// state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See
        /// Gl.StencilFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_FUNC = 0x0B92;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the mask that is used to mask both the stencil reference value and the
        /// stencil buffer value before they are compared. The initial value is all 1's. See Gl.StencilFunc. This stencil state
        /// only
        /// affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See
        /// Gl.StencilFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_VALUE_MASK = 0x0B93;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test
        /// fails. The initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects non-polygons and front-facing
        /// polygons. Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_FAIL = 0x0B94;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test
        /// passes, but the depth test fails. The initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects
        /// non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_PASS_DEPTH_FAIL = 0x0B95;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test
        /// passes and the depth test passes. The initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects
        /// non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_PASS_DEPTH_PASS = 0x0B96;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the reference value that is compared with the contents of the stencil
        /// buffer. The initial value is 0. See Gl.StencilFunc. This stencil state only affects non-polygons and front-facing
        /// polygons. Back-facing polygons use separate stencil state. See Gl.StencilFuncSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_REF = 0x0B97;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, the mask that controls writing of the stencil bitplanes. The initial
        /// value
        /// is all 1's. See Gl.StencilMask. This stencil state only affects non-polygons and front-facing polygons. Back-facing
        /// polygons use separate stencil state. See Gl.StencilMaskSeparate.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int STENCIL_WRITEMASK = 0x0B98;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: When used with non-indexed variants of glGet (such as glGetIntegerv), data returns four values: the x
        ///     and
        ///     y window coordinates of the viewport, followed by its width and height. Initially the x and y window coordinates
        ///     are
        ///     both set to 0, and the width and height are set to the width and height of the window into which the GL will do its
        ///     rendering. See Gl.Viewport. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns four
        ///     values: the x and y window coordinates of the indexed viewport, followed by its width and height. Initially the x
        ///     and y
        ///     window coordinates are both set to 0, and the width and height are set to the width and height of the window into
        ///     which
        ///     the GL will do its rendering. See glViewportIndexedf.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns four values: the x and y window coordinates of the viewport, followed by its width
        ///     and
        ///     height. Initially the x and y window coordinates are both set to 0, and the width and height are set to the width
        ///     and
        ///     height of the window into which the GL will do its rendering. See Gl.Viewport.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int VIEWPORT = 0x0BA2;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single boolean value indicating whether dithering of fragment colors and indices
        /// is
        /// enabled. The initial value is Gl.TRUE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int DITHER = 0x0BD0;

        /// <summary>
        /// [GLES1.1] Gl.Get: params returns one value, the symbolic constant identifying the destination blend function. See
        /// Gl.BlendFunc.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int BLEND_DST = 0x0BE0;

        /// <summary>
        /// [GLES1.1] Gl.Get: params returns one value, the symbolic constant identifying the source blend function. See
        /// Gl.BlendFunc.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int BLEND_SRC = 0x0BE1;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single boolean value indicating whether blending is enabled. The initial value is
        /// Gl.FALSE. See Gl.BlendFunc.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int BLEND = 0x0BE2;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, a symbolic constant indicating the selected logic operation mode. The initial
        ///     value is Gl.COPY. See Gl.LogicOp.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating the selected logic operation mode. See
        ///     Gl.LogicOp.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int LOGIC_OP_MODE = 0x0BF0;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, a symbolic constant indicating which buffers are being drawn to. See
        ///     Gl.DrawBuffer. The initial value is Gl.BACK if there are back buffers, otherwise it is Gl.FRONT.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating which buffers are being drawn to by the
        ///     corresponding output color. See Gl.DrawBuffers. The initial value of Gl.DRAW_BUFFER0 is Gl.BACK. The initial values
        ///     of
        ///     draw buffers for all other output colors is Gl.NONE.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
        public const int DRAW_BUFFER = 0x0C01;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, a symbolic constant indicating which color buffer is selected for reading.
        ///     The
        ///     initial value is Gl.BACK if there is a back buffer, otherwise it is Gl.FRONT. See Gl.ReadPixels.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, a symbolic constant indicating which color buffer is selected for
        ///     reading. The
        ///     initial value is Gl.BACK. See Gl.ReadPixels.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
        [RequiredByFeature("GL_NV_read_buffer", Api = "gles2")]
        public const int READ_BUFFER = 0x0C02;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns four values: the x and y window coordinates of the scissor box, followed by its
        /// width
        /// and height. Initially the x and y window coordinates are both 0 and the width and height are set to the size of the
        /// window. See Gl.Scissor.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int SCISSOR_BOX = 0x0C10;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns a single boolean value indicating whether scissoring is enabled. The initial value
        /// is
        /// Gl.FALSE. See Gl.Scissor.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
        [RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
        [RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
        public const int SCISSOR_TEST = 0x0C11;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns four values: the red, green, blue, and alpha values used to clear the color buffers.
        /// Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns
        /// the most positive representable integer value, and -1.0 returns the most negative representable integer value. The
        /// initial value is (0, 0, 0, 0). See Gl.ClearColor.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int COLOR_CLEAR_VALUE = 0x0C22;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns four boolean values: the red, green, blue, and alpha write enables for the color
        /// buffers. The initial value is (Gl.TRUE, Gl.TRUE, Gl.TRUE, Gl.TRUE). See Gl.ColorMask.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
        [RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
        public const int COLOR_WRITEMASK = 0x0C23;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single boolean value indicating whether double buffering is supported.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: param returns a boolean value indicating whether double buffering is supported
        ///     for the
        ///     framebuffer object.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int DOUBLEBUFFER = 0x0C32;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns a single boolean value indicating whether stereo buffers (left and right) are supported.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.GetFramebufferParameter: param returns a boolean value indicating whether stereo buffers (left and right)
        ///     are
        ///     supported for the framebuffer object.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int STEREO = 0x0C33;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, a symbolic constant indicating the mode of the line antialiasing hint. The
        ///     initial
        ///     value is Gl.DONT_CARE. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.Hint: Indicates the sampling quality of antialiased lines. If a larger filter function is applied, hinting
        ///     Gl.NICEST can result in more pixel fragments being generated during rasterization.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the line antialiasing hint.
        ///     See
        ///     Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Hint: Indicates the sampling quality of antialiased lines. If a larger filter function is applied,
        ///     hinting
        ///     Gl.NICEST can result in more pixel fragments being generated during rasterization.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int LINE_SMOOTH_HINT = 0x0C52;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, a symbolic constant indicating the mode of the polygon antialiasing hint. The
        ///     initial value is Gl.DONT_CARE. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GL4] Gl.Hint: Indicates the sampling quality of antialiased polygons. Hinting Gl.NICEST can result in more pixel
        ///     fragments being generated during rasterization, if a larger filter function is applied.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int POLYGON_SMOOTH_HINT = 0x0C53;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices
        /// and components are swapped after being read from memory. The initial value is Gl.FALSE. See Gl.PixelStore.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int UNPACK_SWAP_BYTES = 0x0CF0;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single boolean value indicating whether single-bit pixels being read from memory are read
        /// first from the least significant bit of each unsigned byte. The initial value is Gl.FALSE. See Gl.PixelStore.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int UNPACK_LSB_FIRST = 0x0CF1;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the row length used for reading pixel data from memory. The initial value is
        ///     0.
        ///     See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the row length used for reading pixel data from memory. The initial value
        ///     is
        ///     0. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
        public const int UNPACK_ROW_LENGTH = 0x0CF2;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is read
        ///     from
        ///     memory. The initial value is 0. See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is
        ///     read
        ///     from memory. The initial value is 0. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
        public const int UNPACK_SKIP_ROWS = 0x0CF3;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is read from
        ///     memory.
        ///     The initial value is 0. See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is read from
        ///     memory. The initial value is 0. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
        public const int UNPACK_SKIP_PIXELS = 0x0CF4;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the byte alignment used for reading pixel data from memory. The initial value
        ///     is
        ///     4. See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the byte alignment used for reading pixel data from memory. The initial
        ///     value
        ///     is 4. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int UNPACK_ALIGNMENT = 0x0CF5;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices
        /// and components are swapped before being written to memory. The initial value is Gl.FALSE. See Gl.PixelStore.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int PACK_SWAP_BYTES = 0x0D00;

        /// <summary>
        /// [GL4] Gl.Get: data returns a single boolean value indicating whether single-bit pixels being written to memory are
        /// written first to the least significant bit of each unsigned byte. The initial value is Gl.FALSE. See Gl.PixelStore.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] public const int PACK_LSB_FIRST = 0x0D01;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the row length used for writing pixel data to memory. The initial value is 0.
        ///     See
        ///     Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the row length used for writing pixel data to memory. The initial value
        ///     is 0.
        ///     See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int PACK_ROW_LENGTH = 0x0D02;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is
        ///     written
        ///     into memory. The initial value is 0. See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is
        ///     written into memory. The initial value is 0. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int PACK_SKIP_ROWS = 0x0D03;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is written into
        ///     memory. The initial value is 0. See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is written
        ///     into
        ///     memory. The initial value is 0. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public const int PACK_SKIP_PIXELS = 0x0D04;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value, the byte alignment used for writing pixel data to memory. The initial value
        ///     is 4.
        ///     See Gl.PixelStore.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the byte alignment used for writing pixel data to memory. The initial
        ///     value is
        ///     4. See Gl.PixelStorei.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int PACK_ALIGNMENT = 0x0D05;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.Get: data returns one value. The value gives a rough estimate of the largest texture that the GL can
        ///     handle.
        ///     The value must be at least 1024. Use a proxy texture target such as Gl.PROXY_TEXTURE_1D or Gl.PROXY_TEXTURE_2D to
        ///     determine if a texture is too large. See Gl.TexImage1D and Gl.TexImage2D.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value. The value gives a rough estimate of the largest texture that the GL can
        ///     handle. The value must be at least 2048. See Gl.TexImage2D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int MAX_TEXTURE_SIZE = 0x0D33;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns two values: the maximum supported width and height of the viewport. These must be at
        /// least as large as the visible dimensions of the display being rendered to. See Gl.Viewport.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int MAX_VIEWPORT_DIMS = 0x0D3A;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Get: data returns one value, an estimate of the number of bits of subpixel resolution that are used to
        /// position rasterized geometry in window coordinates. The value must be at least 4.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int SUBPIXEL_BITS = 0x0D50;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no fragment shader is active, one-dimensional texturing is performed (unless two-
        ///     or
        ///     three-dimensional or cube-mapped texturing is also enabled). See Gl.TexImage1D.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D texture mapping is enabled. The initial
        ///     value is Gl.FALSE. See Gl.TexImage1D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        public const int TEXTURE_1D = 0x0DE0;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no fragment shader is active, two-dimensional texturing is performed (unless
        ///     three-dimensional or cube-mapped texturing is also enabled). See Gl.TexImage2D.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D texture mapping is enabled. The initial
        ///     value is Gl.FALSE. See Gl.TexImage2D.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, two-dimensional texturing is performed for the active texture unit. See
        ///     Gl.ActiveTexture, Gl.TexImage2D, Gl.CompressedTexImage2D, and Gl.CopyTexImage2D.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether 2D texturing is enabled. The initial
        ///     value is
        ///     Gl.FALSE. See Gl.TexImage2D.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
        [RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
        public const int TEXTURE_2D = 0x0DE1;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexLevelParameter: params returns a single value, the width of the texture image. The initial value
        /// is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public const int TEXTURE_WIDTH = 0x1000;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetTexLevelParameter: params returns a single value, the height of the texture image. The initial
        /// value
        /// is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public const int TEXTURE_HEIGHT = 0x1001;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns four integer or floating-point numbers that comprise the RGBA color
        ///     of the
        ///     texture border. Floating-point values are returned in the range 01. Integer values are returned as a linear mapping
        ///     of
        ///     the internal floating-point representation such that 1.0 maps to the most positive representable integer and -1.0
        ///     maps
        ///     to the most negative representable integer. The initial value is (0, 0, 0, 0).
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns four integer or floating-point numbers that comprise the RGBA color of
        ///     the
        ///     texture border. Floating-point values are returned in the range 01. Integer values are returned as a linear mapping
        ///     of
        ///     the internal floating-point representation such that 1.0 maps to the most positive representable integer and -1.0
        ///     maps
        ///     to the most negative representable integer. The initial value is (0, 0, 0, 0).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
        [RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
        public const int TEXTURE_BORDER_COLOR = 0x1004;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Hint: No preference.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int DONT_CARE = 0x1100;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Hint: The most efficient option should be chosen.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int FASTEST = 0x1101;

        /// <summary>
        /// [GL4|GLES3.2] Gl.Hint: The most correct, or highest quality, option should be chosen.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int NICEST = 0x1102;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of signed bytes, each in the range -128 through 127.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
        [RequiredByFeature("GL_OES_byte_coordinates", Api = "gl|gles1")]
        public const int BYTE = 0x1400;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of unsigned bytes, each in the range 0 through 255.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int UNSIGNED_BYTE = 0x1401;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of signed two-byte integers, each in the range -32768 through 32767.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
        public const int SHORT = 0x1402;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of unsigned two-byte integers, each in the range 0 through 65535.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
        public const int UNSIGNED_SHORT = 0x1403;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of signed four-byte integers.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int INT = 0x1404;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of unsigned four-byte integers.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
        public const int UNSIGNED_INT = 0x1405;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of four-byte floating-point values.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_ARB_vertex_shader")]
        [RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
        public const int FLOAT = 0x1406;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetError: An attempt has been made to perform an operation that would cause an internal stack to overflow.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetError: This command would cause a stack overflow. The offending command is ignored, and has no
        ///     other
        ///     side effect than to set the error flag.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int STACK_OVERFLOW = 0x0503;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetError: An attempt has been made to perform an operation that would cause an internal stack to
        ///     underflow.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetError: This command would cause a stack underflow. The offending command is ignored, and has no
        ///     other
        ///     side effect than to set the error flag.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_4_3")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles1|gles2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int STACK_UNDERFLOW = 0x0504;

        /// <summary>
        /// [GL] Value of GL_CLEAR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int CLEAR = 0x1500;

        /// <summary>
        /// [GL] Value of GL_AND symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int AND = 0x1501;

        /// <summary>
        /// [GL] Value of GL_AND_REVERSE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int AND_REVERSE = 0x1502;

        /// <summary>
        /// [GL] Value of GL_COPY symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int COPY = 0x1503;

        /// <summary>
        /// [GL] Value of GL_AND_INVERTED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int AND_INVERTED = 0x1504;

        /// <summary>
        /// [GL] Value of GL_NOOP symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int NOOP = 0x1505;

        /// <summary>
        /// [GL] Value of GL_XOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
        public const int XOR = 0x1506;

        /// <summary>
        /// [GL] Value of GL_OR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int OR = 0x1507;

        /// <summary>
        /// [GL] Value of GL_NOR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int NOR = 0x1508;

        /// <summary>
        /// [GL] Value of GL_EQUIV symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int EQUIV = 0x1509;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Bitwise inverts the current stencil buffer value.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Bitwise inverts the current stencil buffer value.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
        public const int INVERT = 0x150A;

        /// <summary>
        /// [GL] Value of GL_OR_REVERSE symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int OR_REVERSE = 0x150B;

        /// <summary>
        /// [GL] Value of GL_COPY_INVERTED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int COPY_INVERTED = 0x150C;

        /// <summary>
        /// [GL] Value of GL_OR_INVERTED symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int OR_INVERTED = 0x150D;

        /// <summary>
        /// [GL] Value of GL_NAND symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int NAND = 0x150E;

        /// <summary>
        /// [GL] Value of GL_SET symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public const int SET = 0x150F;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.MatrixMode: Applies subsequent matrix operations to the texture matrix stack.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TEXTURE = 0x1702;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.CopyPixels: Indices or RGBA colors are read from the buffer currently specified as the read source
        ///     buffer
        ///     (see Gl.ReadBuffer). If the GL is in color index mode, each index that is read from this buffer is converted to a
        ///     fixed-point format with an unspecified number of bits to the right of the binary point. Each index is then shifted
        ///     left
        ///     by Gl.INDEX_SHIFT bits, and added to Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In
        ///     either case, zero bits fill otherwise unspecified bit locations in the result. If Gl.MAP_COLOR is true, the index
        ///     is
        ///     replaced with the value that it references in lookup table Gl.PIXEL_MAP_I_TO_I. Whether the lookup replacement of
        ///     the
        ///     index is done or not, the integer part of the index is then ANDed with 2b-1, where b is the number of bits in a
        ///     color
        ///     index buffer. If the GL is in RGBA mode, the red, green, blue, and alpha components of each pixel that is read are
        ///     converted to an internal floating-point format with unspecified precision. The conversion maps the largest
        ///     representable
        ///     component value to 1.0, and component value 0 to 0.0. The resulting floating-point color values are then multiplied
        ///     by
        ///     Gl.c_SCALE and added to Gl.c_BIAS, where c is RED, GREEN, BLUE, and ALPHA for the respective color components. The
        ///     results are clamped to the range [0,1]. If Gl.MAP_COLOR is true, each color component is scaled by the size of
        ///     lookup
        ///     table Gl.PIXEL_MAP_c_TO_c, then replaced by the value that it references in that table. c is R, G, B, or A. If the
        ///     ARB_imaging extension is supported, the color values may be additionally processed by color-table lookups,
        ///     color-matrix
        ///     transformations, and convolution filters. The GL then converts the resulting indices or RGBA colors to fragments by
        ///     attaching the current raster position z coordinate and texture coordinates to each pixel, then assigning window
        ///     coordinates xr+iyr+j, where xryr is the current raster position, and the pixel was the ith pixel in the jth row.
        ///     These
        ///     pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or polygons.
        ///     Texture
        ///     mapping, fog, and all the fragment operations are applied before the fragments are written to the frame buffer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.MatrixMode: Applies subsequent matrix operations to the color matrix stack.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
        public const int COLOR = 0x1800;

        /// <summary>
        /// [GL2.1] Gl.CopyPixels: Depth values are read from the depth buffer and converted directly to an internal floating-point
        /// format with unspecified precision. The resulting floating-point depth value is then multiplied by Gl.DEPTH_SCALE and
        /// added to Gl.DEPTH_BIAS. The result is clamped to the range [0,1]. The GL then converts the resulting depth components
        /// to
        /// fragments by attaching the current raster position color or color index and texture coordinates to each pixel, then
        /// assigning window coordinates xr+iyr+j, where xryr is the current raster position, and the pixel was the ith pixel in
        /// the
        /// jth row. These pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or
        /// polygons. Texture mapping, fog, and all the fragment operations are applied before the fragments are written to the
        /// frame buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
        public const int DEPTH = 0x1801;

        /// <summary>
        /// [GL2.1] Gl.CopyPixels: Stencil indices are read from the stencil buffer and converted to an internal fixed-point format
        /// with an unspecified number of bits to the right of the binary point. Each fixed-point index is then shifted left by
        /// Gl.INDEX_SHIFT bits, and added to Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either
        /// case, zero bits fill otherwise unspecified bit locations in the result. If Gl.MAP_STENCIL is true, the index is
        /// replaced
        /// with the value that it references in lookup table Gl.PIXEL_MAP_S_TO_S. Whether the lookup replacement of the index is
        /// done or not, the integer part of the index is then ANDed with 2b-1, where b is the number of bits in the stencil
        /// buffer.
        /// The resulting stencil indices are then written to the stencil buffer such that the index read from the ith location of
        /// the jth row is written to location xr+iyr+j, where xryr is the current raster position. Only the pixel ownership test,
        /// the scissor test, and the stencil writemask affect these write operations.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
        public const int STENCIL = 0x1802;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single value, a stencil index. It is converted to fixed-point format, with
        ///     an
        ///     unspecified number of bits to the right of the binary point, regardless of the memory data type. Floating-point
        ///     values
        ///     convert to true fixed-point values. Signed and unsigned integer data is converted with all fraction bits set to 0.
        ///     Bitmap data convert to either 0 or 1. Each fixed-point index is then shifted left by Gl.INDEX_SHIFT bits, and added
        ///     to
        ///     Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either case, zero bits fill otherwise
        ///     unspecified bit locations in the result. If Gl.MAP_STENCIL is true, the index is replaced with the value that it
        ///     references in lookup table Gl.PIXEL_MAP_S_TO_S. Whether the lookup replacement of the index is done or not, the
        ///     integer
        ///     part of the index is then ANDed with 2b-1, where b is the number of bits in the stencil buffer. The resulting
        ///     stencil
        ///     indices are then written to the stencil buffer such that the nth index is written to location
        ///     xn=xr+n%widthyn=yr+nwidth
        ///     where xryr is the current raster position. Only the pixel ownership test, the scissor test, and the stencil
        ///     writemask
        ///     affect these write operations.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels: Stencil values are read from the stencil buffer. Each index is converted to fixed point,
        ///     shifted
        ///     left or right depending on the value and sign of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET. If Gl.MAP_STENCIL is
        ///     Gl.TRUE, indices are replaced by their mappings in the table Gl.PIXEL_MAP_S_TO_S.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_4_4")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        [RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
        [RequiredByFeature("GL_ARB_texture_stencil8", Api = "gl|glcore")]
        [RequiredByFeature("GL_OES_texture_stencil8", Api = "gles2")]
        public const int STENCIL_INDEX = 0x1901;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single-depth component. Floating-point data is converted directly to an
        ///     internal
        ///     floating-point format with unspecified precision. Signed integer data is mapped linearly to the internal
        ///     floating-point
        ///     format such that the most positive representable integer value maps to 1.0, and the most negative representable
        ///     value
        ///     maps to -1.0. Unsigned integer data is mapped similarly: the largest integer value maps to 1.0, and 0 maps to 0.0.
        ///     The
        ///     resulting floating-point depth value is then multiplied by Gl.DEPTH_SCALE and added to Gl.DEPTH_BIAS. The result is
        ///     clamped to the range 01. The GL then converts the resulting depth components to fragments by attaching the current
        ///     raster position color or color index and texture coordinates to each pixel, then assigning x and y window
        ///     coordinates to
        ///     the nth fragment such that xn=xr+n%widthyn=yr+nwidth where xryr is the current raster position. These pixel
        ///     fragments
        ///     are then treated just like the fragments generated by rasterizing points, lines, or polygons. Texture mapping, fog,
        ///     and
        ///     all the fragment operations are applied before the fragments are written to the frame buffer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels: Depth values are read from the depth buffer. Each component is converted to floating point
        ///     such
        ///     that the minimum depth value maps to 0 and the maximum value maps to 1. Each component is then multiplied by
        ///     Gl.DEPTH_SCALE, added to Gl.DEPTH_BIAS, and finally clamped to the range 01.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a single depth value. The GL converts it to floating point, multiplies by
        ///     the
        ///     signed scale factor Gl.DEPTH_SCALE, adds the signed bias Gl.DEPTH_BIAS, and clamps to the range [0,1] (see
        ///     Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a single depth value. The GL converts it to floating point, multiplies by
        ///     the
        ///     signed scale factor Gl.DEPTH_SCALE, adds the signed bias Gl.DEPTH_BIAS, and clamps to the range [0,1] (see
        ///     Gl.PixelTransfer).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
        [RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
        public const int DEPTH_COMPONENT = 0x1902;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single red component. This component is converted to the internal
        ///     floating-point
        ///     format in the same way the red component of an RGBA pixel is. It is then converted to an RGBA pixel with green and
        ///     blue
        ///     set to 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a single red component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a single red component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is a single red component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RequiredByFeature("GL_AMD_interleaved_elements")]
        [RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
        [RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
        public const int RED = 0x1903;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single green component. This component is converted to the internal
        ///     floating-point format in the same way the green component of an RGBA pixel is. It is then converted to an RGBA
        ///     pixel
        ///     with red and blue set to 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read
        ///     as an
        ///     RGBA pixel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a single green component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a single green component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is a single green component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_AMD_interleaved_elements")]
        [RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
        public const int GREEN = 0x1904;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single blue component. This component is converted to the internal
        ///     floating-point
        ///     format in the same way the blue component of an RGBA pixel is. It is then converted to an RGBA pixel with red and
        ///     green
        ///     set to 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a single blue component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a single blue component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is a single blue component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the
        ///     signed
        ///     scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        [RequiredByFeature("GL_AMD_interleaved_elements")]
        [RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
        public const int BLUE = 0x1905;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single alpha component. This component is converted to the internal
        ///     floating-point format in the same way the alpha component of an RGBA pixel is. It is then converted to an RGBA
        ///     pixel
        ///     with red, green, and blue set to 0. After this conversion, the pixel is treated as if it had been read as an RGBA
        ///     pixel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a single alpha component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale
        ///     factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a single alpha component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale
        ///     factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is a single alpha component. The GL converts it to floating point and assembles
        ///     it
        ///     into an RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale
        ///     factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.TexImage2D: Each element is a single alpha component. The GL converts it to floating point and
        ///     assembles it
        ///     into an RGBA element by attaching 0 for red, green, and blue.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_AMD_interleaved_elements")]
        public const int ALPHA = 0x1906;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D:
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.TexImage2D: Each element is an RGB triple. The GL converts it to fixed-point or floating-point and
        ///     assembles it into an RGBA element by attaching 1 for alpha.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int RGB = 0x1907;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D:
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.TexImage2D: Each element contains all four components. The GL converts it to fixed-point or
        ///     floating-point.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int RGBA = 0x1908;

        /// <summary>
        /// [GL4] Gl.PolygonMode: Polygon vertices that are marked as the start of a boundary edge are drawn as points. Point
        /// attributes such as Gl.POINT_SIZE and Gl.POINT_SMOOTH control the rasterization of the points. Polygon rasterization
        /// attributes other than Gl.POLYGON_MODE have no effect.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
        public const int POINT = 0x1B00;

        /// <summary>
        /// [GL4] Gl.PolygonMode: Boundary edges of the polygon are drawn as line segments. Line attributes such as Gl.LINE_WIDTH
        /// and Gl.LINE_SMOOTH control the rasterization of the lines. Polygon rasterization attributes other than Gl.POLYGON_MODE
        /// have no effect.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
        public const int LINE = 0x1B01;

        /// <summary>
        /// [GL4] Gl.PolygonMode: The interior of the polygon is filled. Polygon attributes such as Gl.POLYGON_SMOOTH control the
        /// rasterization of the polygon.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
        public const int FILL = 0x1B02;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Keeps the current value.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Keeps the current value.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int KEEP = 0x1E00;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Sets the stencil buffer value to ref, as specified by Gl.StencilFunc.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Sets the stencil buffer value to ref, as specified by Gl.StencilFunc.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int REPLACE = 0x1E01;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Increments the current stencil buffer value. Clamps to the maximum representable
        ///     unsigned
        ///     value.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Increments the current stencil buffer value. Clamps to the maximum
        ///     representable
        ///     unsigned value.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int INCR = 0x1E02;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOp: Decrements the current stencil buffer value. Clamps to 0.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.StencilOpSeparate: Decrements the current stencil buffer value. Clamps to 0.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int DECR = 0x1E03;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetString: Returns the company responsible for this GL implementation. This name does not change from
        /// release to release.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int VENDOR = 0x1F00;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetString: Returns the name of the renderer. This name is typically specific to a particular
        /// configuration of a hardware platform. It does not change from release to release.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int RENDERER = 0x1F01;

        /// <summary>
        /// [GL4|GLES3.2] Gl.GetString: Returns a version or release number.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int VERSION = 0x1F02;

        /// <summary>
        ///     <para>
        ///     [GL4] Gl.GetString: For glGetStringi only, returns the extension string supported by the implementation at index.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.GetString: Returns the extension string supported by the implementation.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int EXTENSIONS = 0x1F03;

        /// <summary>
        /// [GL] Value of GL_NEAREST symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int NEAREST = 0x2600;

        /// <summary>
        /// [GL] Value of GL_LINEAR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LINEAR = 0x2601;

        /// <summary>
        /// [GL] Value of GL_NEAREST_MIPMAP_NEAREST symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int NEAREST_MIPMAP_NEAREST = 0x2700;

        /// <summary>
        /// [GL] Value of GL_LINEAR_MIPMAP_NEAREST symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LINEAR_MIPMAP_NEAREST = 0x2701;

        /// <summary>
        /// [GL] Value of GL_NEAREST_MIPMAP_LINEAR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int NEAREST_MIPMAP_LINEAR = 0x2702;

        /// <summary>
        /// [GL] Value of GL_LINEAR_MIPMAP_LINEAR symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int LINEAR_MIPMAP_LINEAR = 0x2703;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns the single-valued texture magnification filter, a symbolic constant.
        ///     The
        ///     initial value is Gl.LINEAR.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued texture magnification filter, a symbolic constant. The
        ///     initial value is Gl.LINEAR.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TEXTURE_MAG_FILTER = 0x2800;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns the single-valued texture minification filter, a symbolic constant.
        ///     The
        ///     initial value is Gl.NEAREST_MIPMAP_LINEAR.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued texture minification filter, a symbolic constant. The
        ///     initial value is Gl.NEAREST_MIPMAP_LINEAR.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TEXTURE_MIN_FILTER = 0x2801;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns the single-valued wrapping function for texture coordinate s, a
        ///     symbolic
        ///     constant. The initial value is Gl.REPEAT.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued wrapping function for texture coordinate s, a symbolic
        ///     constant. The initial value is Gl.REPEAT.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TEXTURE_WRAP_S = 0x2802;

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetSamplerParameter: Returns the single-valued wrapping function for texture coordinate t, a
        ///     symbolic
        ///     constant. The initial value is Gl.REPEAT.
        ///     </para>
        ///     <para>
        ///     [GL4|GLES3.2] Gl.GetTexParameter: Returns the single-valued wrapping function for texture coordinate t, a symbolic
        ///     constant. The initial value is Gl.REPEAT.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int TEXTURE_WRAP_T = 0x2803;

        /// <summary>
        /// [GL] Value of GL_REPEAT symbol.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public const int REPEAT = 0x2901;

        /// <summary>
        /// [GL] Value of GL_CURRENT_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint CURRENT_BIT = 0x00000001;

        /// <summary>
        /// [GL] Value of GL_POINT_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint POINT_BIT = 0x00000002;

        /// <summary>
        /// [GL] Value of GL_LINE_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint LINE_BIT = 0x00000004;

        /// <summary>
        /// [GL] Value of GL_POLYGON_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint POLYGON_BIT = 0x00000008;

        /// <summary>
        /// [GL] Value of GL_POLYGON_STIPPLE_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint POLYGON_STIPPLE_BIT = 0x00000010;

        /// <summary>
        /// [GL] Value of GL_PIXEL_MODE_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint PIXEL_MODE_BIT = 0x00000020;

        /// <summary>
        /// [GL] Value of GL_LIGHTING_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint LIGHTING_BIT = 0x00000040;

        /// <summary>
        /// [GL] Value of GL_FOG_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint FOG_BIT = 0x00000080;

        /// <summary>
        /// [GL2.1] Gl.Clear: Indicates the accumulation buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint ACCUM_BUFFER_BIT = 0x00000200;

        /// <summary>
        /// [GL] Value of GL_VIEWPORT_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint VIEWPORT_BIT = 0x00000800;

        /// <summary>
        /// [GL] Value of GL_TRANSFORM_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint TRANSFORM_BIT = 0x00001000;

        /// <summary>
        /// [GL] Value of GL_ENABLE_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint ENABLE_BIT = 0x00002000;

        /// <summary>
        /// [GL] Value of GL_HINT_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint HINT_BIT = 0x00008000;

        /// <summary>
        /// [GL] Value of GL_EVAL_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint EVAL_BIT = 0x00010000;

        /// <summary>
        /// [GL] Value of GL_LIST_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint LIST_BIT = 0x00020000;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint TEXTURE_BIT = 0x00040000;

        /// <summary>
        /// [GL] Value of GL_SCISSOR_BIT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint SCISSOR_BIT = 0x00080000;

        /// <summary>
        /// [GL] Value of GL_ALL_ATTRIB_BITS symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const uint ALL_ATTRIB_BITS = 0xFFFFFFFF;

        /// <summary>
        /// [GL2.1] Gl.Begin: Draws a connected group of quadrilaterals. One quadrilateral is defined for each pair of vertices
        /// presented after the first pair. Vertices 2⁢n-1, 2⁢n, 2⁢n+2, and 2⁢n+1 define quadrilateral n. N2-1 quadrilaterals are
        /// drawn. Note that the order in which vertices are used to construct a quadrilateral from strip data is different from
        /// that used with independent data.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int QUAD_STRIP = 0x0008;

        /// <summary>
        /// [GL2.1] Gl.Begin: Draws a single, convex polygon. Vertices 1 through N define this polygon.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POLYGON = 0x0009;

        /// <summary>
        /// [GL2.1] Gl.Accum: Obtains R, G, B, and A values from the buffer currently selected for reading (see Gl.ReadBuffer).
        /// Each
        /// component value is divided by 2n-1, where n is the number of bits allocated to each color component in the currently
        /// selected buffer. The result is a floating-point value in the range 01, which is multiplied by value and added to the
        /// corresponding pixel component in the accumulation buffer, thereby updating the accumulation buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ACCUM = 0x0100;

        /// <summary>
        /// [GL2.1] Gl.Accum: Similar to Gl.ACCUM, except that the current value in the accumulation buffer is not used in the
        /// calculation of the new value. That is, the R, G, B, and A values from the currently selected buffer are divided by
        /// 2n-1,
        /// multiplied by value, and then stored in the corresponding accumulation buffer cell, overwriting the current value.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LOAD = 0x0101;

        /// <summary>
        /// [GL2.1] Gl.Accum: Transfers accumulation buffer values to the color buffer or buffers currently selected for writing.
        /// Each R, G, B, and A component is multiplied by value, then multiplied by 2n-1, clamped to the range 02n-1, and stored
        /// in
        /// the corresponding display buffer cell. The only fragment operations that are applied to this transfer are pixel
        /// ownership, scissor, dithering, and color writemasks.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int RETURN = 0x0102;

        /// <summary>
        /// [GL2.1] Gl.Accum: Multiplies each R, G, B, and A in the accumulation buffer by value and returns the scaled component
        /// to
        /// its corresponding accumulation buffer location.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MULT = 0x0103;

        /// <summary>
        /// [GL2.1] Gl.Accum: Adds value to each R, G, B, and A in the accumulation buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ADD = 0x0104;

        /// <summary>
        /// [GL] Value of GL_AUX0 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AUX0 = 0x0409;

        /// <summary>
        /// [GL] Value of GL_AUX1 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AUX1 = 0x040A;

        /// <summary>
        /// [GL] Value of GL_AUX2 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AUX2 = 0x040B;

        /// <summary>
        /// [GL] Value of GL_AUX3 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AUX3 = 0x040C;

        /// <summary>
        /// [GL] Value of GL_2D symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _2D = 0x0600;

        /// <summary>
        /// [GL] Value of GL_3D symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _3D = 0x0601;

        /// <summary>
        /// [GL] Value of GL_3D_COLOR symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _3D_COLOR = 0x0602;

        /// <summary>
        /// [GL] Value of GL_3D_COLOR_TEXTURE symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _3D_COLOR_TEXTURE = 0x0603;

        /// <summary>
        /// [GL] Value of GL_4D_COLOR_TEXTURE symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _4D_COLOR_TEXTURE = 0x0604;

        /// <summary>
        /// [GL] Value of GL_PASS_THROUGH_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PASS_THROUGH_TOKEN = 0x0700;

        /// <summary>
        /// [GL] Value of GL_POINT_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POINT_TOKEN = 0x0701;

        /// <summary>
        /// [GL] Value of GL_LINE_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LINE_TOKEN = 0x0702;

        /// <summary>
        /// [GL] Value of GL_POLYGON_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POLYGON_TOKEN = 0x0703;

        /// <summary>
        /// [GL] Value of GL_BITMAP_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int BITMAP_TOKEN = 0x0704;

        /// <summary>
        /// [GL] Value of GL_DRAW_PIXEL_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DRAW_PIXEL_TOKEN = 0x0705;

        /// <summary>
        /// [GL] Value of GL_COPY_PIXEL_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COPY_PIXEL_TOKEN = 0x0706;

        /// <summary>
        /// [GL] Value of GL_LINE_RESET_TOKEN symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LINE_RESET_TOKEN = 0x0707;

        /// <summary>
        /// [GL] Value of GL_EXP symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int EXP = 0x0800;

        /// <summary>
        /// [GL] Value of GL_EXP2 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int EXP2 = 0x0801;

        /// <summary>
        /// [GL2.1] Gl.GetMap: v returns the control points for the evaluator function. One-dimensional evaluators return order
        /// control points, and two-dimensional evaluators return uorder×vorder control points. Each control point consists of one,
        /// two, three, or four integer, single-precision floating-point, or double-precision floating-point values, depending on
        /// the type of the evaluator. The GL returns two-dimensional control points in row-major order, incrementing the uorder
        /// index quickly and the vorder index after each row. Integer values, when requested, are computed by rounding the
        /// internal
        /// floating-point values to the nearest integer values.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COEFF = 0x0A00;

        /// <summary>
        /// [GL2.1] Gl.GetMap: v returns the order of the evaluator function. One-dimensional evaluators return a single value,
        /// order. The initial value is 1. Two-dimensional evaluators return two values, uorder and vorder. The initial value is
        /// 1,1.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ORDER = 0x0A01;

        /// <summary>
        /// [GL2.1] Gl.GetMap: v returns the linear u and v mapping parameters. One-dimensional evaluators return two values, u1
        /// and
        /// u2, as specified by Gl.Map1. Two-dimensional evaluators return four values (u1, u2, v1, and v2) as specified by
        /// Gl.Map2.
        /// Integer values, when requested, are computed by rounding the internal floating-point values to the nearest integer
        /// values.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DOMAIN = 0x0A02;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps color indices to color indices.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_I = 0x0C70;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps stencil indices to stencil indices.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_S_TO_S = 0x0C71;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps color indices to red components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_R = 0x0C72;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps color indices to green components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_G = 0x0C73;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps color indices to blue components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_B = 0x0C74;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps color indices to alpha components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_A = 0x0C75;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps red components to red components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_R_TO_R = 0x0C76;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps green components to green components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_G_TO_G = 0x0C77;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps blue components to blue components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_B_TO_B = 0x0C78;

        /// <summary>
        /// [GL2.1] Gl.PixelMap: Maps alpha components to alpha components.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_A_TO_A = 0x0C79;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.Get: params returns four values: the red, green, blue, and alpha values of the current color.
        /// Integer
        /// values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the
        /// most
        /// positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value
        /// is (1, 1, 1, 1). See Gl.Color.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_COLOR = 0x0B00;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the current color index. The initial value is 1. See Gl.Index.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_INDEX = 0x0B01;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.Get: params returns three values: the x, y, and z values of the current normal. Integer values, if
        /// requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive
        /// representable integer value, and -1.0 returns the most negative representable integer value. The initial value is (0,
        /// 0,
        /// 1). See Gl.Normal.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_NORMAL = 0x0B02;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.Get: params returns four values: the s, t, r, and q current texture coordinates. The initial value
        /// is
        /// (0, 0, 0, 1). See Gl.MultiTexCoord.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_TEXTURE_COORDS = 0x0B03;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns four values: the red, green, blue, and alpha color values of the current raster
        /// position.
        /// Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns
        /// the most positive representable integer value, and -1.0 returns the most negative representable integer value. The
        /// initial value is (1, 1, 1, 1). See Gl.RasterPos.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_RASTER_COLOR = 0x0B04;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the color index of the current raster position. The initial value is 1. See
        /// Gl.RasterPos.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_RASTER_INDEX = 0x0B05;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns four values: the s, t, r, and q texture coordinates of the current raster position. The
        /// initial value is (0, 0, 0, 1). See Gl.RasterPos and Gl.MultiTexCoord.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns four values: the x, y, z, and w components of the current raster position. x, y, and z
        /// are in window coordinates, and w is in clip coordinates. The initial value is (0, 0, 0, 1). See Gl.RasterPos.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_RASTER_POSITION = 0x0B07;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the current raster position is valid. The
        /// initial value is Gl.TRUE. See Gl.RasterPos.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_RASTER_POSITION_VALID = 0x0B08;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the distance from the eye to the current raster position. The initial value
        /// is
        /// 0. See Gl.RasterPos.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CURRENT_RASTER_DISTANCE = 0x0B09;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, draw points with proper filtering. Otherwise, draw aliased points. See Gl.PointSize.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether antialiasing of points is enabled. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.PointSize.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, draw points with proper filtering. Otherwise, draw aliased points. See
        ///     Gl.PointSize.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether point antialiasing is enabled. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.PointSize.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POINT_SMOOTH = 0x0B10;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, use the current line stipple pattern when drawing lines. See Gl.LineStipple.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether stippling of lines is enabled. The initial
        ///     value is Gl.FALSE. See Gl.LineStipple.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LINE_STIPPLE = 0x0B24;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the 16-bit line stipple pattern. The initial value is all 1's. See
        /// Gl.LineStipple.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LINE_STIPPLE_PATTERN = 0x0B25;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the line stipple repeat factor. The initial value is 1. See Gl.LineStipple.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LINE_STIPPLE_REPEAT = 0x0B26;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating the construction mode of the display list
        /// currently under construction. The initial value is 0. See Gl.NewList.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIST_MODE = 0x0B30;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the maximum recursion depth allowed during display-list traversal. The value
        /// must be at least 64. See Gl.CallList.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_LIST_NESTING = 0x0B31;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the base offset added to all names in arrays presented to Gl.CallLists. The
        /// initial value is 0. See Gl.ListBase.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIST_BASE = 0x0B32;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the name of the display list currently under construction. 0 is returned if
        /// no
        /// display list is currently under construction. The initial value is 0. See Gl.NewList.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIST_INDEX = 0x0B33;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, use the current polygon stipple pattern when rendering polygons. See
        ///     Gl.PolygonStipple.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether polygon stippling is enabled. The initial
        ///     value
        ///     is Gl.FALSE. See Gl.PolygonStipple.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POLYGON_STIPPLE = 0x0B42;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the current edge flag is Gl.TRUE or Gl.FALSE.
        /// The initial value is Gl.TRUE. See Gl.EdgeFlag.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int EDGE_FLAG = 0x0B43;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no vertex shader is active, use the current lighting parameters to compute the
        ///     vertex
        ///     color or index. Otherwise, simply associate the current color or index with each vertex. See Gl.Material,
        ///     Gl.LightModel,
        ///     and Gl.Light.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether lighting is enabled. The initial value is
        ///     Gl.FALSE. See Gl.LightModel.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, use the current lighting parameters to compute the vertex color. Otherwise, simply
        ///     associate the current color with each vertex. See Gl.Material, Gl.LightModel, and Gl.Light.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether lighting is enabled. The initial value
        ///     is
        ///     Gl.FALSE. See Gl.Light, Gl.LightModel, and Gl.Material.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHTING = 0x0B50;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether specular reflection calculations treat the
        ///     viewer as being local to the scene. The initial value is Gl.FALSE. See Gl.LightModel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.LightModel: params is a single integer or floating-point value that specifies how specular reflection
        ///     angles
        ///     are computed. If params is 0 (or 0.0), specular reflection angles take the view direction to be parallel to and in
        ///     the
        ///     direction of the -z axis, regardless of the location of the vertex in eye coordinates. Otherwise, specular
        ///     reflections
        ///     are computed from the origin of the eye coordinate system. The initial value is 0.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether separate materials are used to compute
        ///     lighting
        ///     for front- and back-facing polygons. The initial value is Gl.FALSE. See Gl.LightModel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.LightModel: params is a single integer or floating-point value that specifies whether one- or two-sided
        ///     lighting calculations are done for polygons. It has no effect on the lighting calculations for points, lines, or
        ///     bitmaps. If params is 0 (or 0.0), one-sided lighting is specified, and only the front material parameters are used
        ///     in
        ///     the lighting equation. Otherwise, two-sided lighting is specified. In this case, vertices of back-facing polygons
        ///     are
        ///     lighted using the back material parameters and have their normals reversed before the lighting equation is
        ///     evaluated.
        ///     Vertices of front-facing polygons are always lighted using the front material parameters, with no change to their
        ///     normals. The initial value is 0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether separate materials are used to compute
        ///     lighting for front and back facing polygons. See Gl.LightModel.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.LightModel: params is a single fixed-point or floating-point value that specifies whether one- or
        ///     two-sided
        ///     lighting calculations are done for polygons. It has no effect on the lighting calculations for points or lines. If
        ///     params is 0, one-sided lighting is specified, and both front- and back-facing polygons are assigned the same
        ///     computed
        ///     color. Otherwise, two-sided lighting is specified. In this case, vertices of back-facing polygons have their
        ///     normals
        ///     reversed before the lighting equation is evaluated. Vertices of front-facing polygons are always lighted with no
        ///     change
        ///     to their normals. The initial value is 0. Note that there is only one set of material properties shared by both
        ///     front-
        ///     and back-facing polygons.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT_MODEL_TWO_SIDE = 0x0B52;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns four values: the red, green, blue, and alpha components of the ambient intensity of
        ///     the
        ///     entire scene. Integer values, if requested, are linearly mapped from the internal floating-point representation
        ///     such
        ///     that 1.0 returns the most positive representable integer value, and -1.0 returns the most negative representable
        ///     integer
        ///     value. The initial value is (0.2, 0.2, 0.2, 1.0). See Gl.LightModel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.LightModel: params contains four integer or floating-point values that specify the ambient RGBA
        ///     intensity of
        ///     the entire scene. Integer values are mapped linearly such that the most positive representable value maps to 1.0,
        ///     and
        ///     the most negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point values are clamped. The initial ambient scene intensity is (0.2, 0.2, 0.2, 1.0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns four values: the red, green, blue, and alpha components of the ambient intensity
        ///     of the
        ///     entire scene. See Gl.LightModel.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.LightModel: params contains four fixed-point or floating-point values that specify the ambient
        ///     intensity of
        ///     the entire scene. The values are not clamped. The initial value is (0.2, 0.2, 0.2, 1.0).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT_MODEL_AMBIENT = 0x0B53;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating whether the shading mode is flat or
        ///     smooth. The
        ///     initial value is Gl.SMOOTH. See Gl.ShadeModel.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating whether the shading mode is flat or
        ///     smooth.
        ///     See Gl.ShadeModel.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SHADE_MODEL = 0x0B54;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating which materials have a parameter that is
        /// tracking the current color. The initial value is Gl.FRONT_AND_BACK. See Gl.ColorMaterial.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COLOR_MATERIAL_FACE = 0x0B55;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating which material parameters are tracking the
        /// current color. The initial value is Gl.AMBIENT_AND_DIFFUSE. See Gl.ColorMaterial.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COLOR_MATERIAL_PARAMETER = 0x0B56;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, have one or more material parameters track the current color. See Gl.ColorMaterial.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether one or more material parameters are
        ///     tracking
        ///     the current color. The initial value is Gl.FALSE. See Gl.ColorMaterial.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, have ambient and diffuse material parameters track the current color.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether color material tracking is enabled. The
        ///     initial value is Gl.FALSE. See Gl.Material.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COLOR_MATERIAL = 0x0B57;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no fragment shader is active, blend a fog color into the post-texturing color.
        ///     See
        ///     Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether fogging is enabled. The initial value is
        ///     Gl.FALSE. See Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, blend a fog color into the posttexturing color. See Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether fog is enabled. The initial value is
        ///     Gl.FALSE. See Gl.Fog.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_NV_register_combiners")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG = 0x0B60;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Fog: params is a single integer or floating-point value that specifies if, the fog color index. The
        ///     initial
        ///     fog index is 0.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the fog color index. The initial value is 0. See Gl.Fog.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG_INDEX = 0x0B61;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Fog: params is a single integer or floating-point value that specifies density, the fog density used in
        ///     both
        ///     exponential fog equations. Only nonnegative densities are accepted. The initial fog density is 1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the fog density parameter. The initial value is 1. See Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Fog: params is a single fixed-point or floating-point value that specifies density, the fog density
        ///     used in
        ///     both exponential fog equations. Only nonnegative densities are accepted. The initial fog density is 1.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the fog density parameter. See Gl.Fog.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG_DENSITY = 0x0B62;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Fog: params is a single integer or floating-point value that specifies start, the near distance used in
        ///     the
        ///     linear fog equation. The initial near distance is 0.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the start factor for the linear fog equation. The initial value is 0. See
        ///     Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Fog: params is a single fixed-point or floating-point value that specifies start, the near distance
        ///     used in
        ///     the linear fog equation. The initial near distance is 0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the start factor for the linear fog equation. See Gl.Fog.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG_START = 0x0B63;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Fog: params is a single integer or floating-point value that specifies end, the far distance used in the
        ///     linear fog equation. The initial far distance is 1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the end factor for the linear fog equation. The initial value is 1. See
        ///     Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Fog: params is a single fixed-point or floating-point value that specifies end, the far distance used
        ///     in
        ///     the linear fog equation. The initial far distance is 1.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the end factor for the linear fog equation. See Gl.Fog.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG_END = 0x0B64;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Fog: params is a single integer or floating-point value that specifies the equation to be used to
        ///     compute the
        ///     fog blend factor, f. Three symbolic constants are accepted: Gl.LINEAR, Gl.EXP, and Gl.EXP2. The equations
        ///     corresponding
        ///     to these symbolic constants are defined below. The initial fog mode is Gl.EXP.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating which fog equation is selected. The
        ///     initial
        ///     value is Gl.EXP. See Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Fog: params is a single fixed-point or floating-point value that specifies the equation to be used to
        ///     compute the fog blend factor f. Three symbolic constants are accepted: Gl.LINEAR, Gl.EXP, and Gl.EXP2. The
        ///     equations
        ///     corresponding to these symbolic constants are defined below. The initial fog mode is Gl.EXP.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating which fog equation is selected. See
        ///     Gl.Fog.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG_MODE = 0x0B65;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Fog: params contains four integer or floating-point values that specify Cf, the fog color. Integer
        ///     values are
        ///     mapped linearly such that the most positive representable value maps to 1.0, and the most negative representable
        ///     value
        ///     maps to -1.0. Floating-point values are mapped directly. After conversion, all color components are clamped to the
        ///     range
        ///     01. The initial fog color is (0, 0, 0, 0).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns four values: the red, green, blue, and alpha components of the fog color. Integer
        ///     values,
        ///     if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most
        ///     positive representable integer value, and -1.0 returns the most negative representable integer value. The initial
        ///     value
        ///     is (0, 0, 0, 0). See Gl.Fog.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Fog: params contains four fixed-point or floating-point values that specify Cf, the fog color. Both
        ///     fixed-point and floating-point values are mapped directly. After conversion, all color components are clamped to
        ///     the
        ///     range [0, 1]. The initial fog color is (0, 0, 0, 0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns four values: the red, green, blue, and alpha components of the fog color. See
        ///     Gl.Fog.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG_COLOR = 0x0B66;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns four values: the red, green, blue, and alpha values used to clear the accumulation
        /// buffer. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0
        /// returns the most positive representable integer value, and -1.0 returns the most negative representable integer value.
        /// The initial value is (0, 0, 0, 0). See Gl.ClearAccum.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ACCUM_CLEAR_VALUE = 0x0B80;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating which matrix stack is currently the target
        ///     of
        ///     all matrix operations. The initial value is Gl.MODELVIEW. See Gl.MatrixMode.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating which matrix stack is currently the
        ///     target of
        ///     all matrix operations. See Gl.MatrixMode.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MATRIX_MODE = 0x0BA0;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no vertex shader is active, normal vectors are normalized to unit length after
        ///     transformation and before lighting. This method is generally less efficient than Gl.RESCALE_NORMAL. See Gl.Normal
        ///     and
        ///     Gl.NormalPointer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether normals are automatically scaled to unit
        ///     length
        ///     after they have been transformed to eye coordinates. The initial value is Gl.FALSE. See Gl.Normal.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Enable: If enabled, normal vectors are normalized to unit length after transformation and before
        ///     lighting.
        ///     This method is generally less efficient than Gl.RESCALE_NORMAL. See Gl.Normal and Gl.NormalPointer.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns a single boolean value indicating whether normalization of normals is enabled. The
        ///     initial value is Gl.FALSE. See Gl.Normal.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int NORMALIZE = 0x0BA1;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of matrices on the modelview matrix stack. The initial value
        ///     is 1.
        ///     See Gl.PushMatrix.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the number of matrices on the modelview matrix stack. See
        ///     Gl.PushMatrix.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MODELVIEW_STACK_DEPTH = 0x0BA3;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of matrices on the projection matrix stack. The initial value
        ///     is 1.
        ///     See Gl.PushMatrix.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the number of matrices on the projection matrix stack. See
        ///     Gl.PushMatrix.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PROJECTION_STACK_DEPTH = 0x0BA4;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of matrices on the texture matrix stack. The initial value is
        ///     1.
        ///     See Gl.PushMatrix.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the number of matrices on the texture matrix stack. See Gl.BindTexture.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_STACK_DEPTH = 0x0BA5;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns sixteen values: the modelview matrix on the top of the modelview matrix stack.
        ///     Initially
        ///     this matrix is the identity matrix. See Gl.PushMatrix.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns sixteen values: the modelview matrix on the top of the modelview matrix stack. See
        ///     Gl.PushMatrix.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MODELVIEW_MATRIX = 0x0BA6;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns sixteen values: the projection matrix on the top of the projection matrix stack.
        ///     Initially this matrix is the identity matrix. See Gl.PushMatrix.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns sixteen values: the projection matrix on the top of the projection matrix stack.
        ///     See
        ///     Gl.PushMatrix.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PROJECTION_MATRIX = 0x0BA7;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns sixteen values: the texture matrix on the top of the texture matrix stack. Initially
        ///     this
        ///     matrix is the identity matrix. See Gl.PushMatrix.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns sixteen values: the texture matrix on the top of the texture matrix stack. See
        ///     Gl.PushMatrix.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_MATRIX = 0x0BA8;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the depth of the attribute stack. If the stack is empty, 0 is returned. The
        /// initial value is 0. See Gl.PushAttrib.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ATTRIB_STACK_DEPTH = 0x0BB0;

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] Gl.Enable: If enabled, do alpha testing. See Gl.AlphaFunc.
        ///     </para>
        ///     <para>
        ///     [GL2.1|GLES1.1] Gl.Get: params returns a single boolean value indicating whether alpha testing of fragments is
        ///     enabled.
        ///     The initial value is Gl.FALSE. See Gl.AlphaFunc.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ALPHA_TEST = 0x0BC0;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: the symbolic name of the alpha test function. The initial value is Gl.ALWAYS. See Gl.AlphaFunc.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the symbolic name of the alpha test function. See Gl.AlphaFunc.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ALPHA_TEST_FUNC = 0x0BC1;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the reference value for the alpha test. The initial value is 0. See
        ///     Gl.AlphaFunc. An integer value, if requested, is linearly mapped from the internal floating-point representation
        ///     such
        ///     that 1.0 returns the most positive representable integer value, and -1.0 returns the most negative representable
        ///     integer
        ///     value.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the reference value for the alpha test. An integer value, if requested,
        ///     is
        ///     linearly mapped from the internal floating-point representation such that Gl. returns the most positive
        ///     representable
        ///     integer value, and Gl.0 returns the most negative representable integer value. See Gl.AlphaFunc.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ALPHA_TEST_REF = 0x0BC2;

        /// <summary>
        /// [GL] Value of GL_LOGIC_OP symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LOGIC_OP = 0x0BF1;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of auxiliary color buffers available.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AUX_BUFFERS = 0x0C00;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the color index used to clear the color index buffers. The initial value is
        /// 0.
        /// See Gl.ClearIndex.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int INDEX_CLEAR_VALUE = 0x0C20;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, a mask indicating which bitplanes of each color index buffer can be written.
        /// The initial value is all 1's. See Gl.IndexMask.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int INDEX_WRITEMASK = 0x0C21;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the GL is in color index mode (Gl.TRUE) or
        /// RGBA
        /// mode (Gl.FALSE).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int INDEX_MODE = 0x0C30;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single boolean value indicating whether the GL is in RGBA mode (true) or color index
        /// mode (false). See Gl.Color.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int RGBA_MODE = 0x0C31;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating whether the GL is in render, select, or
        /// feedback mode. The initial value is Gl.RENDER. See Gl.RenderMode.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int RENDER_MODE = 0x0C40;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the perspective correction
        ///     hint.
        ///     The initial value is Gl.DONT_CARE. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Hint: Indicates the quality of color, texture coordinate, and fog coordinate interpolation. If
        ///     perspective-corrected parameter interpolation is not efficiently supported by the GL implementation, hinting
        ///     Gl.DONT_CARE or Gl.FASTEST can result in simple linear interpolation of colors and/or texture coordinates.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the perspective correction
        ///     hint.
        ///     See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Hint: Indicates the quality of color and texture coordinate interpolation. If perspective-corrected
        ///     parameter interpolation is not efficiently supported by the GL implementation, hinting Gl.DONT_CARE or Gl.FASTEST
        ///     can
        ///     result in simple linear interpolation of colors and/or texture coordinates.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PERSPECTIVE_CORRECTION_HINT = 0x0C50;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the point antialiasing hint.
        ///     The
        ///     initial value is Gl.DONT_CARE. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Hint: Indicates the sampling quality of antialiased points. If a larger filter function is applied,
        ///     hinting
        ///     Gl.NICEST can result in more pixel fragments being generated during rasterization.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the point antialiasing hint.
        ///     See
        ///     Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Hint: Indicates the sampling quality of antialiased points. If a larger filter function is applied,
        ///     hinting
        ///     Gl.NICEST can result in more pixel fragments being generated during rasterization.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POINT_SMOOTH_HINT = 0x0C51;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the fog hint. The initial
        ///     value is
        ///     Gl.DONT_CARE. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Hint: Indicates the accuracy of fog calculation. If per-pixel fog calculation is not efficiently
        ///     supported by
        ///     the GL implementation, hinting Gl.DONT_CARE or Gl.FASTEST can result in per-vertex calculation of fog effects.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, a symbolic constant indicating the mode of the fog hint. See Gl.Hint.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Hint: Indicates the accuracy of fog calculation. If per-pixel fog calculation is not efficiently
        ///     supported
        ///     by the GL implementation, hinting Gl.DONT_CARE or Gl.FASTEST can result in per-vertex calculation of fog effects.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FOG_HINT = 0x0C54;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no vertex shader is active, the s texture coordinate is computed using the
        ///     texture
        ///     generation function defined with Gl.TexGen. Otherwise, the current s texture coordinate is used. See Gl.TexGen.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether automatic generation of the S texture
        ///     coordinate is enabled. The initial value is Gl.FALSE. See Gl.TexGen.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_GEN_S = 0x0C60;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no vertex shader is active, the t texture coordinate is computed using the
        ///     texture
        ///     generation function defined with Gl.TexGen. Otherwise, the current t texture coordinate is used. See Gl.TexGen.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether automatic generation of the T texture
        ///     coordinate is enabled. The initial value is Gl.FALSE. See Gl.TexGen.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_GEN_T = 0x0C61;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no vertex shader is active, the r texture coordinate is computed using the
        ///     texture
        ///     generation function defined with Gl.TexGen. Otherwise, the current r texture coordinate is used. See Gl.TexGen.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether automatic generation of the r texture
        ///     coordinate is enabled. The initial value is Gl.FALSE. See Gl.TexGen.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_GEN_R = 0x0C62;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled and no vertex shader is active, the q texture coordinate is computed using the
        ///     texture
        ///     generation function defined with Gl.TexGen. Otherwise, the current q texture coordinate is used. See Gl.TexGen.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether automatic generation of the q texture
        ///     coordinate is enabled. The initial value is Gl.FALSE. See Gl.TexGen.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_GEN_Q = 0x0C63;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the index-to-index pixel translation table. The initial value is
        /// 1. See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the stencil-to-stencil pixel translation table. The initial value
        /// is 1. See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the index-to-red pixel translation table. The initial value is 1.
        /// See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the index-to-green pixel translation table. The initial value is
        /// 1. See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the index-to-blue pixel translation table. The initial value is
        /// 1.
        /// See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the index-to-alpha pixel translation table. The initial value is
        /// 1. See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the red-to-red pixel translation table. The initial value is 1.
        /// See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the green-to-green pixel translation table. The initial value is
        /// 1. See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the blue-to-blue pixel translation table. The initial value is 1.
        /// See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the size of the alpha-to-alpha pixel translation table. The initial value is
        /// 1. See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single boolean value indicating if colors and color indices are to be replaced by
        /// table
        /// lookup during pixel transfers. The initial value is Gl.FALSE. See Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP_COLOR = 0x0D10;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns a single boolean value indicating if stencil indices are to be replaced by table lookup
        /// during pixel transfers. The initial value is Gl.FALSE. See Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP_STENCIL = 0x0D11;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the amount that color and stencil indices are shifted during pixel transfers.
        /// The initial value is 0. See Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int INDEX_SHIFT = 0x0D12;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the offset added to color and stencil indices during pixel transfers. The
        /// initial value is 0. See Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int INDEX_OFFSET = 0x0D13;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the red scale factor used during pixel transfers. The initial value is 1. See
        /// Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int RED_SCALE = 0x0D14;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the red bias factor used during pixel transfers. The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int RED_BIAS = 0x0D15;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the x pixel zoom factor. The initial value is 1. See Gl.PixelZoom.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ZOOM_X = 0x0D16;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the y pixel zoom factor. The initial value is 1. See Gl.PixelZoom.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ZOOM_Y = 0x0D17;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the green scale factor used during pixel transfers. The initial value is 1.
        /// See Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int GREEN_SCALE = 0x0D18;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the green bias factor used during pixel transfers. The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int GREEN_BIAS = 0x0D19;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the blue scale factor used during pixel transfers. The initial value is 1.
        /// See
        /// Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int BLUE_SCALE = 0x0D1A;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the blue bias factor used during pixel transfers. The initial value is 0. See
        /// Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int BLUE_BIAS = 0x0D1B;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the alpha scale factor used during pixel transfers. The initial value is
        ///     1.
        ///     See Gl.PixelTransfer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.GetTexEnv: params returns a single floating-point value representing the current alpha texture combiner
        ///     scaling factor. The initial value is 1.0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetTexEnv: params returns a single floating-point value representing the current alpha texture
        ///     combiner
        ///     scaling factor. The initial value is 1.0.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ALPHA_SCALE = 0x0D1C;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the alpha bias factor used during pixel transfers. The initial value is 0.
        /// See
        /// Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ALPHA_BIAS = 0x0D1D;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the depth scale factor used during pixel transfers. The initial value is 1.
        /// See Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DEPTH_SCALE = 0x0D1E;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the depth bias factor used during pixel transfers. The initial value is 0.
        /// See
        /// Gl.PixelTransfer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DEPTH_BIAS = 0x0D1F;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the maximum equation order supported by 1D and 2D evaluators. The value must
        /// be at least 8. See Gl.Map1 and Gl.Map2.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_EVAL_ORDER = 0x0D30;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.Get: params returns one value, the maximum number of lights. The value must be at least 8. See
        /// Gl.Light.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_LIGHTS = 0x0D31;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the maximum number of application-defined clipping planes. The value must
        ///     be
        ///     at least 6. See Gl.ClipPlane.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the maximum number of application defined clipping planes. The value
        ///     must be
        ///     at least Gl.. See Gl.ClipPlane.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_CLIP_PLANES = 0x0D32;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the maximum supported size of a Gl.PixelMap lookup table. The value must be
        /// at
        /// least 32. See Gl.PixelMap.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_PIXEL_MAP_TABLE = 0x0D34;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the maximum supported depth of the attribute stack. The value must be at
        /// least
        /// 16. See Gl.PushAttrib.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_ATTRIB_STACK_DEPTH = 0x0D35;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the maximum supported depth of the modelview matrix stack. The value must
        ///     be
        ///     at least 32. See Gl.PushMatrix.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Get: params returns one value, the maximum supported depth of the modelview matrix stack. The value
        ///     must be
        ///     at least Gl.. See Gl.PushMatrix.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_MODELVIEW_STACK_DEPTH = 0x0D36;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the maximum supported depth of the selection name stack. The value must be at
        /// least 64. See Gl.PushName.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_NAME_STACK_DEPTH = 0x0D37;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.Get: params returns one value, the maximum supported depth of the projection matrix stack. The value
        /// must be at least 2. See Gl.PushMatrix.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_PROJECTION_STACK_DEPTH = 0x0D38;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.Get: params returns one value, the maximum supported depth of the texture matrix stack. The value
        /// must be at least 2. See Gl.PushMatrix.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAX_TEXTURE_STACK_DEPTH = 0x0D39;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of bitplanes in each color index buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int INDEX_BITS = 0x0D51;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of red bitplanes in each color buffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of red bitplanes in the color buffer of the currently bound
        ///     draw
        ///     framebuffer. This is deﬁned only if all color attachments of the draw framebuffer have identical formats, in which
        ///     case
        ///     the number of red bits of color attachment zero are returned.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int RED_BITS = 0x0D52;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of green bitplanes in each color buffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of green bitplanes in the color buffer of the currently bound
        ///     draw
        ///     framebuffer. This is deﬁned only if all color attachments of the draw framebuffer have identical formats, in which
        ///     case
        ///     the number of green bits of color attachment zero are returned.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int GREEN_BITS = 0x0D53;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of blue bitplanes in each color buffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of blue bitplanes in the color buffer of the currently bound
        ///     draw
        ///     framebuffer. This is deﬁned only if all color attachments of the draw framebuffer have identical formats, in which
        ///     case
        ///     the number of blue bits of color attachment zero are returned.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int BLUE_BITS = 0x0D54;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of alpha bitplanes in each color buffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of alpha bitplanes in the color buffer of the currently bound
        ///     draw
        ///     framebuffer. This is deﬁned only if all color attachments of the draw framebuffer have identical formats, in which
        ///     case
        ///     the number of alpha bits of color attachment zero are returned.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int ALPHA_BITS = 0x0D55;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of bitplanes in the depth buffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of bitplanes in the depth buffer of the currently bound
        ///     framebuffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int DEPTH_BITS = 0x0D56;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns one value, the number of bitplanes in the stencil buffer.
        ///     </para>
        ///     <para>
        ///     [GLES3.2] Gl.Get: data returns one value, the number of bitplanes in the stencil buffer of the currently bound
        ///     framebuffer.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int STENCIL_BITS = 0x0D57;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of red bitplanes in the accumulation buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ACCUM_RED_BITS = 0x0D58;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of green bitplanes in the accumulation buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ACCUM_GREEN_BITS = 0x0D59;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of blue bitplanes in the accumulation buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ACCUM_BLUE_BITS = 0x0D5A;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of alpha bitplanes in the accumulation buffer.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int ACCUM_ALPHA_BITS = 0x0D5B;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of names on the selection name stack. The initial value is 0. See
        /// Gl.PushName.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int NAME_STACK_DEPTH = 0x0D70;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, generate normal vectors when either Gl.MAP2_VERTEX_3 or Gl.MAP2_VERTEX_4 is used to
        ///     generate vertices. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D map evaluation automatically generates
        ///     surface normals. The initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AUTO_NORMAL = 0x0D80;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate RGBA values. See
        ///     Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates colors. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is four floating-point values representing red, green, blue, and alpha.
        ///     Internal
        ///     Gl.Color4 commands are generated when the map is evaluated but the current color is not updated with the value of
        ///     these
        ///     Gl.Color4 commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_COLOR_4 = 0x0D90;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate color indices. See
        ///     Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates color indices. The
        ///     initial value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is a single floating-point value representing a color index. Internal Gl.Index
        ///     commands are generated when the map is evaluated but the current index is not updated with the value of these
        ///     Gl.Index
        ///     commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_INDEX = 0x0D91;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate normals. See
        ///     Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates normals. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is three floating-point values representing the x, y, and z components of a
        ///     normal
        ///     vector. Internal Gl.Normal commands are generated when the map is evaluated but the current normal is not updated
        ///     with
        ///     the value of these Gl.Normal commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_NORMAL = 0x0D92;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s texture
        ///     coordinates.
        ///     See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 1D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is a single floating-point value representing the s texture coordinate.
        ///     Internal
        ///     Gl.TexCoord1 commands are generated when the map is evaluated but the current texture coordinates are not updated
        ///     with
        ///     the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_TEXTURE_COORD_1 = 0x0D93;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s and t texture
        ///     coordinates. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 2D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is two floating-point values representing the s and t texture coordinates.
        ///     Internal
        ///     Gl.TexCoord2 commands are generated when the map is evaluated but the current texture coordinates are not updated
        ///     with
        ///     the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_TEXTURE_COORD_2 = 0x0D94;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s, t, and r texture
        ///     coordinates. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 3D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is three floating-point values representing the s, t, and r texture
        ///     coordinates.
        ///     Internal Gl.TexCoord3 commands are generated when the map is evaluated but the current texture coordinates are not
        ///     updated with the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_TEXTURE_COORD_3 = 0x0D95;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s, t, r, and q
        ///     texture
        ///     coordinates. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 4D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is four floating-point values representing the s, t, r, and q texture
        ///     coordinates.
        ///     Internal Gl.TexCoord4 commands are generated when the map is evaluated but the current texture coordinates are not
        ///     updated with the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_TEXTURE_COORD_4 = 0x0D96;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate x, y, and z vertex
        ///     coordinates. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 3D vertex
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is three floating-point values representing x, y, and z. Internal Gl.Vertex3
        ///     commands are generated when the map is evaluated.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_VERTEX_3 = 0x0D97;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate homogeneous x, y,
        ///     z, and
        ///     w vertex coordinates. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 4D vertex
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map1: Each control point is four floating-point values representing x, y, z, and w. Internal Gl.Vertex4
        ///     commands are generated when the map is evaluated.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_VERTEX_4 = 0x0D98;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate RGBA values. See
        ///     Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates colors. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is four floating-point values representing red, green, blue, and alpha.
        ///     Internal
        ///     Gl.Color4 commands are generated when the map is evaluated but the current color is not updated with the value of
        ///     these
        ///     Gl.Color4 commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_COLOR_4 = 0x0DB0;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate color indices. See
        ///     Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates color indices. The
        ///     initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is a single floating-point value representing a color index. Internal Gl.Index
        ///     commands are generated when the map is evaluated but the current index is not updated with the value of these
        ///     Gl.Index
        ///     commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_INDEX = 0x0DB1;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate normals. See
        ///     Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates normals. The
        ///     initial
        ///     value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is three floating-point values representing the x, y, and z components of a
        ///     normal
        ///     vector. Internal Gl.Normal commands are generated when the map is evaluated but the current normal is not updated
        ///     with
        ///     the value of these Gl.Normal commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_NORMAL = 0x0DB2;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s texture
        ///     coordinates.
        ///     See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 1D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is a single floating-point value representing the s texture coordinate.
        ///     Internal
        ///     Gl.TexCoord1 commands are generated when the map is evaluated but the current texture coordinates are not updated
        ///     with
        ///     the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_TEXTURE_COORD_1 = 0x0DB3;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s and t texture
        ///     coordinates. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 2D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is two floating-point values representing the s and t texture coordinates.
        ///     Internal
        ///     Gl.TexCoord2 commands are generated when the map is evaluated but the current texture coordinates are not updated
        ///     with
        ///     the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_TEXTURE_COORD_2 = 0x0DB4;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s, t, and r texture
        ///     coordinates. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 3D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is three floating-point values representing the s, t, and r texture
        ///     coordinates.
        ///     Internal Gl.TexCoord3 commands are generated when the map is evaluated but the current texture coordinates are not
        ///     updated with the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_TEXTURE_COORD_3 = 0x0DB5;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s, t, r, and q
        ///     texture
        ///     coordinates. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 4D texture
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is four floating-point values representing the s, t, r, and q texture
        ///     coordinates.
        ///     Internal Gl.TexCoord4 commands are generated when the map is evaluated but the current texture coordinates are not
        ///     updated with the value of these Gl.TexCoord commands.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_TEXTURE_COORD_4 = 0x0DB6;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate x, y, and z vertex
        ///     coordinates. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 3D vertex
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is three floating-point values representing x, y, and z. Internal Gl.Vertex3
        ///     commands are generated when the map is evaluated.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_VERTEX_3 = 0x0DB7;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate homogeneous x, y,
        ///     z, and
        ///     w vertex coordinates. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 4D vertex
        ///     coordinates.
        ///     The initial value is Gl.FALSE. See Gl.Map2.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Map2: Each control point is four floating-point values representing x, y, z, and w. Internal Gl.Vertex4
        ///     commands are generated when the map is evaluated.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_VERTEX_4 = 0x0DB8;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns two values: the endpoints of the 1D map's grid domain. The initial value is (0, 1). See
        /// Gl.MapGrid.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_GRID_DOMAIN = 0x0DD0;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns one value, the number of partitions in the 1D map's grid domain. The initial value is 1.
        /// See Gl.MapGrid.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP1_GRID_SEGMENTS = 0x0DD1;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns four values: the endpoints of the 2D map's i and j grid domains. The initial value is
        /// (0,1; 0,1). See Gl.MapGrid.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_GRID_DOMAIN = 0x0DD2;

        /// <summary>
        /// [GL2.1] Gl.Get: params returns two values: the number of partitions in the 2D map's i and j grid domains. The initial
        /// value is (1,1). See Gl.MapGrid.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MAP2_GRID_SEGMENTS = 0x0DD3;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_COMPONENTS symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_COMPONENTS = 0x1003;

        /// <summary>
        /// [GL2.1] Gl.GetTexLevelParameter: params returns a single value, the width in pixels of the border of the texture image.
        /// The initial value is 0.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_BORDER = 0x1005;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns four integer or floating-point values representing the ambient intensity of the
        ///     light source. Integer values, when requested, are linearly mapped from the internal floating-point representation
        ///     such
        ///     that 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable
        ///     integer
        ///     value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The
        ///     initial
        ///     value is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.GetMaterial: params returns four integer or floating-point values representing the ambient reflectance
        ///     of the
        ///     material. Integer values, when requested, are linearly mapped from the internal floating-point representation such
        ///     that
        ///     1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer
        ///     value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The
        ///     initial
        ///     value is (0.2, 0.2, 0.2, 1.0)
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params contains four integer or floating-point values that specify the ambient RGBA intensity of
        ///     the
        ///     light. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most
        ///     negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point
        ///     values are clamped. The initial ambient light intensity is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Material: params contains four integer or floating-point values that specify the ambient RGBA
        ///     reflectance of
        ///     the material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and
        ///     the
        ///     most negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point values are clamped. The initial ambient reflectance for both front- and back-facing materials is
        ///     (0.2,
        ///     0.2, 0.2, 1.0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns four fixed-point or floating-point values that specify the ambient RGBA
        ///     intensity
        ///     of the light. Both fixed-point and floating-point values are mapped directly. Neither fixed-point nor
        ///     floating-point
        ///     values are clamped. The initial ambient light intensity is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetMaterial: params returns four fixed-point or floating-point values that specify the ambient RGBA
        ///     reflectance of the material. The values are not clamped. The initial ambient reflectance is (0.2, 0.2, 0.2, 1.0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params contains four fixed-point or floating-point values that specify the ambient RGBA
        ///     intensity of
        ///     the light. Both fixed-point and floating-point values are mapped directly. Neither fixed-point nor floating-point
        ///     values
        ///     are clamped. The initial ambient light intensity is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Material: params contains four fixed-point or floating-point values that specify the ambient RGBA
        ///     reflectance of the material. The values are not clamped. The initial ambient reflectance is (0.2, 0.2, 0.2, 1.0).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AMBIENT = 0x1200;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns four integer or floating-point values representing the diffuse intensity of the
        ///     light source. Integer values, when requested, are linearly mapped from the internal floating-point representation
        ///     such
        ///     that 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable
        ///     integer
        ///     value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The
        ///     initial
        ///     value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 0).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.GetMaterial: params returns four integer or floating-point values representing the diffuse reflectance
        ///     of the
        ///     material. Integer values, when requested, are linearly mapped from the internal floating-point representation such
        ///     that
        ///     1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer
        ///     value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The
        ///     initial
        ///     value is (0.8, 0.8, 0.8, 1.0).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params contains four integer or floating-point values that specify the diffuse RGBA intensity of
        ///     the
        ///     light. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most
        ///     negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point
        ///     values are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0,
        ///     0,
        ///     1).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Material: params contains four integer or floating-point values that specify the diffuse RGBA
        ///     reflectance of
        ///     the material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and
        ///     the
        ///     most negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point values are clamped. The initial diffuse reflectance for both front- and back-facing materials is
        ///     (0.8,
        ///     0.8, 0.8, 1.0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns four fixed-point or floating-point values that specify the diffuse RGBA
        ///     intensity
        ///     of the light. Both fixed-point and floating-point values are mapped directly. Neither fixed-point nor
        ///     floating-point
        ///     values are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1). For other lights, the initial value is (0, 0,
        ///     0,
        ///     0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetMaterial: params returns four fixed-point or floating-point values that specify the diffuse RGBA
        ///     reflectance of the material. The values are not clamped. The initial diffuse reflectance is (0.8, 0.8, 0.8, 1.0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params contains four fixed-point or floating-point values that specify the diffuse RGBA
        ///     intensity of
        ///     the light. Both fixed-point and floating-point values are mapped directly. Neither fixed-point nor floating-point
        ///     values
        ///     are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1). For other lights, the initial value is (0, 0, 0, 0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Material: params contains four fixed-point or floating-point values that specify the diffuse RGBA
        ///     reflectance of the material. The values are not clamped. The initial diffuse reflectance is (0.8, 0.8, 0.8, 1.0).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DIFFUSE = 0x1201;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns four integer or floating-point values representing the specular intensity of
        ///     the
        ///     light source. Integer values, when requested, are linearly mapped from the internal floating-point representation
        ///     such
        ///     that 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable
        ///     integer
        ///     value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The
        ///     initial
        ///     value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 0).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.GetMaterial: params returns four integer or floating-point values representing the specular reflectance
        ///     of
        ///     the material. Integer values, when requested, are linearly mapped from the internal floating-point representation
        ///     such
        ///     that 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable
        ///     integer
        ///     value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The
        ///     initial
        ///     value is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params contains four integer or floating-point values that specify the specular RGBA intensity of
        ///     the
        ///     light. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most
        ///     negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point
        ///     values are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0,
        ///     0,
        ///     1).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Material: params contains four integer or floating-point values that specify the specular RGBA
        ///     reflectance of
        ///     the material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and
        ///     the
        ///     most negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point values are clamped. The initial specular reflectance for both front- and back-facing materials is
        ///     (0, 0,
        ///     0, 1).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns four fixed-point or floating-point values that specify the specular RGBA
        ///     intensity
        ///     of the light. Both fixed-point and floating-point values are mapped directly. Neither fixed-point nor
        ///     floating-point
        ///     values are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1). For other lights, the initial value is (0, 0,
        ///     0,
        ///     0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetMaterial: params returns four fixed-point or floating-point values that specify the specular RGBA
        ///     reflectance of the material. The values are not clamped. The initial specular reflectance is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params contains four fixed-point or floating-point values that specify the specular RGBA
        ///     intensity
        ///     of the light. Both fixed-point and floating-point values are mapped directly. Neither fixed-point nor
        ///     floating-point
        ///     values are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1). For other lights, the initial value is (0, 0,
        ///     0,
        ///     0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Material: params contains four fixed-point or floating-point values that specify the specular RGBA
        ///     reflectance of the material. The values are not clamped. The initial specular reflectance is (0, 0, 0, 1).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SPECULAR = 0x1202;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns four integer or floating-point values representing the position of the light
        ///     source.
        ///     Integer values, when requested, are computed by rounding the internal floating-point values to the nearest integer
        ///     value. The returned values are those maintained in eye coordinates. They will not be equal to the values specified
        ///     using
        ///     Gl.Light, unless the modelview matrix was identity at the time Gl.Light was called. The initial value is (0, 0, 1,
        ///     0).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params contains four integer or floating-point values that specify the position of the light in
        ///     homogeneous object coordinates. Both integer and floating-point values are mapped directly. Neither integer nor
        ///     floating-point values are clamped. The position is transformed by the modelview matrix when glLight is called (just
        ///     as
        ///     if it were a point), and it is stored in eye coordinates. If the w component of the position is 0, the light is
        ///     treated
        ///     as a directional source. Diffuse and specular lighting calculations take the light's direction, but not its actual
        ///     position, into account, and attenuation is disabled. Otherwise, diffuse and specular lighting calculations are
        ///     based on
        ///     the actual location of the light in eye coordinates, and attenuation is enabled. The initial position is (0, 0, 1,
        ///     0);
        ///     thus, the initial light source is directional, parallel to, and in the direction of the -z axis.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns four fixed-point or floating-point values representing the position of the
        ///     light
        ///     source. Both fixed-point and floating-point values are mapped directly. The returned values are those maintained in
        ///     eye
        ///     coordinates. They will not be equal to the values specified using Gl.Light, unless the modelview matrix was
        ///     identity at
        ///     the time Gl.Light was called. The initial value is (0, 0, 1, 0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params contains four fixed-point or floating-point values that specify the position of the
        ///     light in
        ///     homogeneous object coordinates. Both fixed-point and floating-point values are mapped directly. Neither fixed-point
        ///     nor
        ///     floating-point values are clamped. The position is transformed by the modelview matrix when glLight is called (just
        ///     as
        ///     if it were a point), and it is stored in eye coordinates. If the w component of the position is 0, the light is
        ///     treated
        ///     as a directional source. Diffuse and specular lighting calculations take the light's direction, but not its actual
        ///     position, into account, and attenuation is disabled. Otherwise, diffuse and specular lighting calculations are
        ///     based on
        ///     the actual location of the light in eye coordinates, and attenuation is enabled. The initial position is (0, 0, 1,
        ///     0);
        ///     thus, the initial light source is directional, parallel to, and in the direction of the -z axis.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int POSITION = 0x1203;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns three integer or floating-point values representing the direction of the light
        ///     source. Integer values, when requested, are computed by rounding the internal floating-point values to the nearest
        ///     integer value. The returned values are those maintained in eye coordinates. They will not be equal to the values
        ///     specified using Gl.Light, unless the modelview matrix was identity at the time Gl.Light was called. Although spot
        ///     direction is normalized before being used in the lighting equation, the returned values are the transformed
        ///     versions of
        ///     the specified values prior to normalization. The initial value is 00-1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params contains three integer or floating-point values that specify the direction of the light in
        ///     homogeneous object coordinates. Both integer and floating-point values are mapped directly. Neither integer nor
        ///     floating-point values are clamped. The spot direction is transformed by the upper 3x3 of the modelview matrix when
        ///     glLight is called, and it is stored in eye coordinates. It is significant only when Gl.SPOT_CUTOFF is not 180,
        ///     which it
        ///     is initially. The initial direction is 00-1.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns three fixed-point or floating-point values that specify the direction of the
        ///     light
        ///     in homogeneous object coordinates. Both fixed-point and floating-point values are mapped directly. Neither
        ///     fixed-point
        ///     nor floating-point values are clamped. The initial direction is (0, 0, -1).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params contains three fixed-point or floating-point values that specify the direction of the
        ///     light
        ///     in homogeneous object coordinates. Both fixed-point and floating-point values are mapped directly. Neither
        ///     fixed-point
        ///     nor floating-point values are clamped.The spot direction is transformed by the upper 3x3 of the modelview matrix
        ///     when
        ///     glLight is called, and it is stored in eye coordinates. It is significant only when Gl.SPOT_CUTOFF is not 180,
        ///     which it
        ///     is initially. The initial direction is (0, 0, -1).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SPOT_DIRECTION = 0x1204;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns a single integer or floating-point value representing the spot exponent of the
        ///     light. An integer value, when requested, is computed by rounding the internal floating-point representation to the
        ///     nearest integer. The initial value is 0.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params is a single integer or floating-point value that specifies the intensity distribution of
        ///     the
        ///     light. Integer and floating-point values are mapped directly. Only values in the range 0128 are accepted. Effective
        ///     light intensity is attenuated by the cosine of the angle between the direction of the light and the direction from
        ///     the
        ///     light to the vertex being lighted, raised to the power of the spot exponent. Thus, higher spot exponents result in
        ///     a
        ///     more focused light source, regardless of the spot cutoff angle (see Gl.SPOT_CUTOFF, next paragraph). The initial
        ///     spot
        ///     exponent is 0, resulting in uniform light distribution.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns a single fixed-point or floating-point value that specifies the intensity
        ///     distribution of the light. Fixed-point and floating-point values are mapped directly. Only values in the range [0,
        ///     128]
        ///     are accepted. The initial spot exponent is 0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params is a single fixed-point or floating-point value that specifies the intensity
        ///     distribution of
        ///     the light. Fixed-point and floating-point values are mapped directly. Only values in the range [0, 128] are
        ///     accepted.Effective light intensity is attenuated by the cosine of the angle between the direction of the light and
        ///     the
        ///     direction from the light to the vertex being lighted, raised to the power of the spot exponent. Thus, higher spot
        ///     exponents result in a more focused light source, regardless of the spot cutoff angle (see Gl.SPOT_CUTOFF, next
        ///     paragraph). The initial spot exponent is 0, resulting in uniform light distribution.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SPOT_EXPONENT = 0x1205;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns a single integer or floating-point value representing the spot cutoff angle of
        ///     the
        ///     light. An integer value, when requested, is computed by rounding the internal floating-point representation to the
        ///     nearest integer. The initial value is 180.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params is a single integer or floating-point value that specifies the maximum spread angle of a
        ///     light
        ///     source. Integer and floating-point values are mapped directly. Only values in the range 090 and the special value
        ///     180
        ///     are accepted. If the angle between the direction of the light and the direction from the light to the vertex being
        ///     lighted is greater than the spot cutoff angle, the light is completely masked. Otherwise, its intensity is
        ///     controlled by
        ///     the spot exponent and the attenuation factors. The initial spot cutoff is 180, resulting in uniform light
        ///     distribution.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns a single fixed-point or floating-point value that specifies the maximum
        ///     spread
        ///     angle of a light source. Fixed-point and floating-point values are mapped directly. Only values in the range [0,
        ///     90] and
        ///     the special value 180 are accepted. If the angle between the direction of the light and the direction from the
        ///     light to
        ///     the vertex being lighted is greater than the spot cutoff angle, the light is completely masked. Otherwise, its
        ///     intensity
        ///     is controlled by the spot exponent and the attenuation factors. The initial spot cutoff is 180.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params is a single fixed-point or floating-point value that specifies the maximum spread angle
        ///     of a
        ///     light source. Fixed-point and floating-point values are mapped directly. Only values in the range [0, 90] and the
        ///     special value 180 are accepted. If the angle between the direction of the light and the direction from the light to
        ///     the
        ///     vertex being lighted is greater than the spot cutoff angle, the light is completely masked. Otherwise, its
        ///     intensity is
        ///     controlled by the spot exponent and the attenuation factors. The initial spot cutoff is 180, resulting in uniform
        ///     light
        ///     distribution.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SPOT_CUTOFF = 0x1206;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns a single integer or floating-point value representing the constant (not
        ///     distance-related) attenuation of the light. An integer value, when requested, is computed by rounding the internal
        ///     floating-point representation to the nearest integer. The initial value is 1.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light:
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetLight: params returns a single fixed-point or floating-point value that specifies one of the three
        ///     light
        ///     attenuation factors. Fixed-point and floating-point values are mapped directly. Only nonnegative values are
        ///     accepted. If
        ///     the light is positional, rather than directional, its intensity is attenuated by the reciprocal of the sum of the
        ///     constant factor, the linear factor times the distance between the light and the vertex being lighted, and the
        ///     quadratic
        ///     factor times the square of the same distance. The initial attenuation factors are (1, 0, 0).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Light: params is a single fixed-point or floating-point value that specifies one of the three light
        ///     attenuation factors. Fixed-point and floating-point values are mapped directly. Only nonnegative values are
        ///     accepted. If
        ///     the light is positional, rather than directional, its intensity is attenuated by the reciprocal of the sum of the
        ///     constant factor, the linear factor times the distance between the light and the vertex being lighted, and the
        ///     quadratic
        ///     factor times the square of the same distance. The initial attenuation factors are (1, 0, 0), resulting in no
        ///     attenuation.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CONSTANT_ATTENUATION = 0x1207;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns a single integer or floating-point value representing the linear attenuation of
        ///     the
        ///     light. An integer value, when requested, is computed by rounding the internal floating-point representation to the
        ///     nearest integer. The initial value is 0.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light:
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LINEAR_ATTENUATION = 0x1208;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetLight: params returns a single integer or floating-point value representing the quadratic attenuation
        ///     of
        ///     the light. An integer value, when requested, is computed by rounding the internal floating-point representation to
        ///     the
        ///     nearest integer. The initial value is 0.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Light: params is a single integer or floating-point value that specifies one of the three light
        ///     attenuation
        ///     factors. Integer and floating-point values are mapped directly. Only nonnegative values are accepted. If the light
        ///     is
        ///     positional, rather than directional, its intensity is attenuated by the reciprocal of the sum of the constant
        ///     factor,
        ///     the linear factor times the distance between the light and the vertex being lighted, and the quadratic factor times
        ///     the
        ///     square of the same distance. The initial attenuation factors are (1, 0, 0), resulting in no attenuation.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int QUADRATIC_ATTENUATION = 0x1209;

        /// <summary>
        /// [GL2.1] Gl.NewList: Commands are merely compiled.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMPILE = 0x1300;

        /// <summary>
        /// [GL2.1] Gl.NewList: Commands are executed as they are compiled into the display list.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COMPILE_AND_EXECUTE = 0x1301;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of unsigned bytes. Each pair of bytes specifies a single
        /// display-list
        /// name. The value of the pair is computed as 256 times the unsigned value of the first byte plus the unsigned value of
        /// the
        /// second byte.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _2_BYTES = 0x1407;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of unsigned bytes. Each triplet of bytes specifies a single
        /// display-list name. The value of the triplet is computed as 65536 times the unsigned value of the first byte, plus 256
        /// times the unsigned value of the second byte, plus the unsigned value of the third byte.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _3_BYTES = 0x1408;

        /// <summary>
        /// [GL2.1] Gl.CallLists: lists is treated as an array of unsigned bytes. Each quadruplet of bytes specifies a single
        /// display-list name. The value of the quadruplet is computed as 16777216 times the unsigned value of the first byte, plus
        /// 65536 times the unsigned value of the second byte, plus 256 times the unsigned value of the third byte, plus the
        /// unsigned value of the fourth byte.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int _4_BYTES = 0x1409;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetMaterial: params returns four integer or floating-point values representing the emitted light
        ///     intensity of
        ///     the material. Integer values, when requested, are linearly mapped from the internal floating-point representation
        ///     such
        ///     that 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable
        ///     integer
        ///     value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The
        ///     initial
        ///     value is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Material: params contains four integer or floating-point values that specify the RGBA emitted light
        ///     intensity
        ///     of the material. Integer values are mapped linearly such that the most positive representable value maps to 1.0,
        ///     and the
        ///     most negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor
        ///     floating-point values are clamped. The initial emission intensity for both front- and back-facing materials is (0,
        ///     0, 0,
        ///     1).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetMaterial: params returns four fixed-point or floating-point values that specify the RGBA emitted
        ///     light
        ///     intensity of the material. The values are not clamped. The initial emission intensity is (0, 0, 0, 1).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Material: params contains four fixed-point or floating-point values that specify the RGBA emitted
        ///     light
        ///     intensity of the material. The values are not clamped. The initial emission intensity is (0, 0, 0, 1).
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int EMISSION = 0x1600;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetMaterial: params returns one integer or floating-point value representing the specular exponent of
        ///     the
        ///     material. Integer values, when requested, are computed by rounding the internal floating-point value to the nearest
        ///     integer value. The initial value is 0.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Material: params is a single integer or floating-point value that specifies the RGBA specular exponent
        ///     of the
        ///     material. Integer and floating-point values are mapped directly. Only values in the range 0128 are accepted. The
        ///     initial
        ///     specular exponent for both front- and back-facing materials is 0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.GetMaterial: params returns a single fixed-point or floating-point value that specifies the RGBA
        ///     specular
        ///     exponent of the material. The initial specular exponent is 0.
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.Material: params is a single fixed-point or floating-point value that specifies the RGBA specular
        ///     exponent
        ///     of the material. Only values in the range [0, 128] are accepted. The initial specular exponent is 0.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SHININESS = 0x1601;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.Material: Equivalent to calling glMaterial twice with the same parameter values, once with
        /// Gl.AMBIENT
        /// and once with Gl.DIFFUSE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int AMBIENT_AND_DIFFUSE = 0x1602;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.GetMaterial: params returns three integer or floating-point values representing the ambient, diffuse,
        ///     and
        ///     specular indices of the material. These indices are used only for color index lighting. (All the other parameters
        ///     are
        ///     used only for RGBA lighting.) Integer values, when requested, are computed by rounding the internal floating-point
        ///     values to the nearest integer values.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.Material: params contains three integer or floating-point values specifying the color indices for
        ///     ambient,
        ///     diffuse, and specular lighting. These three values, and Gl.SHININESS, are the only material values used by the
        ///     color
        ///     index mode lighting equation. Refer to the Gl.LightModel reference page for a discussion of color index lighting.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COLOR_INDEXES = 0x1603;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.MatrixMode: Applies subsequent matrix operations to the modelview matrix stack.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MODELVIEW = 0x1700;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.MatrixMode: Applies subsequent matrix operations to the projection matrix stack.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int PROJECTION = 0x1701;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single value, a color index. It is converted to fixed-point format, with an
        ///     unspecified number of bits to the right of the binary point, regardless of the memory data type. Floating-point
        ///     values
        ///     convert to true fixed-point values. Signed and unsigned integer data is converted with all fraction bits set to 0.
        ///     Bitmap data convert to either 0 or 1. Each fixed-point index is then shifted left by Gl.INDEX_SHIFT bits and added
        ///     to
        ///     Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either case, zero bits fill otherwise
        ///     unspecified bit locations in the result. If the GL is in RGBA mode, the resulting index is converted to an RGBA
        ///     pixel
        ///     with the help of the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables.
        ///     If
        ///     the GL is in color index mode, and if Gl.MAP_COLOR is true, the index is replaced with the value that it references
        ///     in
        ///     lookup table Gl.PIXEL_MAP_I_TO_I. Whether the lookup replacement of the index is done or not, the integer part of
        ///     the
        ///     index is then ANDed with 2b-1, where b is the number of bits in a color index buffer. The GL then converts the
        ///     resulting
        ///     indices or RGBA colors to fragments by attaching the current raster position z coordinate and texture coordinates
        ///     to
        ///     each pixel, then assigning x and y window coordinates to the nth fragment such that xn=xr+n%widthyn=yr+nwidth where
        ///     xryr
        ///     is the current raster position. These pixel fragments are then treated just like the fragments generated by
        ///     rasterizing
        ///     points, lines, or polygons. Texture mapping, fog, and all the fragment operations are applied before the fragments
        ///     are
        ///     written to the frame buffer.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels: Color indices are read from the color buffer selected by Gl.ReadBuffer. Each index is
        ///     converted
        ///     to fixed point, shifted left or right depending on the value and sign of Gl.INDEX_SHIFT, and added to
        ///     Gl.INDEX_OFFSET.
        ///     If Gl.MAP_COLOR is Gl.TRUE, indices are replaced by their mappings in the table Gl.PIXEL_MAP_I_TO_I.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a single value, a color index. The GL converts it to fixed point (with an
        ///     unspecified number of zero bits to the right of the binary point), shifted left or right depending on the value and
        ///     sign
        ///     of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set
        ///     of
        ///     color components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A
        ///     tables, and clamped to the range [0,1].
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a single value, a color index. The GL converts it to fixed point (with an
        ///     unspecified number of zero bits to the right of the binary point), shifted left or right depending on the value and
        ///     sign
        ///     of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set
        ///     of
        ///     color components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A
        ///     tables, and clamped to the range [0,1].
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is a single value, a color index. The GL converts it to fixed point (with an
        ///     unspecified number of zero bits to the right of the binary point), shifted left or right depending on the value and
        ///     sign
        ///     of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set
        ///     of
        ///     color components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A
        ///     tables, and clamped to the range [0,1].
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int COLOR_INDEX = 0x1900;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a single luminance component. This component is converted to the internal
        ///     floating-point format in the same way the red component of an RGBA pixel is. It is then converted to an RGBA pixel
        ///     with
        ///     red, green, and blue set to the converted luminance value, and alpha set to 1. After this conversion, the pixel is
        ///     treated as if it had been read as an RGBA pixel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels:
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a single luminance value. The GL converts it to floating point, then
        ///     assembles it
        ///     into an RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for
        ///     alpha.
        ///     Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and
        ///     clamped
        ///     to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a single luminance value. The GL converts it to floating point, then
        ///     assembles it
        ///     into an RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for
        ///     alpha.
        ///     Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and
        ///     clamped
        ///     to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is a single luminance value. The GL converts it to floating point, then
        ///     assembles it
        ///     into an RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for
        ///     alpha.
        ///     Each component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and
        ///     clamped
        ///     to the range [0,1] (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.TexImage2D: Each element is a single luminance value. The GL converts it to fixed-point or
        ///     floating-point,
        ///     then assembles it into an RGBA element by replicating the luminance value three times for red, green, and blue and
        ///     attaching 1 for alpha.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LUMINANCE = 0x1909;

        /// <summary>
        ///     <para>
        ///     [GL2.1] Gl.DrawPixels: Each pixel is a two-component group: luminance first, followed by alpha. The two components
        ///     are
        ///     converted to the internal floating-point format in the same way the red component of an RGBA pixel is. They are
        ///     then
        ///     converted to an RGBA pixel with red, green, and blue set to the converted luminance value, and alpha set to the
        ///     converted alpha value. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.ReadPixels: Processing differs depending on whether color buffers store color indices or RGBA color
        ///     components. If color indices are stored, they are read from the color buffer selected by Gl.ReadBuffer. Each index
        ///     is
        ///     converted to fixed point, shifted left or right depending on the value and sign of Gl.INDEX_SHIFT, and added to
        ///     Gl.INDEX_OFFSET. Indices are then replaced by the red, green, blue, and alpha values obtained by indexing the
        ///     tables
        ///     Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A. Each table must be of size
        ///     2n,
        ///     but n may be different for different tables. Before an index is used to look up a value in a table of size 2n, it
        ///     must
        ///     be masked against 2n-1. If RGBA color components are stored in the color buffers, they are read from the color
        ///     buffer
        ///     selected by Gl.ReadBuffer. Each color component is converted to floating point such that zero intensity maps to 0.0
        ///     and
        ///     full intensity maps to 1.0. Each component is then multiplied by Gl.c_SCALE and added to Gl.c_BIAS, where c is RED,
        ///     GREEN, BLUE, or ALPHA. Finally, if Gl.MAP_COLOR is Gl.TRUE, each component is clamped to the range 01, scaled to
        ///     the
        ///     size of its corresponding table, and is then replaced by its mapping in the table Gl.PIXEL_MAP_c_TO_c, where c is
        ///     R, G,
        ///     B, or A. Unneeded data is then discarded. For example, Gl.RED discards the green, blue, and alpha components, while
        ///     Gl.RGB discards only the alpha component. Gl.LUMINANCE computes a single-component value as the sum of the red,
        ///     green,
        ///     and blue components, and Gl.LUMINANCE_ALPHA does the same, while keeping alpha as a second value. The final values
        ///     are
        ///     clamped to the range 01.
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage1D: Each element is a luminance/alpha pair. The GL converts it to floating point, then assembles
        ///     it
        ///     into an RGBA element by replicating the luminance value three times for red, green, and blue. Each component is
        ///     then
        ///     multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range
        ///     [0,1]
        ///     (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage2D: Each element is a luminance/alpha pair. The GL converts it to floating point, then assembles
        ///     it
        ///     into an RGBA element by replicating the luminance value three times for red, green, and blue. Each component is
        ///     then
        ///     multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range
        ///     [0,1]
        ///     (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GL2.1] Gl.TexImage3D: Each element is a luminance/alpha pair. The GL converts it to floating point, then assembles
        ///     it
        ///     into an RGBA element by replicating the luminance value three times for red, green, and blue. Each component is
        ///     then
        ///     multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range
        ///     [0,1]
        ///     (see Gl.PixelTransfer).
        ///     </para>
        ///     <para>
        ///     [GLES1.1] Gl.TexImage2D: Each element is a luminance/alpha pair. The GL converts it to fixed-point or floating
        ///     point,
        ///     then assembles it into an RGBA element by replicating the luminance value three times for red, green, and blue.
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LUMINANCE_ALPHA = 0x190A;

        /// <summary>
        /// [GL] Value of GL_BITMAP symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int BITMAP = 0x1A00;

        /// <summary>
        /// [GL2.1] Gl.RenderMode: Render mode. Primitives are rasterized, producing pixel fragments, which are written into the
        /// frame buffer. This is the normal mode and also the default mode.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int RENDER = 0x1C00;

        /// <summary>
        /// [GL2.1] Gl.RenderMode: Feedback mode. No pixel fragments are produced, and no change to the frame buffer contents is
        /// made. Instead, the coordinates and attributes of vertices that would have been drawn if the render mode had been
        /// Gl.RENDER is returned in a feedback buffer, which must be created (see Gl.FeedbackBuffer) before feedback mode is
        /// entered.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FEEDBACK = 0x1C01;

        /// <summary>
        /// [GL2.1] Gl.RenderMode: Selection mode. No pixel fragments are produced, and no change to the frame buffer contents is
        /// made. Instead, a record of the names of primitives that would have been drawn if the render mode had been Gl.RENDER is
        /// returned in a select buffer, which must be created (see Gl.SelectBuffer) before selection mode is entered.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SELECT = 0x1C02;

        /// <summary>
        /// [GL] Value of GL_FLAT symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int FLAT = 0x1D00;

        /// <summary>
        /// [GL] Value of GL_SMOOTH symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SMOOTH = 0x1D01;

        /// <summary>
        /// [GL] Value of GL_S symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int S = 0x2000;

        /// <summary>
        /// [GL] Value of GL_T symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int T = 0x2001;

        /// <summary>
        /// [GL] Value of GL_R symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int R = 0x2002;

        /// <summary>
        /// [GL] Value of GL_Q symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int Q = 0x2003;

        /// <summary>
        /// [GL] Value of GL_MODULATE symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int MODULATE = 0x2100;

        /// <summary>
        /// [GL] Value of GL_DECAL symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int DECAL = 0x2101;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns the single-valued texture environment mode, a symbolic constant. The
        /// initial value is Gl.MODULATE.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_ENV_MODE = 0x2200;

        /// <summary>
        /// [GL2.1|GLES1.1] Gl.GetTexEnv: params returns four integer or floating-point values that are the texture environment
        /// color. Integer values, when requested, are linearly mapped from the internal floating-point representation such that
        /// 1.0
        /// maps to the most positive representable integer, and -1.0 maps to the most negative representable integer. The initial
        /// value is (0, 0, 0, 0).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_ENV_COLOR = 0x2201;

        /// <summary>
        /// [GL] Value of GL_TEXTURE_ENV symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_ENV = 0x2300;

        /// <summary>
        /// [GL] Value of GL_EYE_LINEAR symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int EYE_LINEAR = 0x2400;

        /// <summary>
        /// [GL] Value of GL_OBJECT_LINEAR symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int OBJECT_LINEAR = 0x2401;

        /// <summary>
        /// [GL] Value of GL_SPHERE_MAP symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int SPHERE_MAP = 0x2402;

        /// <summary>
        /// [GL2.1] Gl.GetTexGen: params returns the single-valued texture generation function, a symbolic constant. The initial
        /// value is Gl.EYE_LINEAR.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int TEXTURE_GEN_MODE = 0x2500;

        /// <summary>
        /// [GL2.1] Gl.GetTexGen: params returns the four plane equation coefficients that specify object linear-coordinate
        /// generation. Integer values, when requested, are mapped directly from the internal floating-point representation.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int OBJECT_PLANE = 0x2501;

        /// <summary>
        /// [GL2.1] Gl.GetTexGen: params returns the four plane equation coefficients that specify eye linear-coordinate
        /// generation.
        /// Integer values, when requested, are mapped directly from the internal floating-point representation. The returned
        /// values
        /// are those maintained in eye coordinates. They are not equal to the values specified using Gl.TexGen, unless the
        /// modelview matrix was identity when Gl.TexGen was called.
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_fog_distance")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int EYE_PLANE = 0x2502;

        /// <summary>
        /// [GL] Value of GL_CLAMP symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLAMP = 0x2900;

        /// <summary>
        /// [GL] Value of GL_CLIP_PLANE0 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLIP_PLANE0 = 0x3000;

        /// <summary>
        /// [GL] Value of GL_CLIP_PLANE1 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLIP_PLANE1 = 0x3001;

        /// <summary>
        /// [GL] Value of GL_CLIP_PLANE2 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLIP_PLANE2 = 0x3002;

        /// <summary>
        /// [GL] Value of GL_CLIP_PLANE3 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLIP_PLANE3 = 0x3003;

        /// <summary>
        /// [GL] Value of GL_CLIP_PLANE4 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLIP_PLANE4 = 0x3004;

        /// <summary>
        /// [GL] Value of GL_CLIP_PLANE5 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2")]
        public const int CLIP_PLANE5 = 0x3005;

        /// <summary>
        /// [GL] Value of GL_LIGHT0 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT0 = 0x4000;

        /// <summary>
        /// [GL] Value of GL_LIGHT1 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT1 = 0x4001;

        /// <summary>
        /// [GL] Value of GL_LIGHT2 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT2 = 0x4002;

        /// <summary>
        /// [GL] Value of GL_LIGHT3 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT3 = 0x4003;

        /// <summary>
        /// [GL] Value of GL_LIGHT4 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT4 = 0x4004;

        /// <summary>
        /// [GL] Value of GL_LIGHT5 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT5 = 0x4005;

        /// <summary>
        /// [GL] Value of GL_LIGHT6 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT6 = 0x4006;

        /// <summary>
        /// [GL] Value of GL_LIGHT7 symbol (DEPRECATED).
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2")]
        public const int LIGHT7 = 0x4007;

        /// <summary>
        ///     <para>
        ///     [GL4] glCullFace: specify whether front- or back-facing facets can be culled
        ///     </para>
        ///     <para>
        ///     [GLES3.2] glCullFace: specify whether front- or back-facing polygons can be culled
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants Gl.FRONT, Gl.BACK, and
        /// Gl.FRONT_AND_BACK are accepted. The initial value is Gl.BACK.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void CullFace(CullFaceMode mode)
        {
            Debug.Assert(Delegates.pglCullFace != null, "pglCullFace not implemented");
            Delegates.pglCullFace((int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glFrontFace: define front- and back-facing polygons
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies the orientation of front-facing polygons. Gl.CW and Gl.CCW are accepted. The initial value is Gl.CCW.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void FrontFace(FrontFaceDirection mode)
        {
            Debug.Assert(Delegates.pglFrontFace != null, "pglFrontFace not implemented");
            Delegates.pglFrontFace((int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glHint: specify implementation-specific hints
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a symbolic constant indicating the behavior to be controlled. Gl.LINE_SMOOTH_HINT, Gl.POLYGON_SMOOTH_HINT,
        /// Gl.TEXTURE_COMPRESSION_HINT, and Gl.FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
        /// </param>
        /// <param name="mode">
        /// Specifies a symbolic constant indicating the desired behavior. Gl.FASTEST, Gl.NICEST, and Gl.DONT_CARE are accepted.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Hint(HintTarget target, HintMode mode)
        {
            Debug.Assert(Delegates.pglHint != null, "pglHint not implemented");
            Delegates.pglHint((int) target, (int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES1.1] glLineWidth: specify the width of rasterized lines
        ///     </para>
        /// </summary>
        /// <param name="width">
        /// Specifies the width of rasterized lines. The initial value is 1.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void LineWidth(float width)
        {
            Debug.Assert(Delegates.pglLineWidth != null, "pglLineWidth not implemented");
            Delegates.pglLineWidth(width);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES1.1] glPointSize: specify the diameter of rasterized points
        ///     </para>
        /// </summary>
        /// <param name="size">
        /// Specifies the diameter of rasterized points. The initial value is 1.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        public static void PointSize(float size)
        {
            Debug.Assert(Delegates.pglPointSize != null, "pglPointSize not implemented");
            Delegates.pglPointSize(size);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glPolygonMode: select a polygon rasterization mode
        /// </summary>
        /// <param name="face">
        /// Specifies the polygons that <paramref name="mode" /> applies to. Must be Gl.FRONT_AND_BACK for front- and back-facing
        /// polygons.
        /// </param>
        /// <param name="mode">
        /// Specifies how polygons will be rasterized. Accepted values are Gl.POINT, Gl.LINE, and Gl.FILL. The initial value is
        /// Gl.FILL for both front- and back-facing polygons.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
        public static void PolygonMode(MaterialFace face, PolygonMode mode)
        {
            Debug.Assert(Delegates.pglPolygonMode != null, "pglPolygonMode not implemented");
            Delegates.pglPolygonMode((int) face, (int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glScissor: define the scissor box
        ///     </para>
        /// </summary>
        /// <param name="x">
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </param>
        /// <param name="y">
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </param>
        /// <param name="width">
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window,
        /// <paramref
        ///     name="width" />
        /// and <paramref name="height" /> are set to the dimensions of that window.
        /// </param>
        /// <param name="height">
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window,
        /// <paramref
        ///     name="width" />
        /// and <paramref name="height" /> are set to the dimensions of that window.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Scissor(int x, int y, int width, int height)
        {
            Debug.Assert(Delegates.pglScissor != null, "pglScissor not implemented");
            Delegates.pglScissor(x, y, width, height);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameterf: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="param">
        /// Specifies the value of <paramref name="pname" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void TexParameter(TextureTarget target, TextureParameterName pname, float param)
        {
            Debug.Assert(Delegates.pglTexParameterf != null, "pglTexParameterf not implemented");
            Delegates.pglTexParameterf((int) target, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameterfv: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void TexParameter(TextureTarget target, TextureParameterName pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
                    Delegates.pglTexParameterfv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameterfv: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static unsafe void TexParameter(TextureTarget target, TextureParameterName pname, float* @params)
        {
            Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
            Delegates.pglTexParameterfv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameterfv: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void TexParameterf<T>(TextureTarget target, TextureParameterName pname, T @params) where T : struct
        {
            Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglTexParameterfv((int)target, (int)pname, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglTexParameterfv((int) target, (int) pname, (float*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameteri: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="param">
        /// Specifies the value of <paramref name="pname" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void TexParameter(TextureTarget target, TextureParameterName pname, int param)
        {
            Debug.Assert(Delegates.pglTexParameteri != null, "pglTexParameteri not implemented");
            Delegates.pglTexParameteri((int) target, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameteriv: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void TexParameter(TextureTarget target, TextureParameterName pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
                    Delegates.pglTexParameteriv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameteriv: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int*" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static unsafe void TexParameter(TextureTarget target, TextureParameterName pname, int* @params)
        {
            Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
            Delegates.pglTexParameteriv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexParameteriv: set texture parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname" /> can be one of the
        /// following:
        /// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY,
        /// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:T" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void TexParameteri<T>(TextureTarget target, TextureParameterName pname, T @params) where T : struct
        {
            Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglTexParameteriv((int) target, (int) pname, (int*) refParamsPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexImage1D: specify a one-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalFormat">
        /// Specifies the number of color components in the texture. Must be 1, 2, 3, or 4, or one of the following symbolic
        /// constants: Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE,
        /// Gl.COMPRESSED_LUMINANCE_ALPHA, Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.DEPTH_COMPONENT,
        /// Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8,
        /// Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8,
        /// Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8,
        /// Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA,
        /// Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8,
        /// Gl.SLUMINANCE_ALPHA, Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images
        /// that are at least 64 texels wide. The height of the 1D texture image is 1.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN,
        /// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2,
        /// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4,
        /// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8,
        /// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void TexImage1D(TextureTarget target, int level, InternalFormat internalFormat, int width, int border, PixelFormat format, PixelType type, IntPtr data)
        {
            Debug.Assert(Delegates.pglTexImage1D != null, "pglTexImage1D not implemented");
            Delegates.pglTexImage1D((int) target, level, (int) internalFormat, width, border, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexImage1D: specify a one-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalFormat">
        /// Specifies the number of color components in the texture. Must be 1, 2, 3, or 4, or one of the following symbolic
        /// constants: Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE,
        /// Gl.COMPRESSED_LUMINANCE_ALPHA, Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.DEPTH_COMPONENT,
        /// Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8,
        /// Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8,
        /// Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8,
        /// Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA,
        /// Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8,
        /// Gl.SLUMINANCE_ALPHA, Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images
        /// that are at least 64 texels wide. The height of the 1D texture image is 1.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN,
        /// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2,
        /// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4,
        /// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8,
        /// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void TexImage1D(TextureTarget target, int level, InternalFormat internalFormat, int width, int border, PixelFormat format, PixelType type, object data)
        {
            GCHandle pin_pixels = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                TexImage1D(target, level, internalFormat, width, border, format, type, pin_pixels.AddrOfPinnedObject());
            }
            finally
            {
                pin_pixels.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexImage2D: specify a two-dimensional texture image
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalFormat">
        /// Specifies the number of color components in the texture. Must be 1, 2, 3, or 4, or one of the following symbolic
        /// constants: Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE,
        /// Gl.COMPRESSED_LUMINANCE_ALPHA, Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.DEPTH_COMPONENT,
        /// Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8,
        /// Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8,
        /// Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8,
        /// Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA,
        /// Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8,
        /// Gl.SLUMINANCE_ALPHA, Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images
        /// that are at least 64 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images
        /// that are at least 64 texels high.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN,
        /// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2,
        /// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4,
        /// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8,
        /// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data)
        {
            Debug.Assert(Delegates.pglTexImage2D != null, "pglTexImage2D not implemented");
            Delegates.pglTexImage2D((int) target, level, (int) internalFormat, width, height, border, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexImage2D: specify a two-dimensional texture image
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </param>
        /// <param name="internalFormat">
        /// Specifies the number of color components in the texture. Must be 1, 2, 3, or 4, or one of the following symbolic
        /// constants: Gl.ALPHA, Gl.ALPHA4, Gl.ALPHA8, Gl.ALPHA12, Gl.ALPHA16, Gl.COMPRESSED_ALPHA, Gl.COMPRESSED_LUMINANCE,
        /// Gl.COMPRESSED_LUMINANCE_ALPHA, Gl.COMPRESSED_INTENSITY, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA, Gl.DEPTH_COMPONENT,
        /// Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, Gl.DEPTH_COMPONENT32, Gl.LUMINANCE, Gl.LUMINANCE4, Gl.LUMINANCE8,
        /// Gl.LUMINANCE12, Gl.LUMINANCE16, Gl.LUMINANCE_ALPHA, Gl.LUMINANCE4_ALPHA4, Gl.LUMINANCE6_ALPHA2, Gl.LUMINANCE8_ALPHA8,
        /// Gl.LUMINANCE12_ALPHA4, Gl.LUMINANCE12_ALPHA12, Gl.LUMINANCE16_ALPHA16, Gl.INTENSITY, Gl.INTENSITY4, Gl.INTENSITY8,
        /// Gl.INTENSITY12, Gl.INTENSITY16, Gl.R3_G3_B2, Gl.RGB, Gl.RGB4, Gl.RGB5, Gl.RGB8, Gl.RGB10, Gl.RGB12, Gl.RGB16, Gl.RGBA,
        /// Gl.RGBA2, Gl.RGBA4, Gl.RGB5_A1, Gl.RGBA8, Gl.RGB10_A2, Gl.RGBA12, Gl.RGBA16, Gl.SLUMINANCE, Gl.SLUMINANCE8,
        /// Gl.SLUMINANCE_ALPHA, Gl.SLUMINANCE8_ALPHA8, Gl.SRGB, Gl.SRGB8, Gl.SRGB_ALPHA, or Gl.SRGB8_ALPHA8.
        /// </param>
        /// <param name="width">
        /// Specifies the width of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images
        /// that are at least 64 texels wide.
        /// </param>
        /// <param name="height">
        /// Specifies the height of the texture image including the border if any. If the GL version does not support
        /// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images
        /// that are at least 64 texels high.
        /// </param>
        /// <param name="border">
        /// Specifies the width of the border. Must be either 0 or 1.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN,
        /// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE,
        /// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2,
        /// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4,
        /// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8,
        /// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="data">
        /// Specifies a pointer to the image data in memory.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        public static void TexImage2D(TextureTarget target, int level, InternalFormat internalFormat, int width, int height, int border, PixelFormat format, PixelType type, object data)
        {
            GCHandle pin_pixels = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                TexImage2D(target, level, internalFormat, width, height, border, format, type, pin_pixels.AddrOfPinnedObject());
            }
            finally
            {
                pin_pixels.Free();
            }
        }

        /// <summary>
        /// [GL4] glDrawBuffer: specify which color buffers are to be drawn into
        /// </summary>
        /// <param name="buf">
        /// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants Gl.NONE,
        /// Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT, Gl.BACK, Gl.LEFT, Gl.RIGHT, and Gl.FRONT_AND_BACK
        /// are accepted. The initial value is Gl.FRONT for single-buffered contexts, and Gl.BACK for double-buffered contexts. For
        /// framebuffer objects, Gl.COLOR_ATTACHMENT$m$ and Gl.NONE enums are accepted, where Gl. is a value between 0 and
        /// Gl.MAX_COLOR_ATTACHMENTS.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void DrawBuffer(DrawBufferMode buf)
        {
            Debug.Assert(Delegates.pglDrawBuffer != null, "pglDrawBuffer not implemented");
            Delegates.pglDrawBuffer((int) buf);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glClear: clear buffers to preset values
        ///     </para>
        /// </summary>
        /// <param name="mask">
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are Gl.COLOR_BUFFER_BIT,
        /// Gl.DEPTH_BUFFER_BIT, and Gl.STENCIL_BUFFER_BIT.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Clear(ClearBufferMask mask)
        {
            Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
            Delegates.pglClear((uint) mask);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glClearColor: specify clear values for the color buffers
        ///     </para>
        /// </summary>
        /// <param name="red">
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="green">
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="blue">
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        /// <param name="alpha">
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void ClearColor(float red, float green, float blue, float alpha)
        {
            Debug.Assert(Delegates.pglClearColor != null, "pglClearColor not implemented");
            Delegates.pglClearColor(red, green, blue, alpha);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glClearStencil: specify the clear value for the stencil buffer
        ///     </para>
        /// </summary>
        /// <param name="s">
        /// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void ClearStencil(int s)
        {
            Debug.Assert(Delegates.pglClearStencil != null, "pglClearStencil not implemented");
            Delegates.pglClearStencil(s);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glClearDepth: specify the clear value for the depth buffer
        /// </summary>
        /// <param name="depth">
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void ClearDepth(double depth)
        {
            Debug.Assert(Delegates.pglClearDepth != null, "pglClearDepth not implemented");
            Delegates.pglClearDepth(depth);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glStencilMask: control the front and back writing of individual bits in the stencil planes
        ///     </para>
        /// </summary>
        /// <param name="mask">
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all
        /// 1's.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void StencilMask(uint mask)
        {
            Debug.Assert(Delegates.pglStencilMask != null, "pglStencilMask not implemented");
            Delegates.pglStencilMask(mask);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glColorMask: enable and disable writing of frame buffer color components
        ///     </para>
        /// </summary>
        /// <param name="red">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        /// <param name="green">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        /// <param name="blue">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        /// <param name="alpha">
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all
        /// Gl.TRUE,
        /// indicating that the color components are written.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            Debug.Assert(Delegates.pglColorMask != null, "pglColorMask not implemented");
            Delegates.pglColorMask(red, green, blue, alpha);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDepthMask: enable or disable writing into the depth buffer
        ///     </para>
        /// </summary>
        /// <param name="flag">
        /// Specifies whether the depth buffer is enabled for writing. If <paramref name="flag" /> is Gl.FALSE, depth buffer
        /// writing
        /// is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void DepthMask(bool flag)
        {
            Debug.Assert(Delegates.pglDepthMask != null, "pglDepthMask not implemented");
            Delegates.pglDepthMask(flag);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glDisable: enable or disable server-side GL capabilities
        ///     </para>
        /// </summary>
        /// <param name="cap">
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Disable(EnableCap cap)
        {
            Debug.Assert(Delegates.pglDisable != null, "pglDisable not implemented");
            Delegates.pglDisable((int) cap);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glEnable: enable or disable server-side GL capabilities
        ///     </para>
        /// </summary>
        /// <param name="cap">
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Enable(EnableCap cap)
        {
            Debug.Assert(Delegates.pglEnable != null, "pglEnable not implemented");
            Delegates.pglEnable((int) cap);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glFinish: block until all GL execution is complete
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Finish()
        {
            Debug.Assert(Delegates.pglFinish != null, "pglFinish not implemented");
            Delegates.pglFinish();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glFlush: force execution of GL commands in finite time
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Flush()
        {
            Debug.Assert(Delegates.pglFlush != null, "pglFlush not implemented");
            Delegates.pglFlush();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glBlendFunc: specify pixel arithmetic
        ///     </para>
        /// </summary>
        /// <param name="sfactor">
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants
        /// are
        /// accepted: Gl.ZERO, Gl.ONE, Gl.SRC_COLOR, Gl.ONE_MINUS_SRC_COLOR, Gl.DST_COLOR, Gl.ONE_MINUS_DST_COLOR, Gl.SRC_ALPHA,
        /// Gl.ONE_MINUS_SRC_ALPHA, Gl.DST_ALPHA, Gl.ONE_MINUS_DST_ALPHA, Gl.CONSTANT_COLOR, Gl.ONE_MINUS_CONSTANT_COLOR,
        /// Gl.CONSTANT_ALPHA, Gl.ONE_MINUS_CONSTANT_ALPHA, and Gl.SRC_ALPHA_SATURATE. The initial value is Gl.ONE.
        /// </param>
        /// <param name="dfactor">
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic
        /// constants are accepted: Gl.ZERO, Gl.ONE, Gl.SRC_COLOR, Gl.ONE_MINUS_SRC_COLOR, Gl.DST_COLOR, Gl.ONE_MINUS_DST_COLOR,
        /// Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, Gl.DST_ALPHA, Gl.ONE_MINUS_DST_ALPHA. Gl.CONSTANT_COLOR,
        /// Gl.ONE_MINUS_CONSTANT_COLOR, Gl.CONSTANT_ALPHA, and Gl.ONE_MINUS_CONSTANT_ALPHA. The initial value is Gl.ZERO.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
        {
            Debug.Assert(Delegates.pglBlendFunc != null, "pglBlendFunc not implemented");
            Delegates.pglBlendFunc((int) sfactor, (int) dfactor);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4] glLogicOp: specify a logical pixel operation for rendering
        ///     </para>
        ///     <para>
        ///     [GLES1.1] glLogicOp: specify a logical pixel operation
        ///     </para>
        /// </summary>
        /// <param name="opcode">
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: Gl.CLEAR, Gl.SET,
        /// Gl.COPY, Gl.COPY_INVERTED, Gl.NOOP, Gl.INVERT, Gl.AND, Gl.NAND, Gl.OR, Gl.NOR, Gl.XOR, Gl.EQUIV, Gl.AND_REVERSE,
        /// Gl.AND_INVERTED, Gl.OR_REVERSE, and Gl.OR_INVERTED. The initial value is Gl.COPY.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        public static void LogicOp(LogicOp opcode)
        {
            Debug.Assert(Delegates.pglLogicOp != null, "pglLogicOp not implemented");
            Delegates.pglLogicOp((int) opcode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glStencilFunc: set front and back function and reference value for stencil testing
        ///     </para>
        /// </summary>
        /// <param name="func">
        /// Specifies the test function. Eight symbolic constants are valid: Gl.NEVER, Gl.LESS, Gl.LEQUAL, Gl.GREATER, Gl.GEQUAL,
        /// Gl.EQUAL, Gl.NOTEQUAL, and Gl.ALWAYS. The initial value is Gl.ALWAYS.
        /// </param>
        /// <param name="ref">
        /// Specifies the reference value for the stencil test. <paramref name="ref" /> is clamped to the range 02n-1, where n is
        /// the
        /// number of bitplanes in the stencil buffer. The initial value is 0.
        /// </param>
        /// <param name="mask">
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The
        /// initial value is all 1's.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void StencilFunc(StencilFunction func, int @ref, uint mask)
        {
            Debug.Assert(Delegates.pglStencilFunc != null, "pglStencilFunc not implemented");
            Delegates.pglStencilFunc((int) func, @ref, mask);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glStencilOp: set front and back stencil test actions
        ///     </para>
        /// </summary>
        /// <param name="sfail">
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Gl.KEEP, Gl.ZERO,
        /// Gl.REPLACE, Gl.INCR, Gl.INCR_WRAP, Gl.DECR, Gl.DECR_WRAP, and Gl.INVERT. The initial value is Gl.KEEP.
        /// </param>
        /// <param name="dpfail">
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. <paramref name="dpfail" /> accepts
        /// the same symbolic constants as <paramref name="sfail" />. The initial value is Gl.KEEP.
        /// </param>
        /// <param name="dppass">
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and
        /// either there is no depth buffer or depth testing is not enabled. <paramref name="dppass" /> accepts the same symbolic
        /// constants as <paramref name="sfail" />. The initial value is Gl.KEEP.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void StencilOp(StencilOp sfail, StencilOp dpfail, StencilOp dppass)
        {
            Debug.Assert(Delegates.pglStencilOp != null, "pglStencilOp not implemented");
            Delegates.pglStencilOp((int) sfail, (int) dpfail, (int) dppass);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glDepthFunc: specify the value used for depth buffer comparisons
        ///     </para>
        /// </summary>
        /// <param name="func">
        /// Specifies the depth comparison function. Symbolic constants Gl.NEVER, Gl.LESS, Gl.EQUAL, Gl.LEQUAL, Gl.GREATER,
        /// Gl.NOTEQUAL, Gl.GEQUAL, and Gl.ALWAYS are accepted. The initial value is Gl.LESS.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void DepthFunc(DepthFunction func)
        {
            Debug.Assert(Delegates.pglDepthFunc != null, "pglDepthFunc not implemented");
            Delegates.pglDepthFunc((int) func);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelStoref: set pixel storage modes
        /// </summary>
        /// <param name="pname">
        /// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory:
        /// Gl.PACK_SWAP_BYTES, Gl.PACK_LSB_FIRST, Gl.PACK_ROW_LENGTH, Gl.PACK_IMAGE_HEIGHT, Gl.PACK_SKIP_PIXELS,
        /// Gl.PACK_SKIP_ROWS,
        /// Gl.PACK_SKIP_IMAGES, and Gl.PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory:
        /// Gl.UNPACK_SWAP_BYTES, Gl.UNPACK_LSB_FIRST, Gl.UNPACK_ROW_LENGTH, Gl.UNPACK_IMAGE_HEIGHT, Gl.UNPACK_SKIP_PIXELS,
        /// Gl.UNPACK_SKIP_ROWS, Gl.UNPACK_SKIP_IMAGES, and Gl.UNPACK_ALIGNMENT.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="pname" /> is set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void PixelStore(PixelStoreParameter pname, float param)
        {
            Debug.Assert(Delegates.pglPixelStoref != null, "pglPixelStoref not implemented");
            Delegates.pglPixelStoref((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glPixelStorei: set pixel storage modes
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory:
        /// Gl.PACK_SWAP_BYTES, Gl.PACK_LSB_FIRST, Gl.PACK_ROW_LENGTH, Gl.PACK_IMAGE_HEIGHT, Gl.PACK_SKIP_PIXELS,
        /// Gl.PACK_SKIP_ROWS,
        /// Gl.PACK_SKIP_IMAGES, and Gl.PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory:
        /// Gl.UNPACK_SWAP_BYTES, Gl.UNPACK_LSB_FIRST, Gl.UNPACK_ROW_LENGTH, Gl.UNPACK_IMAGE_HEIGHT, Gl.UNPACK_SKIP_PIXELS,
        /// Gl.UNPACK_SKIP_ROWS, Gl.UNPACK_SKIP_IMAGES, and Gl.UNPACK_ALIGNMENT.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="pname" /> is set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void PixelStore(PixelStoreParameter pname, int param)
        {
            Debug.Assert(Delegates.pglPixelStorei != null, "pglPixelStorei not implemented");
            Delegates.pglPixelStorei((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glReadBuffer: select a color buffer source for pixels
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies a color buffer. Accepted values are Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT,
        /// Gl.BACK, Gl.LEFT, Gl.RIGHT, and the constants Gl.COLOR_ATTACHMENTi.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
        public static void ReadBuffer(ReadBufferMode mode)
        {
            Debug.Assert(Delegates.pglReadBuffer != null, "pglReadBuffer not implemented");
            Delegates.pglReadBuffer((int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1] glReadPixels: read a block of pixels from the frame buffer
        ///     </para>
        ///     <para>
        ///     [GLES1.1] glReadPixels: read a block of pixels from the color buffer
        ///     </para>
        /// </summary>
        /// <param name="x">
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left
        /// corner of a rectangular block of pixels.
        /// </param>
        /// <param name="y">
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left
        /// corner of a rectangular block of pixels.
        /// </param>
        /// <param name="width">
        /// Specify the dimensions of the pixel rectangle. <paramref name="width" /> and <paramref name="height" /> of one
        /// correspond
        /// to a single pixel.
        /// </param>
        /// <param name="height">
        /// Specify the dimensions of the pixel rectangle. <paramref name="width" /> and <paramref name="height" /> of one
        /// correspond
        /// to a single pixel.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.STENCIL_INDEX,
        /// Gl.DEPTH_COMPONENT, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and
        /// Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of the pixel data. Must be one of Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, Gl.UNSIGNED_SHORT,
        /// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV,
        /// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV,
        /// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV,
        /// Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="data">
        /// Returns the pixel data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        {
            Debug.Assert(Delegates.pglReadPixels != null, "pglReadPixels not implemented");
            Delegates.pglReadPixels(x, y, width, height, (int) format, (int) type, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleanv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(int pname, [Out] byte[] data)
        {
            unsafe
            {
                fixed (byte* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
                    Delegates.pglGetBooleanv(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleanv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(GetPName pname, [Out] byte[] data)
        {
            unsafe
            {
                fixed (byte* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
                    Delegates.pglGetBooleanv((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleanv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(int pname, out byte data)
        {
            unsafe
            {
                fixed (byte* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
                    Delegates.pglGetBooleanv(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleanv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(GetPName pname, out byte data)
        {
            unsafe
            {
                fixed (byte* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
                    Delegates.pglGetBooleanv((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleanv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static unsafe void Get(GetPName pname, [Out] byte* data)
        {
            Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
            Delegates.pglGetBooleanv((int) pname, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetBooleanv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetBoolean<T>(GetPName pname, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
            data = default;
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetBooleanv((int) pname, (byte*) refDataPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublev: return the value or values of a selected parameter
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void Get(int pname, [Out] double[] data)
        {
            unsafe
            {
                fixed (double* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
                    Delegates.pglGetDoublev(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublev: return the value or values of a selected parameter
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void Get(GetPName pname, [Out] double[] data)
        {
            unsafe
            {
                fixed (double* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
                    Delegates.pglGetDoublev((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublev: return the value or values of a selected parameter
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void Get(int pname, out double data)
        {
            unsafe
            {
                fixed (double* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
                    Delegates.pglGetDoublev(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublev: return the value or values of a selected parameter
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void Get(GetPName pname, out double data)
        {
            unsafe
            {
                fixed (double* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
                    Delegates.pglGetDoublev((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublev: return the value or values of a selected parameter
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static unsafe void Get(GetPName pname, [Out] double* data)
        {
            Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
            Delegates.pglGetDoublev((int) pname, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL4] glGetDoublev: return the value or values of a selected parameter
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void GetDouble<T>(GetPName pname, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
            data = default;
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetDoublev((int) pname, (double*) refDataPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetError: return error information
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static ErrorCode GetError()
        {
            int retValue;

            Debug.Assert(Delegates.pglGetError != null, "pglGetError not implemented");
            retValue = Delegates.pglGetError();

            return (ErrorCode) retValue;
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetFloatv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(int pname, [Out] float[] data)
        {
            unsafe
            {
                fixed (float* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
                    Delegates.pglGetFloatv(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetFloatv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(GetPName pname, [Out] float[] data)
        {
            unsafe
            {
                fixed (float* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
                    Delegates.pglGetFloatv((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetFloatv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(int pname, out float data)
        {
            unsafe
            {
                fixed (float* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
                    Delegates.pglGetFloatv(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetFloatv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(GetPName pname, out float data)
        {
            unsafe
            {
                fixed (float* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
                    Delegates.pglGetFloatv((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetFloatv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static unsafe void Get(GetPName pname, [Out] float* data)
        {
            Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
            Delegates.pglGetFloatv((int) pname, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetFloatv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetFloat<T>(GetPName pname, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
            data = default;
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetFloatv((int) pname, (float*) refDataPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegerv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(int pname, [Out] int[] data)
        {
            unsafe
            {
                fixed (int* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
                    Delegates.pglGetIntegerv(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegerv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(GetPName pname, [Out] int[] data)
        {
            unsafe
            {
                fixed (int* p_data = data)
                {
                    Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
                    Delegates.pglGetIntegerv((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegerv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(int pname, out int data)
        {
            unsafe
            {
                fixed (int* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
                    Delegates.pglGetIntegerv(pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegerv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Get(GetPName pname, out int data)
        {
            unsafe
            {
                fixed (int* p_data = &data)
                {
                    Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
                    Delegates.pglGetIntegerv((int) pname, p_data);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegerv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static unsafe void Get(GetPName pname, [Out] int* data)
        {
            Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
            Delegates.pglGetIntegerv((int) pname, data);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetIntegerv: return the value or values of a selected parameter
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list
        /// below are accepted.
        /// </param>
        /// <param name="data">
        /// Returns the value or values of the specified parameter.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetInteger<T>(GetPName pname, out T data) where T : struct
        {
            Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
            data = default;
            unsafe
            {
                TypedReference refData = __makeref(data);
                IntPtr refDataPtr = *(IntPtr*) (&refData);

                Delegates.pglGetIntegerv((int) pname, (int*) refDataPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetString: return a string describing the current GL connection
        ///     </para>
        /// </summary>
        /// <param name="name">
        /// Specifies a symbolic constant, one of Gl.VENDOR, Gl.RENDERER, Gl.VERSION, or Gl.SHADING_LANGUAGE_VERSION. Additionally,
        /// Gl.GetStringi accepts the Gl.EXTENSIONS token.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static string GetString(StringName name)
        {
            IntPtr retValue;

            Debug.Assert(Delegates.pglGetString != null, "pglGetString not implemented");
            retValue = Delegates.pglGetString((int) name);
            DebugCheckErrors(retValue);

            return NativeHelpers.StringFromPtr(retValue);
        }

        /// <summary>
        /// [GL2.1] glGetTexImage: return a texture image
        /// </summary>
        /// <param name="target">
        /// Specifies which texture is to be obtained. Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="format">
        /// Specifies a pixel format for the returned data. The supported formats are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB,
        /// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies a pixel type for the returned data. The supported types are Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.UNSIGNED_SHORT,
        /// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV,
        /// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV,
        /// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV,
        /// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="pixels">
        /// A <see cref="T:IntPtr" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Debug.Assert(Delegates.pglGetTexImage != null, "pglGetTexImage not implemented");
            Delegates.pglGetTexImage((int) target, level, (int) format, (int) type, pixels);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetTexImage: return a texture image
        /// </summary>
        /// <param name="target">
        /// Specifies which texture is to be obtained. Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="format">
        /// Specifies a pixel format for the returned data. The supported formats are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB,
        /// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
        /// </param>
        /// <param name="type">
        /// Specifies a pixel type for the returned data. The supported types are Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.UNSIGNED_SHORT,
        /// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV,
        /// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV,
        /// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV,
        /// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
        /// </param>
        /// <param name="pixels">
        /// A <see cref="T:object" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, object pixels)
        {
            GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                GetTexImage(target, level, format, type, pin_pixels.AddrOfPinnedObject());
            }
            finally
            {
                pin_pixels.Free();
            }
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterfv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
                    Delegates.pglGetTexParameterfv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterfv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, out float @params)
        {
            unsafe
            {
                fixed (float* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
                    Delegates.pglGetTexParameterfv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterfv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static unsafe void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] float* @params)
        {
            Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
            Delegates.pglGetTexParameterfv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameterfv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetTexParameterf<T>(TextureTarget target, GetTextureParameter pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetTexParameterfv((int)target, (int)pname, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetTexParameterfv((int) target, (int) pname, (float*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameteriv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
                    Delegates.pglGetTexParameteriv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameteriv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
                    Delegates.pglGetTexParameteriv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameteriv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static unsafe void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] int* @params)
        {
            Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
            Delegates.pglGetTexParameteriv((int) target, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexParameteriv: return texture parameter values
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv,
        /// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP,
        /// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        /// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC,
        /// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER,
        /// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R,
        /// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET,
        /// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS,
        /// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the texture parameters.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void GetTexParameteri<T>(TextureTarget target, GetTextureParameter pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetTexParameteriv((int)target, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetTexParameteriv((int) target, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameterfv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
                    Delegates.pglGetTexLevelParameterfv((int) target, level, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameterfv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, out float @params)
        {
            unsafe
            {
                fixed (float* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
                    Delegates.pglGetTexLevelParameterfv((int) target, level, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameterfv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static unsafe void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] float* @params)
        {
            Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
            Delegates.pglGetTexLevelParameterfv((int) target, level, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameterfv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static void GetTexLevelParameterf<T>(TextureTarget target, int level, GetTextureParameter pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetTexLevelParameterfv((int)target, level, (int)pname, (float*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetTexLevelParameterfv((int) target, level, (int) pname, (float*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameteriv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
                    Delegates.pglGetTexLevelParameteriv((int) target, level, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameteriv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, out int @params)
        {
            unsafe
            {
                fixed (int* p_params = &@params)
                {
                    Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
                    Delegates.pglGetTexLevelParameteriv((int) target, level, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameteriv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static unsafe void GetTexLevelParameter(TextureTarget target, int level, GetTextureParameter pname, [Out] int* @params)
        {
            Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
            Delegates.pglGetTexLevelParameteriv((int) target, level, (int) pname, @params);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glGetTexLevelParameteriv: return texture parameter values for a specific level of detail
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv
        /// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY,
        /// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,
        /// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D,
        /// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY,
        /// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,
        /// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
        /// </param>
        /// <param name="level">
        /// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap
        /// reduction image.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH,
        /// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE,
        /// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are
        /// accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
        public static void GetTexLevelParameteri<T>(TextureTarget target, int level, GetTextureParameter pname, out T @params) where T : struct
        {
            Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
            @params = default;
#if NETCOREAPP1_1
			GCHandle valueHandle = GCHandle.Alloc(@params);
			try {
				unsafe {
					Delegates.pglGetTexLevelParameteriv((int)target, level, (int)pname, (int*)valueHandle.AddrOfPinnedObject().ToPointer());
				}
			} finally {
				valueHandle.Free();
			}
#else
            unsafe
            {
                TypedReference refParams = __makeref(@params);
                IntPtr refParamsPtr = *(IntPtr*) (&refParams);

                Delegates.pglGetTexLevelParameteriv((int) target, level, (int) pname, (int*) refParamsPtr.ToPointer());
            }
#endif
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL4|GLES3.2] glIsEnabled: test whether a capability is enabled
        ///     </para>
        /// </summary>
        /// <param name="cap">
        /// Specifies a symbolic constant indicating a GL capability.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static bool IsEnabled(EnableCap cap)
        {
            bool retValue;

            Debug.Assert(Delegates.pglIsEnabled != null, "pglIsEnabled not implemented");
            retValue = Delegates.pglIsEnabled((int) cap);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        /// [GL4] glDepthRange: specify mapping of depth values from normalized device coordinates to window coordinates
        /// </summary>
        /// <param name="nearVal">
        /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
        /// </param>
        /// <param name="farVal">
        /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        public static void DepthRange(double nearVal, double farVal)
        {
            Debug.Assert(Delegates.pglDepthRange != null, "pglDepthRange not implemented");
            Delegates.pglDepthRange(nearVal, farVal);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glViewport: set the viewport
        ///     </para>
        /// </summary>
        /// <param name="x">
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </param>
        /// <param name="y">
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </param>
        /// <param name="width">
        /// Specify the width and height of the viewport. When a GL context is first attached to a window,
        /// <paramref name="width" />
        /// and <paramref name="height" /> are set to the dimensions of that window.
        /// </param>
        /// <param name="height">
        /// Specify the width and height of the viewport. When a GL context is first attached to a window,
        /// <paramref name="width" />
        /// and <paramref name="height" /> are set to the dimensions of that window.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
        [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
        public static void Viewport(int x, int y, int width, int height)
        {
            Debug.Assert(Delegates.pglViewport != null, "pglViewport not implemented");
            Delegates.pglViewport(x, y, width, height);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glNewList: create or replace a display list
        /// </summary>
        /// <param name="list">
        /// Specifies the display-list name.
        /// </param>
        /// <param name="mode">
        /// Specifies the compilation mode, which can be Gl.COMPILE or Gl.COMPILE_AND_EXECUTE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void NewList(uint list, ListMode mode)
        {
            Debug.Assert(Delegates.pglNewList != null, "pglNewList not implemented");
            Delegates.pglNewList(list, (int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEndList: create or replace a display list
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EndList()
        {
            Debug.Assert(Delegates.pglEndList != null, "pglEndList not implemented");
            Delegates.pglEndList();
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glCallList: execute a display list
        /// </summary>
        /// <param name="list">
        /// Specifies the integer name of the display list to be executed.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void CallList(uint list)
        {
            Debug.Assert(Delegates.pglCallList != null, "pglCallList not implemented");
            Delegates.pglCallList(list);
        }

        /// <summary>
        /// [GL2.1] glCallLists: execute a list of display lists
        /// </summary>
        /// <param name="n">
        /// Specifies the number of display lists to be executed.
        /// </param>
        /// <param name="type">
        /// Specifies the type of values in <paramref name="lists" />. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, and Gl.4_BYTES are accepted.
        /// </param>
        /// <param name="lists">
        /// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can
        /// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void CallLists(int n, ListNameType type, IntPtr lists)
        {
            Debug.Assert(Delegates.pglCallLists != null, "pglCallLists not implemented");
            Delegates.pglCallLists(n, (int) type, lists);
        }

        /// <summary>
        /// [GL2.1] glCallLists: execute a list of display lists
        /// </summary>
        /// <param name="n">
        /// Specifies the number of display lists to be executed.
        /// </param>
        /// <param name="type">
        /// Specifies the type of values in <paramref name="lists" />. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT,
        /// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, and Gl.4_BYTES are accepted.
        /// </param>
        /// <param name="lists">
        /// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can
        /// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void CallLists(int n, ListNameType type, object lists)
        {
            GCHandle pin_lists = GCHandle.Alloc(lists, GCHandleType.Pinned);
            try
            {
                CallLists(n, type, pin_lists.AddrOfPinnedObject());
            }
            finally
            {
                pin_lists.Free();
            }
        }

        /// <summary>
        /// [GL2.1] glDeleteLists: delete a contiguous group of display lists
        /// </summary>
        /// <param name="list">
        /// Specifies the integer name of the first display list to delete.
        /// </param>
        /// <param name="range">
        /// Specifies the number of display lists to delete.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void DeleteLists(uint list, int range)
        {
            Debug.Assert(Delegates.pglDeleteLists != null, "pglDeleteLists not implemented");
            Delegates.pglDeleteLists(list, range);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGenLists: generate a contiguous set of empty display lists
        /// </summary>
        /// <param name="range">
        /// Specifies the number of contiguous empty display lists to be generated.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static uint GenLists(int range)
        {
            uint retValue;

            Debug.Assert(Delegates.pglGenLists != null, "pglGenLists not implemented");
            retValue = Delegates.pglGenLists(range);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        /// [GL2.1] glListBase: set the display-list base for glCallLists
        /// </summary>
        /// <param name="base">
        /// Specifies an integer offset that will be added to Gl\.CallLists offsets to generate display-list names. The initial
        /// value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void ListBase(uint @base)
        {
            Debug.Assert(Delegates.pglListBase != null, "pglListBase not implemented");
            Delegates.pglListBase(@base);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glBegin: delimit the vertices of a primitive or a group of like primitives
        /// </summary>
        /// <param name="mode">
        /// Specifies the primitive or primitives that will be created from vertices presented between Gl.Begin and the subsequent
        /// Gl\.End. Ten symbolic constants are accepted: Gl.POINTS, Gl.LINES, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.TRIANGLES,
        /// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.QUADS, Gl.QUAD_STRIP, and Gl.POLYGON.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Begin(PrimitiveType mode)
        {
            Debug.Assert(Delegates.pglBegin != null, "pglBegin not implemented");
            Delegates.pglBegin((int) mode);
        }

        /// <summary>
        /// [GL2.1] glBitmap: draw a bitmap
        /// </summary>
        /// <param name="width">
        /// Specify the pixel width and height of the bitmap image.
        /// </param>
        /// <param name="height">
        /// Specify the pixel width and height of the bitmap image.
        /// </param>
        /// <param name="xorig">
        /// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the
        /// bitmap,
        /// with right and up being the positive axes.
        /// </param>
        /// <param name="yorig">
        /// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the
        /// bitmap,
        /// with right and up being the positive axes.
        /// </param>
        /// <param name="xmove">
        /// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
        /// </param>
        /// <param name="ymove">
        /// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
        /// </param>
        /// <param name="bitmap">
        /// Specifies the address of the bitmap image.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
        {
            unsafe
            {
                fixed (byte* p_bitmap = bitmap)
                {
                    Debug.Assert(Delegates.pglBitmap != null, "pglBitmap not implemented");
                    Delegates.pglBitmap(width, height, xorig, yorig, xmove, ymove, p_bitmap);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3b: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(sbyte red, sbyte green, sbyte blue)
        {
            Debug.Assert(Delegates.pglColor3b != null, "pglColor3b not implemented");
            Delegates.pglColor3b(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3bv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:sbyte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(sbyte[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (sbyte* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3bv != null, "pglColor3bv not implemented");
                    Delegates.pglColor3bv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3d: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(double red, double green, double blue)
        {
            Debug.Assert(Delegates.pglColor3d != null, "pglColor3d not implemented");
            Delegates.pglColor3d(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3dv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3dv != null, "pglColor3dv not implemented");
                    Delegates.pglColor3dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3f: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(float red, float green, float blue)
        {
            Debug.Assert(Delegates.pglColor3f != null, "pglColor3f not implemented");
            Delegates.pglColor3f(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3fv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3fv != null, "pglColor3fv not implemented");
                    Delegates.pglColor3fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3i: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(int red, int green, int blue)
        {
            Debug.Assert(Delegates.pglColor3i != null, "pglColor3i not implemented");
            Delegates.pglColor3i(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3iv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3iv != null, "pglColor3iv not implemented");
                    Delegates.pglColor3iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3s: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(short red, short green, short blue)
        {
            Debug.Assert(Delegates.pglColor3s != null, "pglColor3s not implemented");
            Delegates.pglColor3s(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3sv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3sv != null, "pglColor3sv not implemented");
                    Delegates.pglColor3sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3ub: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(byte red, byte green, byte blue)
        {
            Debug.Assert(Delegates.pglColor3ub != null, "pglColor3ub not implemented");
            Delegates.pglColor3ub(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3ubv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:byte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(byte[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (byte* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3ubv != null, "pglColor3ubv not implemented");
                    Delegates.pglColor3ubv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3ui: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(uint red, uint green, uint blue)
        {
            Debug.Assert(Delegates.pglColor3ui != null, "pglColor3ui not implemented");
            Delegates.pglColor3ui(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3uiv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(uint[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (uint* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3uiv != null, "pglColor3uiv not implemented");
                    Delegates.pglColor3uiv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor3us: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(ushort red, ushort green, ushort blue)
        {
            Debug.Assert(Delegates.pglColor3us != null, "pglColor3us not implemented");
            Delegates.pglColor3us(red, green, blue);
        }

        /// <summary>
        /// [GL2.1] glColor3usv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:ushort[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color3(ushort[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (ushort* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor3usv != null, "pglColor3usv not implemented");
                    Delegates.pglColor3usv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor4b: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha)
        {
            Debug.Assert(Delegates.pglColor4b != null, "pglColor4b not implemented");
            Delegates.pglColor4b(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4bv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:sbyte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(sbyte[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (sbyte* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4bv != null, "pglColor4bv not implemented");
                    Delegates.pglColor4bv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor4d: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(double red, double green, double blue, double alpha)
        {
            Debug.Assert(Delegates.pglColor4d != null, "pglColor4d not implemented");
            Delegates.pglColor4d(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4dv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(double[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4dv != null, "pglColor4dv not implemented");
                    Delegates.pglColor4dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glColor4f: set the current color
        ///     </para>
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(float red, float green, float blue, float alpha)
        {
            Debug.Assert(Delegates.pglColor4f != null, "pglColor4f not implemented");
            Delegates.pglColor4f(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4fv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(float[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4fv != null, "pglColor4fv not implemented");
                    Delegates.pglColor4fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor4i: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(int red, int green, int blue, int alpha)
        {
            Debug.Assert(Delegates.pglColor4i != null, "pglColor4i not implemented");
            Delegates.pglColor4i(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4iv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(int[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4iv != null, "pglColor4iv not implemented");
                    Delegates.pglColor4iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor4s: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(short red, short green, short blue, short alpha)
        {
            Debug.Assert(Delegates.pglColor4s != null, "pglColor4s not implemented");
            Delegates.pglColor4s(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4sv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(short[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4sv != null, "pglColor4sv not implemented");
                    Delegates.pglColor4sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glColor4ub: set the current color
        ///     </para>
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(byte red, byte green, byte blue, byte alpha)
        {
            Debug.Assert(Delegates.pglColor4ub != null, "pglColor4ub not implemented");
            Delegates.pglColor4ub(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4ubv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:byte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(byte[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (byte* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4ubv != null, "pglColor4ubv not implemented");
                    Delegates.pglColor4ubv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor4ui: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(uint red, uint green, uint blue, uint alpha)
        {
            Debug.Assert(Delegates.pglColor4ui != null, "pglColor4ui not implemented");
            Delegates.pglColor4ui(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4uiv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(uint[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (uint* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4uiv != null, "pglColor4uiv not implemented");
                    Delegates.pglColor4uiv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColor4us: set the current color
        /// </summary>
        /// <param name="red">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="green">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="blue">
        /// Specify new red, green, and blue values for the current color.
        /// </param>
        /// <param name="alpha">
        /// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(ushort red, ushort green, ushort blue, ushort alpha)
        {
            Debug.Assert(Delegates.pglColor4us != null, "pglColor4us not implemented");
            Delegates.pglColor4us(red, green, blue, alpha);
        }

        /// <summary>
        /// [GL2.1] glColor4usv: set the current color
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:ushort[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Color4(ushort[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (ushort* p_v = v)
                {
                    Debug.Assert(Delegates.pglColor4usv != null, "pglColor4usv not implemented");
                    Delegates.pglColor4usv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEdgeFlag: flag edges as either boundary or nonboundary
        /// </summary>
        /// <param name="flag">
        /// Specifies the current edge flag value, either Gl.TRUE or Gl.FALSE. The initial value is Gl.TRUE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EdgeFlag(bool flag)
        {
            Debug.Assert(Delegates.pglEdgeFlag != null, "pglEdgeFlag not implemented");
            Delegates.pglEdgeFlag(flag);
        }

        /// <summary>
        /// [GL2.1] glEdgeFlagv: flag edges as either boundary or nonboundary
        /// </summary>
        /// <param name="flag">
        /// Specifies the current edge flag value, either Gl.TRUE or Gl.FALSE. The initial value is Gl.TRUE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EdgeFlag(byte[] flag)
        {
            Debug.Assert(flag.Length >= 1);
            unsafe
            {
                fixed (byte* p_flag = flag)
                {
                    Debug.Assert(Delegates.pglEdgeFlagv != null, "pglEdgeFlagv not implemented");
                    Delegates.pglEdgeFlagv(p_flag);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEnd: delimit the vertices of a primitive or a group of like primitives
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void End()
        {
            Debug.Assert(Delegates.pglEnd != null, "pglEnd not implemented");
            Delegates.pglEnd();
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glIndexd: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(double c)
        {
            Debug.Assert(Delegates.pglIndexd != null, "pglIndexd not implemented");
            Delegates.pglIndexd(c);
        }

        /// <summary>
        /// [GL2.1] glIndexdv: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(double[] c)
        {
            Debug.Assert(c.Length >= 1);
            unsafe
            {
                fixed (double* p_c = c)
                {
                    Debug.Assert(Delegates.pglIndexdv != null, "pglIndexdv not implemented");
                    Delegates.pglIndexdv(p_c);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glIndexf: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(float c)
        {
            Debug.Assert(Delegates.pglIndexf != null, "pglIndexf not implemented");
            Delegates.pglIndexf(c);
        }

        /// <summary>
        /// [GL2.1] glIndexfv: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(float[] c)
        {
            Debug.Assert(c.Length >= 1);
            unsafe
            {
                fixed (float* p_c = c)
                {
                    Debug.Assert(Delegates.pglIndexfv != null, "pglIndexfv not implemented");
                    Delegates.pglIndexfv(p_c);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glIndexi: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(int c)
        {
            Debug.Assert(Delegates.pglIndexi != null, "pglIndexi not implemented");
            Delegates.pglIndexi(c);
        }

        /// <summary>
        /// [GL2.1] glIndexiv: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(int[] c)
        {
            Debug.Assert(c.Length >= 1);
            unsafe
            {
                fixed (int* p_c = c)
                {
                    Debug.Assert(Delegates.pglIndexiv != null, "pglIndexiv not implemented");
                    Delegates.pglIndexiv(p_c);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glIndexs: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(short c)
        {
            Debug.Assert(Delegates.pglIndexs != null, "pglIndexs not implemented");
            Delegates.pglIndexs(c);
        }

        /// <summary>
        /// [GL2.1] glIndexsv: set the current color index
        /// </summary>
        /// <param name="c">
        /// Specifies the new value for the current color index.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Index(short[] c)
        {
            Debug.Assert(c.Length >= 1);
            unsafe
            {
                fixed (short* p_c = c)
                {
                    Debug.Assert(Delegates.pglIndexsv != null, "pglIndexsv not implemented");
                    Delegates.pglIndexsv(p_c);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glNormal3b: set the current normal vector
        /// </summary>
        /// <param name="nx">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="ny">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="nz">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(sbyte nx, sbyte ny, sbyte nz)
        {
            Debug.Assert(Delegates.pglNormal3b != null, "pglNormal3b not implemented");
            Delegates.pglNormal3b(nx, ny, nz);
        }

        /// <summary>
        /// [GL2.1] glNormal3bv: set the current normal vector
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:sbyte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(sbyte[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (sbyte* p_v = v)
                {
                    Debug.Assert(Delegates.pglNormal3bv != null, "pglNormal3bv not implemented");
                    Delegates.pglNormal3bv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glNormal3d: set the current normal vector
        /// </summary>
        /// <param name="nx">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="ny">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="nz">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(double nx, double ny, double nz)
        {
            Debug.Assert(Delegates.pglNormal3d != null, "pglNormal3d not implemented");
            Delegates.pglNormal3d(nx, ny, nz);
        }

        /// <summary>
        /// [GL2.1] glNormal3dv: set the current normal vector
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglNormal3dv != null, "pglNormal3dv not implemented");
                    Delegates.pglNormal3dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glNormal3f: set the current normal vector
        ///     </para>
        /// </summary>
        /// <param name="nx">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="ny">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="nz">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(float nx, float ny, float nz)
        {
            Debug.Assert(Delegates.pglNormal3f != null, "pglNormal3f not implemented");
            Delegates.pglNormal3f(nx, ny, nz);
        }

        /// <summary>
        /// [GL2.1] glNormal3fv: set the current normal vector
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglNormal3fv != null, "pglNormal3fv not implemented");
                    Delegates.pglNormal3fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glNormal3i: set the current normal vector
        /// </summary>
        /// <param name="nx">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="ny">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="nz">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(int nx, int ny, int nz)
        {
            Debug.Assert(Delegates.pglNormal3i != null, "pglNormal3i not implemented");
            Delegates.pglNormal3i(nx, ny, nz);
        }

        /// <summary>
        /// [GL2.1] glNormal3iv: set the current normal vector
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglNormal3iv != null, "pglNormal3iv not implemented");
                    Delegates.pglNormal3iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glNormal3s: set the current normal vector
        /// </summary>
        /// <param name="nx">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="ny">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        /// <param name="nz">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit
        /// vector, (0, 0, 1).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(short nx, short ny, short nz)
        {
            Debug.Assert(Delegates.pglNormal3s != null, "pglNormal3s not implemented");
            Delegates.pglNormal3s(nx, ny, nz);
        }

        /// <summary>
        /// [GL2.1] glNormal3sv: set the current normal vector
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Normal3(short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglNormal3sv != null, "pglNormal3sv not implemented");
                    Delegates.pglNormal3sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2d: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(double x, double y)
        {
            Debug.Assert(Delegates.pglRasterPos2d != null, "pglRasterPos2d not implemented");
            Delegates.pglRasterPos2d(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2dv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(double[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos2dv != null, "pglRasterPos2dv not implemented");
                    Delegates.pglRasterPos2dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2f: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(float x, float y)
        {
            Debug.Assert(Delegates.pglRasterPos2f != null, "pglRasterPos2f not implemented");
            Delegates.pglRasterPos2f(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2fv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(float[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos2fv != null, "pglRasterPos2fv not implemented");
                    Delegates.pglRasterPos2fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2i: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(int x, int y)
        {
            Debug.Assert(Delegates.pglRasterPos2i != null, "pglRasterPos2i not implemented");
            Delegates.pglRasterPos2i(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2iv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(int[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos2iv != null, "pglRasterPos2iv not implemented");
                    Delegates.pglRasterPos2iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2s: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(short x, short y)
        {
            Debug.Assert(Delegates.pglRasterPos2s != null, "pglRasterPos2s not implemented");
            Delegates.pglRasterPos2s(x, y);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos2sv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos2(short[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos2sv != null, "pglRasterPos2sv not implemented");
                    Delegates.pglRasterPos2sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3d: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(double x, double y, double z)
        {
            Debug.Assert(Delegates.pglRasterPos3d != null, "pglRasterPos3d not implemented");
            Delegates.pglRasterPos3d(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3dv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos3dv != null, "pglRasterPos3dv not implemented");
                    Delegates.pglRasterPos3dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3f: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(float x, float y, float z)
        {
            Debug.Assert(Delegates.pglRasterPos3f != null, "pglRasterPos3f not implemented");
            Delegates.pglRasterPos3f(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3fv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos3fv != null, "pglRasterPos3fv not implemented");
                    Delegates.pglRasterPos3fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3i: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(int x, int y, int z)
        {
            Debug.Assert(Delegates.pglRasterPos3i != null, "pglRasterPos3i not implemented");
            Delegates.pglRasterPos3i(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3iv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos3iv != null, "pglRasterPos3iv not implemented");
                    Delegates.pglRasterPos3iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3s: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(short x, short y, short z)
        {
            Debug.Assert(Delegates.pglRasterPos3s != null, "pglRasterPos3s not implemented");
            Delegates.pglRasterPos3s(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos3sv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos3(short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos3sv != null, "pglRasterPos3sv not implemented");
                    Delegates.pglRasterPos3sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4d: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="w">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(double x, double y, double z, double w)
        {
            Debug.Assert(Delegates.pglRasterPos4d != null, "pglRasterPos4d not implemented");
            Delegates.pglRasterPos4d(x, y, z, w);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4dv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(double[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos4dv != null, "pglRasterPos4dv not implemented");
                    Delegates.pglRasterPos4dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4f: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="w">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(float x, float y, float z, float w)
        {
            Debug.Assert(Delegates.pglRasterPos4f != null, "pglRasterPos4f not implemented");
            Delegates.pglRasterPos4f(x, y, z, w);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4fv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(float[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos4fv != null, "pglRasterPos4fv not implemented");
                    Delegates.pglRasterPos4fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4i: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="w">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(int x, int y, int z, int w)
        {
            Debug.Assert(Delegates.pglRasterPos4i != null, "pglRasterPos4i not implemented");
            Delegates.pglRasterPos4i(x, y, z, w);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4iv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(int[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos4iv != null, "pglRasterPos4iv not implemented");
                    Delegates.pglRasterPos4iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4s: specify the raster position for pixel operations
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        /// <param name="w">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(short x, short y, short z, short w)
        {
            Debug.Assert(Delegates.pglRasterPos4s != null, "pglRasterPos4s not implemented");
            Delegates.pglRasterPos4s(x, y, z, w);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRasterPos4sv: specify the raster position for pixel operations
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void RasterPos4(short[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglRasterPos4sv != null, "pglRasterPos4sv not implemented");
                    Delegates.pglRasterPos4sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRectd: draw a rectangle
        /// </summary>
        /// <param name="x1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="y1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="x2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        /// <param name="y2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(double x1, double y1, double x2, double y2)
        {
            Debug.Assert(Delegates.pglRectd != null, "pglRectd not implemented");
            Delegates.pglRectd(x1, y1, x2, y2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRectdv: draw a rectangle
        /// </summary>
        /// <param name="v1">
        /// A <see cref="T:double[]" />.
        /// </param>
        /// <param name="v2">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(double[] v1, double[] v2)
        {
            Debug.Assert(v1.Length >= 2);
            Debug.Assert(v2.Length >= 2);
            unsafe
            {
                fixed (double* p_v1 = v1)
                fixed (double* p_v2 = v2)
                {
                    Debug.Assert(Delegates.pglRectdv != null, "pglRectdv not implemented");
                    Delegates.pglRectdv(p_v1, p_v2);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRectf: draw a rectangle
        /// </summary>
        /// <param name="x1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="y1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="x2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        /// <param name="y2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(float x1, float y1, float x2, float y2)
        {
            Debug.Assert(Delegates.pglRectf != null, "pglRectf not implemented");
            Delegates.pglRectf(x1, y1, x2, y2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRectfv: draw a rectangle
        /// </summary>
        /// <param name="v1">
        /// A <see cref="T:float[]" />.
        /// </param>
        /// <param name="v2">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(float[] v1, float[] v2)
        {
            Debug.Assert(v1.Length >= 2);
            Debug.Assert(v2.Length >= 2);
            unsafe
            {
                fixed (float* p_v1 = v1)
                fixed (float* p_v2 = v2)
                {
                    Debug.Assert(Delegates.pglRectfv != null, "pglRectfv not implemented");
                    Delegates.pglRectfv(p_v1, p_v2);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRecti: draw a rectangle
        /// </summary>
        /// <param name="x1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="y1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="x2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        /// <param name="y2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(int x1, int y1, int x2, int y2)
        {
            Debug.Assert(Delegates.pglRecti != null, "pglRecti not implemented");
            Delegates.pglRecti(x1, y1, x2, y2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRectiv: draw a rectangle
        /// </summary>
        /// <param name="v1">
        /// A <see cref="T:int[]" />.
        /// </param>
        /// <param name="v2">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(int[] v1, int[] v2)
        {
            Debug.Assert(v1.Length >= 2);
            Debug.Assert(v2.Length >= 2);
            unsafe
            {
                fixed (int* p_v1 = v1)
                fixed (int* p_v2 = v2)
                {
                    Debug.Assert(Delegates.pglRectiv != null, "pglRectiv not implemented");
                    Delegates.pglRectiv(p_v1, p_v2);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRects: draw a rectangle
        /// </summary>
        /// <param name="x1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="y1">
        /// Specify one vertex of a rectangle.
        /// </param>
        /// <param name="x2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        /// <param name="y2">
        /// Specify the opposite vertex of the rectangle.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(short x1, short y1, short x2, short y2)
        {
            Debug.Assert(Delegates.pglRects != null, "pglRects not implemented");
            Delegates.pglRects(x1, y1, x2, y2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRectsv: draw a rectangle
        /// </summary>
        /// <param name="v1">
        /// A <see cref="T:short[]" />.
        /// </param>
        /// <param name="v2">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rect(short[] v1, short[] v2)
        {
            Debug.Assert(v1.Length >= 2);
            Debug.Assert(v2.Length >= 2);
            unsafe
            {
                fixed (short* p_v1 = v1)
                fixed (short* p_v2 = v2)
                {
                    Debug.Assert(Delegates.pglRectsv != null, "pglRectsv not implemented");
                    Delegates.pglRectsv(p_v1, p_v2);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1d: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(double s)
        {
            Debug.Assert(Delegates.pglTexCoord1d != null, "pglTexCoord1d not implemented");
            Delegates.pglTexCoord1d(s);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1dv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(double[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord1dv != null, "pglTexCoord1dv not implemented");
                    Delegates.pglTexCoord1dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1f: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(float s)
        {
            Debug.Assert(Delegates.pglTexCoord1f != null, "pglTexCoord1f not implemented");
            Delegates.pglTexCoord1f(s);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1fv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(float[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord1fv != null, "pglTexCoord1fv not implemented");
                    Delegates.pglTexCoord1fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1i: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(int s)
        {
            Debug.Assert(Delegates.pglTexCoord1i != null, "pglTexCoord1i not implemented");
            Delegates.pglTexCoord1i(s);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1iv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(int[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord1iv != null, "pglTexCoord1iv not implemented");
                    Delegates.pglTexCoord1iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1s: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(short s)
        {
            Debug.Assert(Delegates.pglTexCoord1s != null, "pglTexCoord1s not implemented");
            Delegates.pglTexCoord1s(s);
        }

        /// <summary>
        /// [GL2.1] glTexCoord1sv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord1(short[] v)
        {
            Debug.Assert(v.Length >= 1);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord1sv != null, "pglTexCoord1sv not implemented");
                    Delegates.pglTexCoord1sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2d: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(double s, double t)
        {
            Debug.Assert(Delegates.pglTexCoord2d != null, "pglTexCoord2d not implemented");
            Delegates.pglTexCoord2d(s, t);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2dv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(double[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord2dv != null, "pglTexCoord2dv not implemented");
                    Delegates.pglTexCoord2dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2f: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(float s, float t)
        {
            Debug.Assert(Delegates.pglTexCoord2f != null, "pglTexCoord2f not implemented");
            Delegates.pglTexCoord2f(s, t);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2fv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(float[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord2fv != null, "pglTexCoord2fv not implemented");
                    Delegates.pglTexCoord2fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2i: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(int s, int t)
        {
            Debug.Assert(Delegates.pglTexCoord2i != null, "pglTexCoord2i not implemented");
            Delegates.pglTexCoord2i(s, t);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2iv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(int[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord2iv != null, "pglTexCoord2iv not implemented");
                    Delegates.pglTexCoord2iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2s: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(short s, short t)
        {
            Debug.Assert(Delegates.pglTexCoord2s != null, "pglTexCoord2s not implemented");
            Delegates.pglTexCoord2s(s, t);
        }

        /// <summary>
        /// [GL2.1] glTexCoord2sv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord2(short[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord2sv != null, "pglTexCoord2sv not implemented");
                    Delegates.pglTexCoord2sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3d: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(double s, double t, double r)
        {
            Debug.Assert(Delegates.pglTexCoord3d != null, "pglTexCoord3d not implemented");
            Delegates.pglTexCoord3d(s, t, r);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3dv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord3dv != null, "pglTexCoord3dv not implemented");
                    Delegates.pglTexCoord3dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3f: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(float s, float t, float r)
        {
            Debug.Assert(Delegates.pglTexCoord3f != null, "pglTexCoord3f not implemented");
            Delegates.pglTexCoord3f(s, t, r);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3fv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord3fv != null, "pglTexCoord3fv not implemented");
                    Delegates.pglTexCoord3fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3i: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(int s, int t, int r)
        {
            Debug.Assert(Delegates.pglTexCoord3i != null, "pglTexCoord3i not implemented");
            Delegates.pglTexCoord3i(s, t, r);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3iv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord3iv != null, "pglTexCoord3iv not implemented");
                    Delegates.pglTexCoord3iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3s: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(short s, short t, short r)
        {
            Debug.Assert(Delegates.pglTexCoord3s != null, "pglTexCoord3s not implemented");
            Delegates.pglTexCoord3s(s, t, r);
        }

        /// <summary>
        /// [GL2.1] glTexCoord3sv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord3(short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord3sv != null, "pglTexCoord3sv not implemented");
                    Delegates.pglTexCoord3sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4d: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(double s, double t, double r, double q)
        {
            Debug.Assert(Delegates.pglTexCoord4d != null, "pglTexCoord4d not implemented");
            Delegates.pglTexCoord4d(s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4dv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(double[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord4dv != null, "pglTexCoord4dv not implemented");
                    Delegates.pglTexCoord4dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4f: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(float s, float t, float r, float q)
        {
            Debug.Assert(Delegates.pglTexCoord4f != null, "pglTexCoord4f not implemented");
            Delegates.pglTexCoord4f(s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4fv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(float[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord4fv != null, "pglTexCoord4fv not implemented");
                    Delegates.pglTexCoord4fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4i: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(int s, int t, int r, int q)
        {
            Debug.Assert(Delegates.pglTexCoord4i != null, "pglTexCoord4i not implemented");
            Delegates.pglTexCoord4i(s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4iv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(int[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord4iv != null, "pglTexCoord4iv not implemented");
                    Delegates.pglTexCoord4iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4s: set the current texture coordinates
        /// </summary>
        /// <param name="s">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="t">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="r">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="q">
        /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(short s, short t, short r, short q)
        {
            Debug.Assert(Delegates.pglTexCoord4s != null, "pglTexCoord4s not implemented");
            Delegates.pglTexCoord4s(s, t, r, q);
        }

        /// <summary>
        /// [GL2.1] glTexCoord4sv: set the current texture coordinates
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexCoord4(short[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglTexCoord4sv != null, "pglTexCoord4sv not implemented");
                    Delegates.pglTexCoord4sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex2d: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(double x, double y)
        {
            Debug.Assert(Delegates.pglVertex2d != null, "pglVertex2d not implemented");
            Delegates.pglVertex2d(x, y);
        }

        /// <summary>
        /// [GL2.1] glVertex2dv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(double[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex2dv != null, "pglVertex2dv not implemented");
                    Delegates.pglVertex2dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex2f: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(float x, float y)
        {
            Debug.Assert(Delegates.pglVertex2f != null, "pglVertex2f not implemented");
            Delegates.pglVertex2f(x, y);
        }

        /// <summary>
        /// [GL2.1] glVertex2fv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(float[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex2fv != null, "pglVertex2fv not implemented");
                    Delegates.pglVertex2fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex2i: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(int x, int y)
        {
            Debug.Assert(Delegates.pglVertex2i != null, "pglVertex2i not implemented");
            Delegates.pglVertex2i(x, y);
        }

        /// <summary>
        /// [GL2.1] glVertex2iv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(int[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex2iv != null, "pglVertex2iv not implemented");
                    Delegates.pglVertex2iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex2s: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(short x, short y)
        {
            Debug.Assert(Delegates.pglVertex2s != null, "pglVertex2s not implemented");
            Delegates.pglVertex2s(x, y);
        }

        /// <summary>
        /// [GL2.1] glVertex2sv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex2(short[] v)
        {
            Debug.Assert(v.Length >= 2);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex2sv != null, "pglVertex2sv not implemented");
                    Delegates.pglVertex2sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex3d: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(double x, double y, double z)
        {
            Debug.Assert(Delegates.pglVertex3d != null, "pglVertex3d not implemented");
            Delegates.pglVertex3d(x, y, z);
        }

        /// <summary>
        /// [GL2.1] glVertex3dv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(double[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex3dv != null, "pglVertex3dv not implemented");
                    Delegates.pglVertex3dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex3f: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(float x, float y, float z)
        {
            Debug.Assert(Delegates.pglVertex3f != null, "pglVertex3f not implemented");
            Delegates.pglVertex3f(x, y, z);
        }

        /// <summary>
        /// [GL2.1] glVertex3fv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(float[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex3fv != null, "pglVertex3fv not implemented");
                    Delegates.pglVertex3fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex3i: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(int x, int y, int z)
        {
            Debug.Assert(Delegates.pglVertex3i != null, "pglVertex3i not implemented");
            Delegates.pglVertex3i(x, y, z);
        }

        /// <summary>
        /// [GL2.1] glVertex3iv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(int[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex3iv != null, "pglVertex3iv not implemented");
                    Delegates.pglVertex3iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex3s: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(short x, short y, short z)
        {
            Debug.Assert(Delegates.pglVertex3s != null, "pglVertex3s not implemented");
            Delegates.pglVertex3s(x, y, z);
        }

        /// <summary>
        /// [GL2.1] glVertex3sv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex3(short[] v)
        {
            Debug.Assert(v.Length >= 3);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex3sv != null, "pglVertex3sv not implemented");
                    Delegates.pglVertex3sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex4d: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="w">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(double x, double y, double z, double w)
        {
            Debug.Assert(Delegates.pglVertex4d != null, "pglVertex4d not implemented");
            Delegates.pglVertex4d(x, y, z, w);
        }

        /// <summary>
        /// [GL2.1] glVertex4dv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(double[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex4dv != null, "pglVertex4dv not implemented");
                    Delegates.pglVertex4dv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex4f: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="w">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(float x, float y, float z, float w)
        {
            Debug.Assert(Delegates.pglVertex4f != null, "pglVertex4f not implemented");
            Delegates.pglVertex4f(x, y, z, w);
        }

        /// <summary>
        /// [GL2.1] glVertex4fv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(float[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex4fv != null, "pglVertex4fv not implemented");
                    Delegates.pglVertex4fv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex4i: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="w">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(int x, int y, int z, int w)
        {
            Debug.Assert(Delegates.pglVertex4i != null, "pglVertex4i not implemented");
            Delegates.pglVertex4i(x, y, z, w);
        }

        /// <summary>
        /// [GL2.1] glVertex4iv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(int[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex4iv != null, "pglVertex4iv not implemented");
                    Delegates.pglVertex4iv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glVertex4s: specify a vertex
        /// </summary>
        /// <param name="x">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="y">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="z">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        /// <param name="w">
        /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(short x, short y, short z, short w)
        {
            Debug.Assert(Delegates.pglVertex4s != null, "pglVertex4s not implemented");
            Delegates.pglVertex4s(x, y, z, w);
        }

        /// <summary>
        /// [GL2.1] glVertex4sv: specify a vertex
        /// </summary>
        /// <param name="v">
        /// A <see cref="T:short[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Vertex4(short[] v)
        {
            Debug.Assert(v.Length >= 4);
            unsafe
            {
                fixed (short* p_v = v)
                {
                    Debug.Assert(Delegates.pglVertex4sv != null, "pglVertex4sv not implemented");
                    Delegates.pglVertex4sv(p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glClipPlane: specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="plane">
        /// Specifies which clipping plane is being positioned. Symbolic names of the form Gl.CLIP_PLANEi, where i is an integer
        /// between 0 and Gl.MAX_CLIP_PLANES-1, are accepted.
        /// </param>
        /// <param name="equation">
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a
        /// plane equation.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void ClipPlane(ClipPlaneName plane, double[] equation)
        {
            Debug.Assert(equation.Length >= 4);
            unsafe
            {
                fixed (double* p_equation = equation)
                {
                    Debug.Assert(Delegates.pglClipPlane != null, "pglClipPlane not implemented");
                    Delegates.pglClipPlane((int) plane, p_equation);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glColorMaterial: cause a material color to track the current color
        /// </summary>
        /// <param name="face">
        /// Specifies whether front, back, or both front and back material parameters should track the current color. Accepted
        /// values are Gl.FRONT, Gl.BACK, and Gl.FRONT_AND_BACK. The initial value is Gl.FRONT_AND_BACK.
        /// </param>
        /// <param name="mode">
        /// Specifies which of several material parameters track the current color. Accepted values are Gl.EMISSION, Gl.AMBIENT,
        /// Gl.DIFFUSE, Gl.SPECULAR, and Gl.AMBIENT_AND_DIFFUSE. The initial value is Gl.AMBIENT_AND_DIFFUSE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
        {
            Debug.Assert(Delegates.pglColorMaterial != null, "pglColorMaterial not implemented");
            Delegates.pglColorMaterial((int) face, (int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glFogf: specify fog parameters
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and
        /// Gl.FOG_COORD_SRC are accepted.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="pname" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Fog(FogParameter pname, float param)
        {
            Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
            Delegates.pglFogf((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glFogfv: specify fog parameters
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and
        /// Gl.FOG_COORD_SRC are accepted.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Fog(FogParameter pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
                    Delegates.pglFogfv((int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFogi: specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and
        /// Gl.FOG_COORD_SRC are accepted.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="pname" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Fog(FogParameter pname, int param)
        {
            Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
            Delegates.pglFogi((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFogiv: specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and
        /// Gl.FOG_COORD_SRC are accepted.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Fog(FogParameter pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
                    Delegates.pglFogiv((int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLightf: set light source parameters
        ///     </para>
        /// </summary>
        /// <param name="light">
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They
        /// are
        /// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a single-valued light source parameter for <paramref name="light" />. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF,
        /// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
        /// </param>
        /// <param name="param">
        /// Specifies the value that parameter <paramref name="pname" /> of light source <paramref name="light" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Light(LightName light, LightParameter pname, float param)
        {
            Debug.Assert(Delegates.pglLightf != null, "pglLightf not implemented");
            Delegates.pglLightf((int) light, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLightfv: set light source parameters
        ///     </para>
        /// </summary>
        /// <param name="light">
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They
        /// are
        /// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a single-valued light source parameter for <paramref name="light" />. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF,
        /// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Light(LightName light, LightParameter pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglLightfv != null, "pglLightfv not implemented");
                    Delegates.pglLightfv((int) light, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLighti: set light source parameters
        /// </summary>
        /// <param name="light">
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They
        /// are
        /// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a single-valued light source parameter for <paramref name="light" />. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF,
        /// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
        /// </param>
        /// <param name="param">
        /// Specifies the value that parameter <paramref name="pname" /> of light source <paramref name="light" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Light(LightName light, LightParameter pname, int param)
        {
            Debug.Assert(Delegates.pglLighti != null, "pglLighti not implemented");
            Delegates.pglLighti((int) light, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLightiv: set light source parameters
        /// </summary>
        /// <param name="light">
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They
        /// are
        /// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a single-valued light source parameter for <paramref name="light" />. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF,
        /// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Light(LightName light, LightParameter pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglLightiv != null, "pglLightiv not implemented");
                    Delegates.pglLightiv((int) light, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLightModelf: set the lighting model parameters
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and
        /// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="param" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LightModel(LightModelParameter pname, float param)
        {
            Debug.Assert(Delegates.pglLightModelf != null, "pglLightModelf not implemented");
            Delegates.pglLightModelf((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLightModelfv: set the lighting model parameters
        ///     </para>
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and
        /// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LightModel(LightModelParameter pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglLightModelfv != null, "pglLightModelfv not implemented");
                    Delegates.pglLightModelfv((int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLightModeli: set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and
        /// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="param" /> will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LightModel(LightModelParameter pname, int param)
        {
            Debug.Assert(Delegates.pglLightModeli != null, "pglLightModeli not implemented");
            Delegates.pglLightModeli((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLightModeliv: set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and
        /// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LightModel(LightModelParameter pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglLightModeliv != null, "pglLightModeliv not implemented");
                    Delegates.pglLightModeliv((int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLineStipple: specify the line stipple pattern
        /// </summary>
        /// <param name="factor">
        /// Specifies a multiplier for each bit in the line stipple pattern. If <paramref name="factor" /> is 3, for example, each
        /// bit in the pattern is used three times before the next bit in the pattern is used. <paramref name="factor" /> is
        /// clamped
        /// to the range [1, 256] and defaults to 1.
        /// </param>
        /// <param name="pattern">
        /// Specifies a 16-bit integer whose bit pattern determines which fragments of a line will be drawn when the line is
        /// rasterized. Bit zero is used first; the default pattern is all 1's.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LineStipple(int factor, ushort pattern)
        {
            Debug.Assert(Delegates.pglLineStipple != null, "pglLineStipple not implemented");
            Delegates.pglLineStipple(factor, pattern);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glMaterialf: specify material parameters for the lighting model
        ///     </para>
        /// </summary>
        /// <param name="face">
        /// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
        /// </param>
        /// <param name="pname">
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
        /// </param>
        /// <param name="param">
        /// Specifies the value that parameter Gl.SHININESS will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Material(MaterialFace face, MaterialParameter pname, float param)
        {
            Debug.Assert(Delegates.pglMaterialf != null, "pglMaterialf not implemented");
            Delegates.pglMaterialf((int) face, (int) pname, param);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glMaterialfv: specify material parameters for the lighting model
        ///     </para>
        /// </summary>
        /// <param name="face">
        /// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
        /// </param>
        /// <param name="pname">
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Material(MaterialFace face, MaterialParameter pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglMaterialfv != null, "pglMaterialfv not implemented");
                    Delegates.pglMaterialfv((int) face, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMateriali: specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
        /// </param>
        /// <param name="pname">
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
        /// </param>
        /// <param name="param">
        /// Specifies the value that parameter Gl.SHININESS will be set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Material(MaterialFace face, MaterialParameter pname, int param)
        {
            Debug.Assert(Delegates.pglMateriali != null, "pglMateriali not implemented");
            Delegates.pglMateriali((int) face, (int) pname, param);
        }

        /// <summary>
        /// [GL2.1] glMaterialiv: specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
        /// </param>
        /// <param name="pname">
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Material(MaterialFace face, MaterialParameter pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglMaterialiv != null, "pglMaterialiv not implemented");
                    Delegates.pglMaterialiv((int) face, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPolygonStipple: set the polygon stippling pattern
        /// </summary>
        /// <param name="mask">
        /// A <see cref="T:byte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PolygonStipple(byte[] mask)
        {
            unsafe
            {
                fixed (byte* p_mask = mask)
                {
                    Debug.Assert(Delegates.pglPolygonStipple != null, "pglPolygonStipple not implemented");
                    Delegates.pglPolygonStipple(p_mask);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glShadeModel: select flat or smooth shading
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies a symbolic value representing a shading technique. Accepted values are Gl.FLAT and Gl.SMOOTH. The initial
        /// value is Gl.SMOOTH.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void ShadeModel(ShadingModel mode)
        {
            Debug.Assert(Delegates.pglShadeModel != null, "pglShadeModel not implemented");
            Delegates.pglShadeModel((int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexEnvf: set texture environment parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE,
        /// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA,
        /// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA,
        /// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
        /// </param>
        /// <param name="param">
        /// Specifies a single symbolic constant, one of Gl.ADD, Gl.ADD_SIGNED, Gl.INTERPOLATE, Gl.MODULATE, Gl.DECAL, Gl.BLEND,
        /// Gl.REPLACE, Gl.SUBTRACT, Gl.COMBINE, Gl.TEXTURE, Gl.CONSTANT, Gl.PRIMARY_COLOR, Gl.PREVIOUS, Gl.SRC_COLOR,
        /// Gl.ONE_MINUS_SRC_COLOR, Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture
        /// coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when
        /// specifying the Gl.RGB_SCALE or Gl.ALPHA_SCALE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float param)
        {
            Debug.Assert(Delegates.pglTexEnvf != null, "pglTexEnvf not implemented");
            Delegates.pglTexEnvf((int) target, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexEnvfv: set texture environment parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE,
        /// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA,
        /// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA,
        /// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglTexEnvfv != null, "pglTexEnvfv not implemented");
                    Delegates.pglTexEnvfv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexEnvi: set texture environment parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE,
        /// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA,
        /// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA,
        /// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
        /// </param>
        /// <param name="param">
        /// Specifies a single symbolic constant, one of Gl.ADD, Gl.ADD_SIGNED, Gl.INTERPOLATE, Gl.MODULATE, Gl.DECAL, Gl.BLEND,
        /// Gl.REPLACE, Gl.SUBTRACT, Gl.COMBINE, Gl.TEXTURE, Gl.CONSTANT, Gl.PRIMARY_COLOR, Gl.PREVIOUS, Gl.SRC_COLOR,
        /// Gl.ONE_MINUS_SRC_COLOR, Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture
        /// coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when
        /// specifying the Gl.RGB_SCALE or Gl.ALPHA_SCALE.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, int param)
        {
            Debug.Assert(Delegates.pglTexEnvi != null, "pglTexEnvi not implemented");
            Delegates.pglTexEnvi((int) target, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTexEnviv: set texture environment parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE,
        /// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA,
        /// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA,
        /// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglTexEnviv != null, "pglTexEnviv not implemented");
                    Delegates.pglTexEnviv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexGend: control the generation of texture coordinates
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
        /// </param>
        /// <param name="param">
        /// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP,
        /// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double param)
        {
            Debug.Assert(Delegates.pglTexGend != null, "pglTexGend not implemented");
            Delegates.pglTexGend((int) coord, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexGendv: control the generation of texture coordinates
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:double[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
        {
            unsafe
            {
                fixed (double* p_params = @params)
                {
                    Debug.Assert(Delegates.pglTexGendv != null, "pglTexGendv not implemented");
                    Delegates.pglTexGendv((int) coord, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexGenf: control the generation of texture coordinates
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
        /// </param>
        /// <param name="param">
        /// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP,
        /// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float param)
        {
            Debug.Assert(Delegates.pglTexGenf != null, "pglTexGenf not implemented");
            Delegates.pglTexGenf((int) coord, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexGenfv: control the generation of texture coordinates
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglTexGenfv != null, "pglTexGenfv not implemented");
                    Delegates.pglTexGenfv((int) coord, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexGeni: control the generation of texture coordinates
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
        /// </param>
        /// <param name="param">
        /// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP,
        /// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexGen(TextureCoordName coord, TextureGenParameter pname, int param)
        {
            Debug.Assert(Delegates.pglTexGeni != null, "pglTexGeni not implemented");
            Delegates.pglTexGeni((int) coord, (int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTexGeniv: control the generation of texture coordinates
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
        /// </param>
        /// <param name="params">
        /// A <see cref="T:int[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void TexGen(TextureCoordName coord, TextureGenParameter pname, int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglTexGeniv != null, "pglTexGeniv not implemented");
                    Delegates.pglTexGeniv((int) coord, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFeedbackBuffer: controls feedback mode
        /// </summary>
        /// <param name="size">
        /// Specifies the maximum number of values that can be written into <paramref name="buffer" />.
        /// </param>
        /// <param name="type">
        /// Specifies a symbolic constant that describes the information that will be returned for each vertex. Gl.2D, Gl.3D,
        /// Gl.3D_COLOR, Gl.3D_COLOR_TEXTURE, and Gl.4D_COLOR_TEXTURE are accepted.
        /// </param>
        /// <param name="buffer">
        /// Returns the feedback data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FeedbackBuffer(int size, FeedbackType type, params float[] buffer)
        {
            unsafe
            {
                fixed (float* p_buffer = buffer)
                {
                    Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
                    Delegates.pglFeedbackBuffer(size, (int) type, p_buffer);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glFeedbackBuffer: controls feedback mode
        /// </summary>
        /// <param name="type">
        /// Specifies a symbolic constant that describes the information that will be returned for each vertex. Gl.2D, Gl.3D,
        /// Gl.3D_COLOR, Gl.3D_COLOR_TEXTURE, and Gl.4D_COLOR_TEXTURE are accepted.
        /// </param>
        /// <param name="buffer">
        /// Returns the feedback data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void FeedbackBuffer(FeedbackType type, params float[] buffer)
        {
            unsafe
            {
                fixed (float* p_buffer = buffer)
                {
                    Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
                    Delegates.pglFeedbackBuffer(buffer.Length, (int) type, p_buffer);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glSelectBuffer: establish a buffer for selection mode values
        /// </summary>
        /// <param name="buffer">
        /// Returns the selection data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void SelectBuffer(params uint[] buffer)
        {
            unsafe
            {
                fixed (uint* p_buffer = buffer)
                {
                    Debug.Assert(Delegates.pglSelectBuffer != null, "pglSelectBuffer not implemented");
                    Delegates.pglSelectBuffer(buffer.Length, p_buffer);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRenderMode: set rasterization mode
        /// </summary>
        /// <param name="mode">
        /// Specifies the rasterization mode. Three values are accepted: Gl.RENDER, Gl.SELECT, and Gl.FEEDBACK. The initial value
        /// is
        /// Gl.RENDER.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static int RenderMode(RenderingMode mode)
        {
            int retValue;

            Debug.Assert(Delegates.pglRenderMode != null, "pglRenderMode not implemented");
            retValue = Delegates.pglRenderMode((int) mode);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        /// [GL2.1] glInitNames: initialize the name stack
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void InitName()
        {
            Debug.Assert(Delegates.pglInitNames != null, "pglInitNames not implemented");
            Delegates.pglInitNames();
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadName: load a name onto the name stack
        /// </summary>
        /// <param name="name">
        /// Specifies a name that will replace the top value on the name stack.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadName(uint name)
        {
            Debug.Assert(Delegates.pglLoadName != null, "pglLoadName not implemented");
            Delegates.pglLoadName(name);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPassThrough: place a marker in the feedback buffer
        /// </summary>
        /// <param name="token">
        /// Specifies a marker value to be placed in the feedback buffer following a Gl.PASS_THROUGH_TOKEN.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PassThrough(float token)
        {
            Debug.Assert(Delegates.pglPassThrough != null, "pglPassThrough not implemented");
            Delegates.pglPassThrough(token);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPopName: push and pop the name stack
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PopName()
        {
            Debug.Assert(Delegates.pglPopName != null, "pglPopName not implemented");
            Delegates.pglPopName();
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPushName: push and pop the name stack
        /// </summary>
        /// <param name="name">
        /// Specifies a name that will be pushed onto the name stack.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PushName(uint name)
        {
            Debug.Assert(Delegates.pglPushName != null, "pglPushName not implemented");
            Delegates.pglPushName(name);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glClearAccum: specify clear values for the accumulation buffer
        /// </summary>
        /// <param name="red">
        /// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all
        /// 0.
        /// </param>
        /// <param name="green">
        /// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all
        /// 0.
        /// </param>
        /// <param name="blue">
        /// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all
        /// 0.
        /// </param>
        /// <param name="alpha">
        /// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all
        /// 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void ClearAccum(float red, float green, float blue, float alpha)
        {
            Debug.Assert(Delegates.pglClearAccum != null, "pglClearAccum not implemented");
            Delegates.pglClearAccum(red, green, blue, alpha);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glClearIndex: specify the clear value for the color index buffers
        /// </summary>
        /// <param name="c">
        /// Specifies the index used when the color index buffers are cleared. The initial value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void ClearIndex(float c)
        {
            Debug.Assert(Delegates.pglClearIndex != null, "pglClearIndex not implemented");
            Delegates.pglClearIndex(c);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glIndexMask: control the writing of individual bits in the color index buffers
        /// </summary>
        /// <param name="mask">
        /// Specifies a bit mask to enable and disable the writing of individual bits in the color index buffers. Initially, the
        /// mask is all 1's.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void IndexMask(uint mask)
        {
            Debug.Assert(Delegates.pglIndexMask != null, "pglIndexMask not implemented");
            Delegates.pglIndexMask(mask);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glAccum: operate on the accumulation buffer
        /// </summary>
        /// <param name="op">
        /// Specifies the accumulation buffer operation. Symbolic constants Gl.ACCUM, Gl.LOAD, Gl.ADD, Gl.MULT, and Gl.RETURN are
        /// accepted.
        /// </param>
        /// <param name="value">
        /// Specifies a floating-point value used in the accumulation buffer operation. <paramref name="op" /> determines how
        /// <paramref name="value" /> is used.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Accum(AccumOp op, float value)
        {
            Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
            Delegates.pglAccum((int) op, value);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPopAttrib: push and pop the server attribute stack
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PopAttrib()
        {
            Debug.Assert(Delegates.pglPopAttrib != null, "pglPopAttrib not implemented");
            Delegates.pglPopAttrib();
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPushAttrib: push and pop the server attribute stack
        /// </summary>
        /// <param name="mask">
        /// Specifies a mask that indicates which attributes to save. Values for <paramref name="mask" /> are listed below.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PushAttrib(AttribMask mask)
        {
            Debug.Assert(Delegates.pglPushAttrib != null, "pglPushAttrib not implemented");
            Delegates.pglPushAttrib((uint) mask);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMap1d: define a one-dimensional evaluator
        /// </summary>
        /// <param name="target">
        /// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP1_VERTEX_3,
        /// Gl.MAP1_VERTEX_4,
        /// Gl.MAP1_INDEX, Gl.MAP1_COLOR_4, Gl.MAP1_NORMAL, Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2,
        /// Gl.MAP1_TEXTURE_COORD_3, and Gl.MAP1_TEXTURE_COORD_4 are accepted.
        /// </param>
        /// <param name="u1">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations
        /// specified by this command.
        /// </param>
        /// <param name="u2">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations
        /// specified by this command.
        /// </param>
        /// <param name="stride">
        /// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one
        /// in the data structure referenced in <paramref name="points" />. This allows control points to be embedded in arbitrary
        /// data structures. The only constraint is that the values for a particular control point must occupy contiguous memory
        /// locations.
        /// </param>
        /// <param name="order">
        /// Specifies the number of control points. Must be positive.
        /// </param>
        /// <param name="points">
        /// Specifies a pointer to the array of control points.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Map1(MapTarget target, double u1, double u2, int stride, int order, double[] points)
        {
            unsafe
            {
                fixed (double* p_points = points)
                {
                    Debug.Assert(Delegates.pglMap1d != null, "pglMap1d not implemented");
                    Delegates.pglMap1d((int) target, u1, u2, stride, order, p_points);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMap1f: define a one-dimensional evaluator
        /// </summary>
        /// <param name="target">
        /// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP1_VERTEX_3,
        /// Gl.MAP1_VERTEX_4,
        /// Gl.MAP1_INDEX, Gl.MAP1_COLOR_4, Gl.MAP1_NORMAL, Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2,
        /// Gl.MAP1_TEXTURE_COORD_3, and Gl.MAP1_TEXTURE_COORD_4 are accepted.
        /// </param>
        /// <param name="u1">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations
        /// specified by this command.
        /// </param>
        /// <param name="u2">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations
        /// specified by this command.
        /// </param>
        /// <param name="stride">
        /// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one
        /// in the data structure referenced in <paramref name="points" />. This allows control points to be embedded in arbitrary
        /// data structures. The only constraint is that the values for a particular control point must occupy contiguous memory
        /// locations.
        /// </param>
        /// <param name="order">
        /// Specifies the number of control points. Must be positive.
        /// </param>
        /// <param name="points">
        /// Specifies a pointer to the array of control points.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Map1(MapTarget target, float u1, float u2, int stride, int order, float[] points)
        {
            unsafe
            {
                fixed (float* p_points = points)
                {
                    Debug.Assert(Delegates.pglMap1f != null, "pglMap1f not implemented");
                    Delegates.pglMap1f((int) target, u1, u2, stride, order, p_points);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMap2d: define a two-dimensional evaluator
        /// </summary>
        /// <param name="target">
        /// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP2_VERTEX_3,
        /// Gl.MAP2_VERTEX_4,
        /// Gl.MAP2_INDEX, Gl.MAP2_COLOR_4, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2,
        /// Gl.MAP2_TEXTURE_COORD_3, and Gl.MAP2_TEXTURE_COORD_4 are accepted.
        /// </param>
        /// <param name="u1">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="u1" /> is 0 and <paramref name="u2" /> is 1.
        /// </param>
        /// <param name="u2">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="u1" /> is 0 and <paramref name="u2" /> is 1.
        /// </param>
        /// <param name="ustride">
        /// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point
        /// Ri+1⁢j, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in
        /// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous
        /// memory locations. The initial value of <paramref name="ustride" /> is 0.
        /// </param>
        /// <param name="uorder">
        /// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1.
        /// </param>
        /// <param name="v1">
        /// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="v1" /> is 0 and <paramref name="v2" /> is 1.
        /// </param>
        /// <param name="v2">
        /// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="v1" /> is 0 and <paramref name="v2" /> is 1.
        /// </param>
        /// <param name="vstride">
        /// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point
        /// Ri⁡j+1, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in
        /// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous
        /// memory locations. The initial value of <paramref name="vstride" /> is 0.
        /// </param>
        /// <param name="vorder">
        /// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1.
        /// </param>
        /// <param name="points">
        /// Specifies a pointer to the array of control points.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Map2(MapTarget target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points)
        {
            unsafe
            {
                fixed (double* p_points = points)
                {
                    Debug.Assert(Delegates.pglMap2d != null, "pglMap2d not implemented");
                    Delegates.pglMap2d((int) target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMap2f: define a two-dimensional evaluator
        /// </summary>
        /// <param name="target">
        /// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP2_VERTEX_3,
        /// Gl.MAP2_VERTEX_4,
        /// Gl.MAP2_INDEX, Gl.MAP2_COLOR_4, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2,
        /// Gl.MAP2_TEXTURE_COORD_3, and Gl.MAP2_TEXTURE_COORD_4 are accepted.
        /// </param>
        /// <param name="u1">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="u1" /> is 0 and <paramref name="u2" /> is 1.
        /// </param>
        /// <param name="u2">
        /// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="u1" /> is 0 and <paramref name="u2" /> is 1.
        /// </param>
        /// <param name="ustride">
        /// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point
        /// Ri+1⁢j, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in
        /// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous
        /// memory locations. The initial value of <paramref name="ustride" /> is 0.
        /// </param>
        /// <param name="uorder">
        /// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1.
        /// </param>
        /// <param name="v1">
        /// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="v1" /> is 0 and <paramref name="v2" /> is 1.
        /// </param>
        /// <param name="v2">
        /// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by
        /// the
        /// equations specified by this command. Initially, <paramref name="v1" /> is 0 and <paramref name="v2" /> is 1.
        /// </param>
        /// <param name="vstride">
        /// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point
        /// Ri⁡j+1, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in
        /// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous
        /// memory locations. The initial value of <paramref name="vstride" /> is 0.
        /// </param>
        /// <param name="vorder">
        /// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1.
        /// </param>
        /// <param name="points">
        /// Specifies a pointer to the array of control points.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Map2(MapTarget target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points)
        {
            unsafe
            {
                fixed (float* p_points = points)
                {
                    Debug.Assert(Delegates.pglMap2f != null, "pglMap2f not implemented");
                    Delegates.pglMap2f((int) target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMapGrid1d: define a one- or two-dimensional mesh
        /// </summary>
        /// <param name="un">
        /// Specifies the number of partitions in the grid range interval [<paramref name="u1" />, <paramref name="u2" />]. Must be
        /// positive.
        /// </param>
        /// <param name="u1">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        /// <param name="u2">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MapGrid1(int un, double u1, double u2)
        {
            Debug.Assert(Delegates.pglMapGrid1d != null, "pglMapGrid1d not implemented");
            Delegates.pglMapGrid1d(un, u1, u2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMapGrid1f: define a one- or two-dimensional mesh
        /// </summary>
        /// <param name="un">
        /// Specifies the number of partitions in the grid range interval [<paramref name="u1" />, <paramref name="u2" />]. Must be
        /// positive.
        /// </param>
        /// <param name="u1">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        /// <param name="u2">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MapGrid1(int un, float u1, float u2)
        {
            Debug.Assert(Delegates.pglMapGrid1f != null, "pglMapGrid1f not implemented");
            Delegates.pglMapGrid1f(un, u1, u2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMapGrid2d: define a one- or two-dimensional mesh
        /// </summary>
        /// <param name="un">
        /// Specifies the number of partitions in the grid range interval [<paramref name="u1" />, <paramref name="u2" />]. Must be
        /// positive.
        /// </param>
        /// <param name="u1">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        /// <param name="u2">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        /// <param name="vn">
        /// Specifies the number of partitions in the grid range interval [<paramref name="v1" />, <paramref name="v2" />]
        /// (Gl.MapGrid2 only).
        /// </param>
        /// <param name="v1">
        /// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
        /// </param>
        /// <param name="v2">
        /// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MapGrid2(int un, double u1, double u2, int vn, double v1, double v2)
        {
            Debug.Assert(Delegates.pglMapGrid2d != null, "pglMapGrid2d not implemented");
            Delegates.pglMapGrid2d(un, u1, u2, vn, v1, v2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMapGrid2f: define a one- or two-dimensional mesh
        /// </summary>
        /// <param name="un">
        /// Specifies the number of partitions in the grid range interval [<paramref name="u1" />, <paramref name="u2" />]. Must be
        /// positive.
        /// </param>
        /// <param name="u1">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        /// <param name="u2">
        /// Specify the mappings for integer grid domain values i=0 and i=un.
        /// </param>
        /// <param name="vn">
        /// Specifies the number of partitions in the grid range interval [<paramref name="v1" />, <paramref name="v2" />]
        /// (Gl.MapGrid2 only).
        /// </param>
        /// <param name="v1">
        /// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
        /// </param>
        /// <param name="v2">
        /// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MapGrid2(int un, float u1, float u2, int vn, float v1, float v2)
        {
            Debug.Assert(Delegates.pglMapGrid2f != null, "pglMapGrid2f not implemented");
            Delegates.pglMapGrid2f(un, u1, u2, vn, v1, v2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord1d: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord1(double u)
        {
            Debug.Assert(Delegates.pglEvalCoord1d != null, "pglEvalCoord1d not implemented");
            Delegates.pglEvalCoord1d(u);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord1dv: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord1(double[] u)
        {
            Debug.Assert(u.Length >= 1);
            unsafe
            {
                fixed (double* p_u = u)
                {
                    Debug.Assert(Delegates.pglEvalCoord1dv != null, "pglEvalCoord1dv not implemented");
                    Delegates.pglEvalCoord1dv(p_u);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord1f: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord1(float u)
        {
            Debug.Assert(Delegates.pglEvalCoord1f != null, "pglEvalCoord1f not implemented");
            Delegates.pglEvalCoord1f(u);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord1fv: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord1(float[] u)
        {
            Debug.Assert(u.Length >= 1);
            unsafe
            {
                fixed (float* p_u = u)
                {
                    Debug.Assert(Delegates.pglEvalCoord1fv != null, "pglEvalCoord1fv not implemented");
                    Delegates.pglEvalCoord1fv(p_u);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord2d: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        /// <param name="v">
        /// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This
        /// argument is not present in a Gl.EvalCoord1 command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord2(double u, double v)
        {
            Debug.Assert(Delegates.pglEvalCoord2d != null, "pglEvalCoord2d not implemented");
            Delegates.pglEvalCoord2d(u, v);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord2dv: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord2(double[] u)
        {
            Debug.Assert(u.Length >= 2);
            unsafe
            {
                fixed (double* p_u = u)
                {
                    Debug.Assert(Delegates.pglEvalCoord2dv != null, "pglEvalCoord2dv not implemented");
                    Delegates.pglEvalCoord2dv(p_u);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord2f: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        /// <param name="v">
        /// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This
        /// argument is not present in a Gl.EvalCoord1 command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord2(float u, float v)
        {
            Debug.Assert(Delegates.pglEvalCoord2f != null, "pglEvalCoord2f not implemented");
            Delegates.pglEvalCoord2f(u, v);
        }

        /// <summary>
        /// [GL2.1] glEvalCoord2fv: evaluate enabled one- and two-dimensional maps
        /// </summary>
        /// <param name="u">
        /// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2
        /// command.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalCoord2(float[] u)
        {
            Debug.Assert(u.Length >= 2);
            unsafe
            {
                fixed (float* p_u = u)
                {
                    Debug.Assert(Delegates.pglEvalCoord2fv != null, "pglEvalCoord2fv not implemented");
                    Delegates.pglEvalCoord2fv(p_u);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEvalMesh1: compute a one- or two-dimensional grid of points or lines
        /// </summary>
        /// <param name="mode">
        /// In Gl.EvalMesh1, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic constants Gl.POINT
        /// and
        /// Gl.LINE are accepted.
        /// </param>
        /// <param name="i1">
        /// Specify the first and last integer values for grid domain variable i.
        /// </param>
        /// <param name="i2">
        /// Specify the first and last integer values for grid domain variable i.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalMesh1(MeshMode1 mode, int i1, int i2)
        {
            Debug.Assert(Delegates.pglEvalMesh1 != null, "pglEvalMesh1 not implemented");
            Delegates.pglEvalMesh1((int) mode, i1, i2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEvalPoint1: generate and evaluate a single point in a mesh
        /// </summary>
        /// <param name="i">
        /// Specifies the integer value for grid domain variable i.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalPoint1(int i)
        {
            Debug.Assert(Delegates.pglEvalPoint1 != null, "pglEvalPoint1 not implemented");
            Delegates.pglEvalPoint1(i);
        }

        /// <summary>
        /// [GL2.1] glEvalMesh2: compute a one- or two-dimensional grid of points or lines
        /// </summary>
        /// <param name="mode">
        /// In Gl.EvalMesh1, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic constants Gl.POINT
        /// and
        /// Gl.LINE are accepted.
        /// </param>
        /// <param name="i1">
        /// Specify the first and last integer values for grid domain variable i.
        /// </param>
        /// <param name="i2">
        /// Specify the first and last integer values for grid domain variable i.
        /// </param>
        /// <param name="j1">
        /// A <see cref="T:int" />.
        /// </param>
        /// <param name="j2">
        /// A <see cref="T:int" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalMesh2(MeshMode2 mode, int i1, int i2, int j1, int j2)
        {
            Debug.Assert(Delegates.pglEvalMesh2 != null, "pglEvalMesh2 not implemented");
            Delegates.pglEvalMesh2((int) mode, i1, i2, j1, j2);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glEvalPoint2: generate and evaluate a single point in a mesh
        /// </summary>
        /// <param name="i">
        /// Specifies the integer value for grid domain variable i.
        /// </param>
        /// <param name="j">
        /// Specifies the integer value for grid domain variable j (Gl.EvalPoint2 only).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void EvalPoint2(int i, int j)
        {
            Debug.Assert(Delegates.pglEvalPoint2 != null, "pglEvalPoint2 not implemented");
            Delegates.pglEvalPoint2(i, j);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glAlphaFunc: specify the alpha test function
        ///     </para>
        /// </summary>
        /// <param name="func">
        /// Specifies the alpha comparison function. Symbolic constants Gl.NEVER, Gl.LESS, Gl.EQUAL, Gl.LEQUAL, Gl.GREATER,
        /// Gl.NOTEQUAL, Gl.GEQUAL, and Gl.ALWAYS are accepted. The initial value is Gl.ALWAYS.
        /// </param>
        /// <param name="ref">
        /// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range 01, where
        /// 0
        /// represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void AlphaFunc(AlphaFunction func, float @ref)
        {
            Debug.Assert(Delegates.pglAlphaFunc != null, "pglAlphaFunc not implemented");
            Delegates.pglAlphaFunc((int) func, @ref);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelZoom: specify the pixel zoom factors
        /// </summary>
        /// <param name="xfactor">
        /// Specify the x and y zoom factors for pixel write operations.
        /// </param>
        /// <param name="yfactor">
        /// Specify the x and y zoom factors for pixel write operations.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelZoom(float xfactor, float yfactor)
        {
            Debug.Assert(Delegates.pglPixelZoom != null, "pglPixelZoom not implemented");
            Delegates.pglPixelZoom(xfactor, yfactor);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelTransferf: set pixel transfer modes
        /// </summary>
        /// <param name="pname">
        /// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: Gl.MAP_COLOR,
        /// Gl.MAP_STENCIL, Gl.INDEX_SHIFT, Gl.INDEX_OFFSET, Gl.RED_SCALE, Gl.RED_BIAS, Gl.GREEN_SCALE, Gl.GREEN_BIAS,
        /// Gl.BLUE_SCALE, Gl.BLUE_BIAS, Gl.ALPHA_SCALE, Gl.ALPHA_BIAS, Gl.DEPTH_SCALE, or Gl.DEPTH_BIAS.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="pname" /> is set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelTransfer(PixelTransferParameter pname, float param)
        {
            Debug.Assert(Delegates.pglPixelTransferf != null, "pglPixelTransferf not implemented");
            Delegates.pglPixelTransferf((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelTransferi: set pixel transfer modes
        /// </summary>
        /// <param name="pname">
        /// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: Gl.MAP_COLOR,
        /// Gl.MAP_STENCIL, Gl.INDEX_SHIFT, Gl.INDEX_OFFSET, Gl.RED_SCALE, Gl.RED_BIAS, Gl.GREEN_SCALE, Gl.GREEN_BIAS,
        /// Gl.BLUE_SCALE, Gl.BLUE_BIAS, Gl.ALPHA_SCALE, Gl.ALPHA_BIAS, Gl.DEPTH_SCALE, or Gl.DEPTH_BIAS.
        /// </param>
        /// <param name="param">
        /// Specifies the value that <paramref name="pname" /> is set to.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelTransfer(PixelTransferParameter pname, int param)
        {
            Debug.Assert(Delegates.pglPixelTransferi != null, "pglPixelTransferi not implemented");
            Delegates.pglPixelTransferi((int) pname, param);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelMapfv: set up pixel transfer maps
        /// </summary>
        /// <param name="map">
        /// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="mapsize">
        /// Specifies the size of the map being defined.
        /// </param>
        /// <param name="values">
        /// Specifies an array of <paramref name="mapsize" /> values.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelMap(PixelMap map, int mapsize, float[] values)
        {
            unsafe
            {
                fixed (float* p_values = values)
                {
                    Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
                    Delegates.pglPixelMapfv((int) map, mapsize, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelMapfv: set up pixel transfer maps
        /// </summary>
        /// <param name="map">
        /// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="values">
        /// Specifies an array of <paramref name="mapsize" /> values.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelMap(PixelMap map, float[] values)
        {
            unsafe
            {
                fixed (float* p_values = values)
                {
                    Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
                    Delegates.pglPixelMapfv((int) map, values.Length, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelMapuiv: set up pixel transfer maps
        /// </summary>
        /// <param name="map">
        /// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="mapsize">
        /// Specifies the size of the map being defined.
        /// </param>
        /// <param name="values">
        /// Specifies an array of <paramref name="mapsize" /> values.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelMap(PixelMap map, int mapsize, uint[] values)
        {
            unsafe
            {
                fixed (uint* p_values = values)
                {
                    Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
                    Delegates.pglPixelMapuiv((int) map, mapsize, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelMapuiv: set up pixel transfer maps
        /// </summary>
        /// <param name="map">
        /// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="values">
        /// Specifies an array of <paramref name="mapsize" /> values.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelMap(PixelMap map, uint[] values)
        {
            unsafe
            {
                fixed (uint* p_values = values)
                {
                    Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
                    Delegates.pglPixelMapuiv((int) map, values.Length, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelMapusv: set up pixel transfer maps
        /// </summary>
        /// <param name="map">
        /// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="mapsize">
        /// Specifies the size of the map being defined.
        /// </param>
        /// <param name="values">
        /// Specifies an array of <paramref name="mapsize" /> values.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelMap(PixelMap map, int mapsize, ushort[] values)
        {
            unsafe
            {
                fixed (ushort* p_values = values)
                {
                    Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
                    Delegates.pglPixelMapusv((int) map, mapsize, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glPixelMapusv: set up pixel transfer maps
        /// </summary>
        /// <param name="map">
        /// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="values">
        /// Specifies an array of <paramref name="mapsize" /> values.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PixelMap(PixelMap map, ushort[] values)
        {
            unsafe
            {
                fixed (ushort* p_values = values)
                {
                    Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
                    Delegates.pglPixelMapusv((int) map, values.Length, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glCopyPixels: copy pixels in the frame buffer
        /// </summary>
        /// <param name="x">
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="y">
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </param>
        /// <param name="width">
        /// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative.
        /// </param>
        /// <param name="height">
        /// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative.
        /// </param>
        /// <param name="type">
        /// Specifies whether color values, depth values, or stencil values are to be copied. Symbolic constants Gl.COLOR,
        /// Gl.DEPTH,
        /// and Gl.STENCIL are accepted.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void CopyPixels(int x, int y, int width, int height, PixelCopyType type)
        {
            Debug.Assert(Delegates.pglCopyPixels != null, "pglCopyPixels not implemented");
            Delegates.pglCopyPixels(x, y, width, height, (int) type);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glDrawPixels: write a block of pixels to the frame buffer
        /// </summary>
        /// <param name="width">
        /// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
        /// </param>
        /// <param name="height">
        /// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. Symbolic constants Gl.COLOR_INDEX, Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT,
        /// Gl.RGB,
        /// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the data type for <paramref name="data" />. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP,
        /// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV,
        /// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV,
        /// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV,
        /// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
        /// </param>
        /// <param name="pixels">
        /// A <see cref="T:IntPtr" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void DrawPixels(int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Debug.Assert(Delegates.pglDrawPixels != null, "pglDrawPixels not implemented");
            Delegates.pglDrawPixels(width, height, (int) format, (int) type, pixels);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glDrawPixels: write a block of pixels to the frame buffer
        /// </summary>
        /// <param name="width">
        /// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
        /// </param>
        /// <param name="height">
        /// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
        /// </param>
        /// <param name="format">
        /// Specifies the format of the pixel data. Symbolic constants Gl.COLOR_INDEX, Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT,
        /// Gl.RGB,
        /// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the data type for <paramref name="data" />. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP,
        /// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV,
        /// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV,
        /// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV,
        /// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
        /// </param>
        /// <param name="pixels">
        /// A <see cref="T:object" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void DrawPixels(int width, int height, PixelFormat format, PixelType type, object pixels)
        {
            GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                DrawPixels(width, height, format, type, pin_pixels.AddrOfPinnedObject());
            }
            finally
            {
                pin_pixels.Free();
            }
        }

        /// <summary>
        /// [GL2.1] glGetClipPlane: return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping
        /// planes are supported. They are identified by symbolic names of the form Gl.CLIP_PLANEi where i ranges from 0 to the
        /// value of Gl.MAX_CLIP_PLANES - 1.
        /// </param>
        /// <param name="equation">
        /// Returns four double-precision values that are the coefficients of the plane equation of <paramref name="plane" /> in
        /// eye
        /// coordinates. The initial value is (0, 0, 0, 0).
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetClipPlane(ClipPlaneName plane, [Out] double[] equation)
        {
            Debug.Assert(equation.Length >= 4);
            unsafe
            {
                fixed (double* p_equation = equation)
                {
                    Debug.Assert(Delegates.pglGetClipPlane != null, "pglGetClipPlane not implemented");
                    Delegates.pglGetClipPlane((int) plane, p_equation);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glGetLightfv: return light source parameter values
        ///     </para>
        /// </summary>
        /// <param name="light">
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are
        /// supported. They are identified by symbolic names of the form Gl.LIGHTi where i ranges from 0 to the value of
        /// Gl.MAX_LIGHTS - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a light source parameter for <paramref name="light" />. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE,
        /// Gl.SPECULAR, Gl.POSITION, Gl.SPOT_DIRECTION, Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, Gl.CONSTANT_ATTENUATION,
        /// Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetLight(LightName light, LightParameter pname, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetLightfv != null, "pglGetLightfv not implemented");
                    Delegates.pglGetLightfv((int) light, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetLightiv: return light source parameter values
        /// </summary>
        /// <param name="light">
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are
        /// supported. They are identified by symbolic names of the form Gl.LIGHTi where i ranges from 0 to the value of
        /// Gl.MAX_LIGHTS - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a light source parameter for <paramref name="light" />. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE,
        /// Gl.SPECULAR, Gl.POSITION, Gl.SPOT_DIRECTION, Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, Gl.CONSTANT_ATTENUATION,
        /// Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetLight(LightName light, LightParameter pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetLightiv != null, "pglGetLightiv not implemented");
                    Delegates.pglGetLightiv((int) light, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetMapdv: return evaluator parameters
        /// </summary>
        /// <param name="target">
        /// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL,
        /// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3,
        /// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2,
        /// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
        /// </param>
        /// <param name="query">
        /// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
        /// </param>
        /// <param name="v">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetMap(MapTarget target, GetMapQuery query, [Out] double[] v)
        {
            unsafe
            {
                fixed (double* p_v = v)
                {
                    Debug.Assert(Delegates.pglGetMapdv != null, "pglGetMapdv not implemented");
                    Delegates.pglGetMapdv((int) target, (int) query, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetMapfv: return evaluator parameters
        /// </summary>
        /// <param name="target">
        /// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL,
        /// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3,
        /// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2,
        /// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
        /// </param>
        /// <param name="query">
        /// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
        /// </param>
        /// <param name="v">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetMap(MapTarget target, GetMapQuery query, [Out] float[] v)
        {
            unsafe
            {
                fixed (float* p_v = v)
                {
                    Debug.Assert(Delegates.pglGetMapfv != null, "pglGetMapfv not implemented");
                    Delegates.pglGetMapfv((int) target, (int) query, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetMapiv: return evaluator parameters
        /// </summary>
        /// <param name="target">
        /// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL,
        /// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3,
        /// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2,
        /// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
        /// </param>
        /// <param name="query">
        /// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
        /// </param>
        /// <param name="v">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetMap(MapTarget target, GetMapQuery query, [Out] int[] v)
        {
            unsafe
            {
                fixed (int* p_v = v)
                {
                    Debug.Assert(Delegates.pglGetMapiv != null, "pglGetMapiv not implemented");
                    Delegates.pglGetMapiv((int) target, (int) query, p_v);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1] glGetMaterialfv: return material parameters
        ///     </para>
        ///     <para>
        ///     [GLES1.1] glGetMaterialfv: return material parameters values
        ///     </para>
        /// </summary>
        /// <param name="face">
        /// Specifies which of the two materials is being queried. Gl.FRONT or Gl.BACK are accepted, representing the front and
        /// back
        /// materials, respectively.
        /// </param>
        /// <param name="pname">
        /// Specifies the material parameter to return. Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, Gl.EMISSION, Gl.SHININESS, and
        /// Gl.COLOR_INDEXES are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetMaterialfv != null, "pglGetMaterialfv not implemented");
                    Delegates.pglGetMaterialfv((int) face, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetMaterialiv: return material parameters
        /// </summary>
        /// <param name="face">
        /// Specifies which of the two materials is being queried. Gl.FRONT or Gl.BACK are accepted, representing the front and
        /// back
        /// materials, respectively.
        /// </param>
        /// <param name="pname">
        /// Specifies the material parameter to return. Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, Gl.EMISSION, Gl.SHININESS, and
        /// Gl.COLOR_INDEXES are accepted.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetMaterialiv != null, "pglGetMaterialiv not implemented");
                    Delegates.pglGetMaterialiv((int) face, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetPixelMapfv: return the specified pixel map
        /// </summary>
        /// <param name="map">
        /// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="values">
        /// A <see cref="T:float[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetPixelMap(PixelMap map, [Out] float[] values)
        {
            unsafe
            {
                fixed (float* p_values = values)
                {
                    Debug.Assert(Delegates.pglGetPixelMapfv != null, "pglGetPixelMapfv not implemented");
                    Delegates.pglGetPixelMapfv((int) map, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetPixelMapuiv: return the specified pixel map
        /// </summary>
        /// <param name="map">
        /// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="values">
        /// A <see cref="T:uint[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetPixelMap(PixelMap map, [Out] uint[] values)
        {
            unsafe
            {
                fixed (uint* p_values = values)
                {
                    Debug.Assert(Delegates.pglGetPixelMapuiv != null, "pglGetPixelMapuiv not implemented");
                    Delegates.pglGetPixelMapuiv((int) map, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetPixelMapusv: return the specified pixel map
        /// </summary>
        /// <param name="map">
        /// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S,
        /// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R,
        /// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
        /// </param>
        /// <param name="values">
        /// A <see cref="T:ushort[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetPixelMap(PixelMap map, [Out] ushort[] values)
        {
            unsafe
            {
                fixed (ushort* p_values = values)
                {
                    Debug.Assert(Delegates.pglGetPixelMapusv != null, "pglGetPixelMapusv not implemented");
                    Delegates.pglGetPixelMapusv((int) map, p_values);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetPolygonStipple: return the polygon stipple pattern
        /// </summary>
        /// <param name="mask">
        /// A <see cref="T:byte[]" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetPolygonStipple([Out] byte[] mask)
        {
            unsafe
            {
                fixed (byte* p_mask = mask)
                {
                    Debug.Assert(Delegates.pglGetPolygonStipple != null, "pglGetPolygonStipple not implemented");
                    Delegates.pglGetPolygonStipple(p_mask);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glGetTexEnvfv: return texture environment parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL, or Gl.POINT_SPRITE.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are Gl.TEXTURE_ENV_MODE,
        /// Gl.TEXTURE_ENV_COLOR, Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB,
        /// Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA,
        /// Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexEnvfv != null, "pglGetTexEnvfv not implemented");
                    Delegates.pglGetTexEnvfv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glGetTexEnviv: return texture environment parameters
        ///     </para>
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL, or Gl.POINT_SPRITE.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are Gl.TEXTURE_ENV_MODE,
        /// Gl.TEXTURE_ENV_COLOR, Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB,
        /// Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA,
        /// Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexEnviv != null, "pglGetTexEnviv not implemented");
                    Delegates.pglGetTexEnviv((int) target, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetTexGendv: return texture coordinate generation parameters
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of
        /// the
        /// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] double[] @params)
        {
            unsafe
            {
                fixed (double* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexGendv != null, "pglGetTexGendv not implemented");
                    Delegates.pglGetTexGendv((int) coord, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetTexGenfv: return texture coordinate generation parameters
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of
        /// the
        /// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] float[] @params)
        {
            unsafe
            {
                fixed (float* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexGenfv != null, "pglGetTexGenfv not implemented");
                    Delegates.pglGetTexGenfv((int) coord, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glGetTexGeniv: return texture coordinate generation parameters
        /// </summary>
        /// <param name="coord">
        /// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of
        /// the
        /// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
        /// </param>
        /// <param name="params">
        /// Returns the requested data.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] int[] @params)
        {
            unsafe
            {
                fixed (int* p_params = @params)
                {
                    Debug.Assert(Delegates.pglGetTexGeniv != null, "pglGetTexGeniv not implemented");
                    Delegates.pglGetTexGeniv((int) coord, (int) pname, p_params);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glIsList: determine if a name corresponds to a display list
        /// </summary>
        /// <param name="list">
        /// Specifies a potential display list name.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static bool IsList(uint list)
        {
            bool retValue;

            Debug.Assert(Delegates.pglIsList != null, "pglIsList not implemented");
            retValue = Delegates.pglIsList(list);
            DebugCheckErrors(retValue);

            return retValue;
        }

        /// <summary>
        /// [GL2.1] glFrustum: multiply the current matrix by a perspective matrix
        /// </summary>
        /// <param name="left">
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="right">
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="bottom">
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="top">
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="zNear">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="zFar">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
        {
            Debug.Assert(Delegates.pglFrustum != null, "pglFrustum not implemented");
            Delegates.pglFrustum(left, right, bottom, top, zNear, zFar);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLoadIdentity: replace the current matrix with the identity matrix
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadIdentity()
        {
            Debug.Assert(Delegates.pglLoadIdentity != null, "pglLoadIdentity not implemented");
            Delegates.pglLoadIdentity();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLoadMatrixf: replace the current matrix with the specified matrix
        ///     </para>
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadMatrix(float[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (float* p_m = m)
                {
                    Debug.Assert(Delegates.pglLoadMatrixf != null, "pglLoadMatrixf not implemented");
                    Delegates.pglLoadMatrixf(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLoadMatrixf: replace the current matrix with the specified matrix
        ///     </para>
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void LoadMatrix(float* m)
        {
            Debug.Assert(Delegates.pglLoadMatrixf != null, "pglLoadMatrixf not implemented");
            Delegates.pglLoadMatrixf(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glLoadMatrixf: replace the current matrix with the specified matrix
        ///     </para>
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadMatrixf<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglLoadMatrixf != null, "pglLoadMatrixf not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglLoadMatrixf((float*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadMatrixd: replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadMatrix(double[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (double* p_m = m)
                {
                    Debug.Assert(Delegates.pglLoadMatrixd != null, "pglLoadMatrixd not implemented");
                    Delegates.pglLoadMatrixd(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadMatrixd: replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void LoadMatrix(double* m)
        {
            Debug.Assert(Delegates.pglLoadMatrixd != null, "pglLoadMatrixd not implemented");
            Delegates.pglLoadMatrixd(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glLoadMatrixd: replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void LoadMatrixd<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglLoadMatrixd != null, "pglLoadMatrixd not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglLoadMatrixd((double*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glMatrixMode: specify which matrix is the current matrix
        ///     </para>
        /// </summary>
        /// <param name="mode">
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: Gl.MODELVIEW,
        /// Gl.PROJECTION, and Gl.TEXTURE. The initial value is Gl.MODELVIEW. Additionally, if the ARB_imaging extension is
        /// supported, Gl.COLOR is also accepted.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MatrixMode(MatrixMode mode)
        {
            Debug.Assert(Delegates.pglMatrixMode != null, "pglMatrixMode not implemented");
            Delegates.pglMatrixMode((int) mode);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glMultMatrixf: multiply the current matrix with the specified matrix
        ///     </para>
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultMatrix(float[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (float* p_m = m)
                {
                    Debug.Assert(Delegates.pglMultMatrixf != null, "pglMultMatrixf not implemented");
                    Delegates.pglMultMatrixf(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glMultMatrixf: multiply the current matrix with the specified matrix
        ///     </para>
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void MultMatrix(float* m)
        {
            Debug.Assert(Delegates.pglMultMatrixf != null, "pglMultMatrixf not implemented");
            Delegates.pglMultMatrixf(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glMultMatrixf: multiply the current matrix with the specified matrix
        ///     </para>
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultMatrixf<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglMultMatrixf != null, "pglMultMatrixf not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglMultMatrixf((float*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultMatrixd: multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultMatrix(double[] m)
        {
            Debug.Assert(m.Length >= 16);
            unsafe
            {
                fixed (double* p_m = m)
                {
                    Debug.Assert(Delegates.pglMultMatrixd != null, "pglMultMatrixd not implemented");
                    Delegates.pglMultMatrixd(p_m);
                }
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultMatrixd: multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static unsafe void MultMatrix(double* m)
        {
            Debug.Assert(Delegates.pglMultMatrixd != null, "pglMultMatrixd not implemented");
            Delegates.pglMultMatrixd(m);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glMultMatrixd: multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void MultMatrixd<T>(T m) where T : struct
        {
            Debug.Assert(Delegates.pglMultMatrixd != null, "pglMultMatrixd not implemented");
            unsafe
            {
                TypedReference refM = __makeref(m);
                IntPtr refMPtr = *(IntPtr*) (&refM);

                Delegates.pglMultMatrixd((double*) refMPtr.ToPointer());
            }

            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glOrtho: multiply the current matrix with an orthographic matrix
        /// </summary>
        /// <param name="left">
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="right">
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </param>
        /// <param name="bottom">
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="top">
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </param>
        /// <param name="zNear">
        /// A <see cref="T:double" />.
        /// </param>
        /// <param name="zFar">
        /// A <see cref="T:double" />.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
        {
            Debug.Assert(Delegates.pglOrtho != null, "pglOrtho not implemented");
            Delegates.pglOrtho(left, right, bottom, top, zNear, zFar);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glPopMatrix: push and pop the current matrix stack
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PopMatrix()
        {
            Debug.Assert(Delegates.pglPopMatrix != null, "pglPopMatrix not implemented");
            Delegates.pglPopMatrix();
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glPushMatrix: push and pop the current matrix stack
        ///     </para>
        /// </summary>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void PushMatrix()
        {
            Debug.Assert(Delegates.pglPushMatrix != null, "pglPushMatrix not implemented");
            Delegates.pglPushMatrix();
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glRotated: multiply the current matrix by a rotation matrix
        /// </summary>
        /// <param name="angle">
        /// Specifies the angle of rotation, in degrees.
        /// </param>
        /// <param name="x">
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rotate(double angle, double x, double y, double z)
        {
            Debug.Assert(Delegates.pglRotated != null, "pglRotated not implemented");
            Delegates.pglRotated(angle, x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glRotatef: multiply the current matrix by a rotation matrix
        ///     </para>
        /// </summary>
        /// <param name="angle">
        /// Specifies the angle of rotation, in degrees.
        /// </param>
        /// <param name="x">
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Rotate(float angle, float x, float y, float z)
        {
            Debug.Assert(Delegates.pglRotatef != null, "pglRotatef not implemented");
            Delegates.pglRotatef(angle, x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glScaled: multiply the current matrix by a general scaling matrix
        /// </summary>
        /// <param name="x">
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        /// <param name="y">
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        /// <param name="z">
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Scale(double x, double y, double z)
        {
            Debug.Assert(Delegates.pglScaled != null, "pglScaled not implemented");
            Delegates.pglScaled(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glScalef: multiply the current matrix by a general scaling matrix
        ///     </para>
        /// </summary>
        /// <param name="x">
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        /// <param name="y">
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        /// <param name="z">
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Scale(float x, float y, float z)
        {
            Debug.Assert(Delegates.pglScalef != null, "pglScalef not implemented");
            Delegates.pglScalef(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        /// [GL2.1] glTranslated: multiply the current matrix by a translation matrix
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Translate(double x, double y, double z)
        {
            Debug.Assert(Delegates.pglTranslated != null, "pglTranslated not implemented");
            Delegates.pglTranslated(x, y, z);
            DebugCheckErrors(null);
        }

        /// <summary>
        ///     <para>
        ///     [GL2.1|GLES1.1] glTranslatef: multiply the current matrix by a translation matrix
        ///     </para>
        /// </summary>
        /// <param name="x">
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        /// <param name="y">
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        /// <param name="z">
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </param>
        [RequiredByFeature("GL_VERSION_1_0")]
        [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
        [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
        public static void Translate(float x, float y, float z)
        {
            Debug.Assert(Delegates.pglTranslatef != null, "pglTranslatef not implemented");
            Delegates.pglTranslatef(x, y, z);
            DebugCheckErrors(null);
        }

        internal static unsafe partial class Delegates
        {
            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCullFace(int mode);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glCullFace pglCullFace;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFrontFace(int mode);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glFrontFace pglFrontFace;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glHint(int target, int mode);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glHint pglHint;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLineWidth(float width);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glLineWidth pglLineWidth;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPointSize(float size);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [ThreadStatic]
            internal static glPointSize pglPointSize;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPolygonMode(int face, int mode);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_NV_polygon_mode", Api = "gles2", EntryPoint = "glPolygonModeNV")] [ThreadStatic]
            internal static glPolygonMode pglPolygonMode;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glScissor(int x, int y, int width, int height);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glScissor pglScissor;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexParameterf(int target, int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glTexParameterf pglTexParameterf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexParameterfv(int target, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glTexParameterfv pglTexParameterfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexParameteri(int target, int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glTexParameteri pglTexParameteri;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexParameteriv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glTexParameteriv pglTexParameteriv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexImage1D(int target, int level, int internalformat, int width, int border, int format, int type, IntPtr pixels);

            [RequiredByFeature("GL_VERSION_1_0")] [ThreadStatic]
            internal static glTexImage1D pglTexImage1D;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [ThreadStatic]
            internal static glTexImage2D pglTexImage2D;

            [RequiredByFeature("GL_VERSION_1_0")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glDrawBuffer(int buf);

            [RequiredByFeature("GL_VERSION_1_0")] [ThreadStatic]
            internal static glDrawBuffer pglDrawBuffer;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClear(uint mask);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glClear pglClear;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClearColor(float red, float green, float blue, float alpha);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glClearColor pglClearColor;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClearStencil(int s);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glClearStencil pglClearStencil;

            [RequiredByFeature("GL_VERSION_1_0")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClearDepth(double depth);

            [RequiredByFeature("GL_VERSION_1_0")] [ThreadStatic]
            internal static glClearDepth pglClearDepth;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glStencilMask(uint mask);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glStencilMask pglStencilMask;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColorMask([MarshalAs(UnmanagedType.I1)] bool red, [MarshalAs(UnmanagedType.I1)] bool green, [MarshalAs(UnmanagedType.I1)] bool blue,
                [MarshalAs(UnmanagedType.I1)] bool alpha);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glColorMask pglColorMask;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glDepthMask([MarshalAs(UnmanagedType.I1)] bool flag);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glDepthMask pglDepthMask;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glDisable(int cap);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glDisable pglDisable;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEnable(int cap);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glEnable pglEnable;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFinish();

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glFinish pglFinish;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFlush();

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glFlush pglFlush;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glBlendFunc(int sfactor, int dfactor);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glBlendFunc pglBlendFunc;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLogicOp(int opcode);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [ThreadStatic]
            internal static glLogicOp pglLogicOp;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glStencilFunc(int func, int @ref, uint mask);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glStencilFunc pglStencilFunc;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glStencilOp(int fail, int zfail, int zpass);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glStencilOp pglStencilOp;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glDepthFunc(int func);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glDepthFunc pglDepthFunc;

            [RequiredByFeature("GL_VERSION_1_0")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelStoref(int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [ThreadStatic]
            internal static glPixelStoref pglPixelStoref;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelStorei(int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glPixelStorei pglPixelStorei;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glReadBuffer(int src);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")] [ThreadStatic]
            internal static glReadBuffer pglReadBuffer;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")] [ThreadStatic]
            internal static glReadPixels pglReadPixels;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetBooleanv(int pname, byte* data);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glGetBooleanv pglGetBooleanv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetDoublev(int pname, double* data);

            [RequiredByFeature("GL_VERSION_1_0")] [ThreadStatic]
            internal static glGetDoublev pglGetDoublev;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate int glGetError();

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glGetError pglGetError;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetFloatv(int pname, float* data);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glGetFloatv pglGetFloatv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetIntegerv(int pname, int* data);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glGetIntegerv pglGetIntegerv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr glGetString(int name);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glGetString pglGetString;

            [RequiredByFeature("GL_VERSION_1_0")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexImage(int target, int level, int format, int type, IntPtr pixels);

            [RequiredByFeature("GL_VERSION_1_0")] [ThreadStatic]
            internal static glGetTexImage pglGetTexImage;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexParameterfv(int target, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glGetTexParameterfv pglGetTexParameterfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexParameteriv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glGetTexParameteriv pglGetTexParameteriv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexLevelParameterfv(int target, int level, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [ThreadStatic]
            internal static glGetTexLevelParameterfv pglGetTexLevelParameterfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexLevelParameteriv(int target, int level, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")] [ThreadStatic]
            internal static glGetTexLevelParameteriv pglGetTexLevelParameteriv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool glIsEnabled(int cap);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glIsEnabled pglIsEnabled;

            [RequiredByFeature("GL_VERSION_1_0")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glDepthRange(double near, double far);

            [RequiredByFeature("GL_VERSION_1_0")] [ThreadStatic]
            internal static glDepthRange pglDepthRange;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glViewport(int x, int y, int width, int height);

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
            [RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
            [ThreadStatic]
            internal static glViewport pglViewport;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNewList(uint list, int mode);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNewList pglNewList;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEndList();

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEndList pglEndList;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCallList(uint list);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glCallList pglCallList;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCallLists(int n, int type, IntPtr lists);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glCallLists pglCallLists;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glDeleteLists(uint list, int range);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glDeleteLists pglDeleteLists;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate uint glGenLists(int range);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGenLists pglGenLists;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glListBase(uint @base);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glListBase pglListBase;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glBegin(int mode);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glBegin pglBegin;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glBitmap pglBitmap;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3b(sbyte red, sbyte green, sbyte blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3b pglColor3b;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3bv(sbyte* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3bv pglColor3bv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3d(double red, double green, double blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3d pglColor3d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3dv pglColor3dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3f(float red, float green, float blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3f pglColor3f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3fv pglColor3fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3i(int red, int green, int blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3i pglColor3i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3iv pglColor3iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3s(short red, short green, short blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3s pglColor3s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3sv pglColor3sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3ub(byte red, byte green, byte blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3ub pglColor3ub;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3ubv(byte* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3ubv pglColor3ubv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3ui(uint red, uint green, uint blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3ui pglColor3ui;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3uiv(uint* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3uiv pglColor3uiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3us(ushort red, ushort green, ushort blue);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3us pglColor3us;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor3usv(ushort* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor3usv pglColor3usv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4b pglColor4b;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4bv(sbyte* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4bv pglColor4bv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4d(double red, double green, double blue, double alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4d pglColor4d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4dv pglColor4dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4f(float red, float green, float blue, float alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4f pglColor4f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4fv pglColor4fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4i(int red, int green, int blue, int alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4i pglColor4i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4iv pglColor4iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4s(short red, short green, short blue, short alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4s pglColor4s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4sv pglColor4sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4ub(byte red, byte green, byte blue, byte alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4ub pglColor4ub;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4ubv(byte* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4ubv pglColor4ubv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4ui(uint red, uint green, uint blue, uint alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4ui pglColor4ui;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4uiv(uint* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4uiv pglColor4uiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4us pglColor4us;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColor4usv(ushort* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColor4usv pglColor4usv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEdgeFlag([MarshalAs(UnmanagedType.I1)] bool flag);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEdgeFlag pglEdgeFlag;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEdgeFlagv(byte* flag);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEdgeFlagv pglEdgeFlagv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEnd();

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEnd pglEnd;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexd(double c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexd pglIndexd;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexdv(double* c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexdv pglIndexdv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexf(float c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexf pglIndexf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexfv(float* c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexfv pglIndexfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexi(int c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexi pglIndexi;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexiv(int* c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexiv pglIndexiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexs(short c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexs pglIndexs;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexsv(short* c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexsv pglIndexsv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3b pglNormal3b;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3bv(sbyte* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3bv pglNormal3bv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3d(double nx, double ny, double nz);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3d pglNormal3d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3dv pglNormal3dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3f(float nx, float ny, float nz);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3f pglNormal3f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3fv pglNormal3fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3i(int nx, int ny, int nz);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3i pglNormal3i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3iv pglNormal3iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3s(short nx, short ny, short nz);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3s pglNormal3s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glNormal3sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glNormal3sv pglNormal3sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2d(double x, double y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2d pglRasterPos2d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2dv pglRasterPos2dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2f(float x, float y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2f pglRasterPos2f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2fv pglRasterPos2fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2i(int x, int y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2i pglRasterPos2i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2iv pglRasterPos2iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2s(short x, short y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2s pglRasterPos2s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos2sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos2sv pglRasterPos2sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3d(double x, double y, double z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3d pglRasterPos3d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3dv pglRasterPos3dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3f(float x, float y, float z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3f pglRasterPos3f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3fv pglRasterPos3fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3i(int x, int y, int z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3i pglRasterPos3i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3iv pglRasterPos3iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3s(short x, short y, short z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3s pglRasterPos3s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos3sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos3sv pglRasterPos3sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4d(double x, double y, double z, double w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4d pglRasterPos4d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4dv pglRasterPos4dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4f(float x, float y, float z, float w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4f pglRasterPos4f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4fv pglRasterPos4fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4i(int x, int y, int z, int w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4i pglRasterPos4i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4iv pglRasterPos4iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4s(short x, short y, short z, short w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4s pglRasterPos4s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRasterPos4sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRasterPos4sv pglRasterPos4sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRectd(double x1, double y1, double x2, double y2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRectd pglRectd;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRectdv(double* v1, double* v2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRectdv pglRectdv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRectf(float x1, float y1, float x2, float y2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRectf pglRectf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRectfv(float* v1, float* v2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRectfv pglRectfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRecti(int x1, int y1, int x2, int y2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRecti pglRecti;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRectiv(int* v1, int* v2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRectiv pglRectiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRects(short x1, short y1, short x2, short y2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRects pglRects;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRectsv(short* v1, short* v2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRectsv pglRectsv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1d(double s);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1d pglTexCoord1d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1dv pglTexCoord1dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1f(float s);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1f pglTexCoord1f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1fv pglTexCoord1fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1i(int s);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1i pglTexCoord1i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1iv pglTexCoord1iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1s(short s);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1s pglTexCoord1s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord1sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord1sv pglTexCoord1sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2d(double s, double t);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2d pglTexCoord2d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2dv pglTexCoord2dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2f(float s, float t);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2f pglTexCoord2f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2fv pglTexCoord2fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2i(int s, int t);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2i pglTexCoord2i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2iv pglTexCoord2iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2s(short s, short t);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2s pglTexCoord2s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord2sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord2sv pglTexCoord2sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3d(double s, double t, double r);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3d pglTexCoord3d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3dv pglTexCoord3dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3f(float s, float t, float r);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3f pglTexCoord3f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3fv pglTexCoord3fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3i(int s, int t, int r);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3i pglTexCoord3i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3iv pglTexCoord3iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3s(short s, short t, short r);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3s pglTexCoord3s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord3sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord3sv pglTexCoord3sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4d(double s, double t, double r, double q);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4d pglTexCoord4d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4dv pglTexCoord4dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4f(float s, float t, float r, float q);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4f pglTexCoord4f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4fv pglTexCoord4fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4i(int s, int t, int r, int q);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4i pglTexCoord4i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4iv pglTexCoord4iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4s(short s, short t, short r, short q);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4s pglTexCoord4s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexCoord4sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexCoord4sv pglTexCoord4sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2d(double x, double y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2d pglVertex2d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2dv pglVertex2dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2f(float x, float y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2f pglVertex2f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2fv pglVertex2fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2i(int x, int y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2i pglVertex2i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2iv pglVertex2iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2s(short x, short y);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2s pglVertex2s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex2sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex2sv pglVertex2sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3d(double x, double y, double z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3d pglVertex3d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3dv pglVertex3dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3f(float x, float y, float z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3f pglVertex3f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3fv pglVertex3fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3i(int x, int y, int z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3i pglVertex3i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3iv pglVertex3iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3s(short x, short y, short z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3s pglVertex3s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex3sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex3sv pglVertex3sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4d(double x, double y, double z, double w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4d pglVertex4d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4dv(double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4dv pglVertex4dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4f(float x, float y, float z, float w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4f pglVertex4f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4fv(float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4fv pglVertex4fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4i(int x, int y, int z, int w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4i pglVertex4i;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4iv(int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4iv pglVertex4iv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4s(short x, short y, short z, short w);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4s pglVertex4s;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glVertex4sv(short* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glVertex4sv pglVertex4sv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClipPlane(int plane, double* equation);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glClipPlane pglClipPlane;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glColorMaterial(int face, int mode);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glColorMaterial pglColorMaterial;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFogf(int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glFogf pglFogf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFogfv(int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glFogfv pglFogfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFogi(int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glFogi pglFogi;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFogiv(int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glFogiv pglFogiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLightf(int light, int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLightf pglLightf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLightfv(int light, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLightfv pglLightfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLighti(int light, int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLighti pglLighti;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLightiv(int light, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLightiv pglLightiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLightModelf(int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLightModelf pglLightModelf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLightModelfv(int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLightModelfv pglLightModelfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLightModeli(int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLightModeli pglLightModeli;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLightModeliv(int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLightModeliv pglLightModeliv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLineStipple(int factor, ushort pattern);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLineStipple pglLineStipple;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMaterialf(int face, int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMaterialf pglMaterialf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMaterialfv(int face, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMaterialfv pglMaterialfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMateriali(int face, int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMateriali pglMateriali;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMaterialiv(int face, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMaterialiv pglMaterialiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPolygonStipple(byte* mask);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPolygonStipple pglPolygonStipple;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glShadeModel(int mode);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glShadeModel pglShadeModel;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexEnvf(int target, int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexEnvf pglTexEnvf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexEnvfv(int target, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexEnvfv pglTexEnvfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexEnvi(int target, int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexEnvi pglTexEnvi;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexEnviv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexEnviv pglTexEnviv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexGend(int coord, int pname, double param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexGend pglTexGend;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexGendv(int coord, int pname, double* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexGendv pglTexGendv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexGenf(int coord, int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexGenf pglTexGenf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexGenfv(int coord, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexGenfv pglTexGenfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexGeni(int coord, int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexGeni pglTexGeni;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTexGeniv(int coord, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTexGeniv pglTexGeniv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFeedbackBuffer(int size, int type, float* buffer);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glFeedbackBuffer pglFeedbackBuffer;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glSelectBuffer(int size, uint* buffer);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glSelectBuffer pglSelectBuffer;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate int glRenderMode(int mode);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRenderMode pglRenderMode;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glInitNames();

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glInitNames pglInitNames;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLoadName(uint name);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLoadName pglLoadName;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPassThrough(float token);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPassThrough pglPassThrough;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPopName();

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPopName pglPopName;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPushName(uint name);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPushName pglPushName;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClearAccum(float red, float green, float blue, float alpha);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glClearAccum pglClearAccum;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glClearIndex(float c);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glClearIndex pglClearIndex;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glIndexMask(uint mask);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIndexMask pglIndexMask;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glAccum(int op, float value);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glAccum pglAccum;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPopAttrib();

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPopAttrib pglPopAttrib;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPushAttrib(uint mask);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPushAttrib pglPushAttrib;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMap1d(int target, double u1, double u2, int stride, int order, double* points);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMap1d pglMap1d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMap1f(int target, float u1, float u2, int stride, int order, float* points);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMap1f pglMap1f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMap2d(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMap2d pglMap2d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMap2f(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMap2f pglMap2f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMapGrid1d(int un, double u1, double u2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMapGrid1d pglMapGrid1d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMapGrid1f(int un, float u1, float u2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMapGrid1f pglMapGrid1f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMapGrid2d pglMapGrid2d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMapGrid2f pglMapGrid2f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord1d(double u);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord1d pglEvalCoord1d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord1dv(double* u);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord1dv pglEvalCoord1dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord1f(float u);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord1f pglEvalCoord1f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord1fv(float* u);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord1fv pglEvalCoord1fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord2d(double u, double v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord2d pglEvalCoord2d;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord2dv(double* u);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord2dv pglEvalCoord2dv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord2f(float u, float v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord2f pglEvalCoord2f;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalCoord2fv(float* u);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalCoord2fv pglEvalCoord2fv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalMesh1(int mode, int i1, int i2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalMesh1 pglEvalMesh1;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalPoint1(int i);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalPoint1 pglEvalPoint1;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalMesh2(int mode, int i1, int i2, int j1, int j2);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalMesh2 pglEvalMesh2;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glEvalPoint2(int i, int j);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glEvalPoint2 pglEvalPoint2;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glAlphaFunc(int func, float @ref);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glAlphaFunc pglAlphaFunc;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelZoom(float xfactor, float yfactor);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPixelZoom pglPixelZoom;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelTransferf(int pname, float param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPixelTransferf pglPixelTransferf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelTransferi(int pname, int param);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPixelTransferi pglPixelTransferi;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelMapfv(int map, int mapsize, float* values);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPixelMapfv pglPixelMapfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelMapuiv(int map, int mapsize, uint* values);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPixelMapuiv pglPixelMapuiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPixelMapusv(int map, int mapsize, ushort* values);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPixelMapusv pglPixelMapusv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glCopyPixels(int x, int y, int width, int height, int type);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glCopyPixels pglCopyPixels;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glDrawPixels(int width, int height, int format, int type, IntPtr pixels);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glDrawPixels pglDrawPixels;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetClipPlane(int plane, double* equation);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetClipPlane pglGetClipPlane;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetLightfv(int light, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetLightfv pglGetLightfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetLightiv(int light, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetLightiv pglGetLightiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetMapdv(int target, int query, double* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetMapdv pglGetMapdv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetMapfv(int target, int query, float* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetMapfv pglGetMapfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetMapiv(int target, int query, int* v);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetMapiv pglGetMapiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetMaterialfv(int face, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetMaterialfv pglGetMaterialfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetMaterialiv(int face, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetMaterialiv pglGetMaterialiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetPixelMapfv(int map, float* values);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetPixelMapfv pglGetPixelMapfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetPixelMapuiv(int map, uint* values);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetPixelMapuiv pglGetPixelMapuiv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetPixelMapusv(int map, ushort* values);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetPixelMapusv pglGetPixelMapusv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetPolygonStipple(byte* mask);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetPolygonStipple pglGetPolygonStipple;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexEnvfv(int target, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetTexEnvfv pglGetTexEnvfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexEnviv(int target, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetTexEnviv pglGetTexEnviv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexGendv(int coord, int pname, double* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetTexGendv pglGetTexGendv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexGenfv(int coord, int pname, float* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetTexGenfv pglGetTexGenfv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glGetTexGeniv(int coord, int pname, int* @params);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glGetTexGeniv pglGetTexGeniv;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.I1)]
            internal delegate bool glIsList(uint list);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glIsList pglIsList;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glFrustum pglFrustum;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLoadIdentity();

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLoadIdentity pglLoadIdentity;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLoadMatrixf(float* m);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLoadMatrixf pglLoadMatrixf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glLoadMatrixd(double* m);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glLoadMatrixd pglLoadMatrixd;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMatrixMode(int mode);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMatrixMode pglMatrixMode;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultMatrixf(float* m);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultMatrixf pglMultMatrixf;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glMultMatrixd(double* m);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glMultMatrixd pglMultMatrixd;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glOrtho pglOrtho;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPopMatrix();

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPopMatrix pglPopMatrix;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glPushMatrix();

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glPushMatrix pglPushMatrix;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRotated(double angle, double x, double y, double z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRotated pglRotated;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glRotatef(float angle, float x, float y, float z);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glRotatef pglRotatef;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glScaled(double x, double y, double z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glScaled pglScaled;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glScalef(float x, float y, float z);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glScalef pglScalef;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTranslated(double x, double y, double z);

            [RequiredByFeature("GL_VERSION_1_0")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTranslated pglTranslated;

            [RequiredByFeature("GL_VERSION_1_0")]
            [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
            [RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
            [SuppressUnmanagedCodeSecurity]
            internal delegate void glTranslatef(float x, float y, float z);

            [RequiredByFeature("GL_VERSION_1_0")] [RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")] [RemovedByFeature("GL_VERSION_3_2", Profile = "core")] [ThreadStatic]
            internal static glTranslatef pglTranslatef;
        }
    }
}