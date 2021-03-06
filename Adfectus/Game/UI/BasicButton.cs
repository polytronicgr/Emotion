﻿#region Using

using System;
using System.Numerics;
using Adfectus.Common;
using Adfectus.Graphics;
using Adfectus.Input;
using Adfectus.Primitives;

#endregion

namespace Adfectus.Game.UI
{
    public class BasicButton : Control
    {
        /// <summary>
        /// The texture of the button.
        /// </summary>
        public Texture Texture { get; set; }

        /// <summary>
        /// The tint of the button's texture.
        /// </summary>
        public Color Tint { get; set; } = Color.White;

        /// <summary>
        /// The event to trigger when the button is clicked.
        /// </summary>
        public Action OnClick { get; set; }

        public BasicButton(Vector3 position, Vector2 size) : base(position, size)
        {
        }

        public override void MouseDown(MouseKey key)
        {
            OnClick?.Invoke();
        }

        public override void Render()
        {
            Engine.Renderer.Render(Vector3.Zero, Size, Tint, Texture);
        }
    }
}