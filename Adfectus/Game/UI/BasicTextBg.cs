﻿#region Using

using System.Numerics;
using Adfectus.Common;
using Adfectus.Graphics.Text;
using Adfectus.Primitives;

#endregion

namespace Adfectus.Game.UI
{
    public class BasicTextBg : BasicText
    {
        #region Properties

        /// <summary>
        /// The color of the text's background.
        /// </summary>
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// The background's padding.
        /// </summary>
        public Rectangle Padding { get; set; }

        #endregion

        public BasicTextBg(Font font, uint textSize, string text, Color color, Vector3 position) : base(font, textSize, text, color, position)
        {
            BackgroundColor = Color.Black;
        }

        public BasicTextBg(Font font, uint textSize, string text, Color color, Color backgroundColor, Vector3 position) : base(font, textSize, text, color, position)
        {
            BackgroundColor = backgroundColor;
        }

        public override void Render()
        {
            if (_updateSize)
            {
                Atlas atlas = _font.GetFontAtlas(_textSize);
                Vector2 size = atlas.MeasureString(Text);
                Size = size;
                Width += Padding.X + Padding.Width;
                Height += Padding.Y + Padding.Height;
                _updateSize = false;
            }

            Engine.Renderer.Render(Vector3.Zero, new Vector2(Width, Height), BackgroundColor);
            Engine.Renderer.RenderString(_font.GetFontAtlas(_textSize), _text, new Vector3(Padding.X, Padding.Y, 0), Color);
        }
    }
}