﻿namespace Adfectus.Scenography
{
    /// <summary>
    /// A single scene.
    /// </summary>
    public abstract class Scene
    {
        /// <summary>
        /// Is run when the scene is loading.
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// Is run every tick while the window is focused.
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// Is run every frame while the window is focused.
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// Is run when the scene is unloading.
        /// </summary>
        public abstract void Unload();

        /// <summary>
        /// Is run when the host is unfocused.
        /// </summary>
        public virtual void NoFocusUpdate()
        {
        }

        /// <summary>
        /// Is run after the internal FBO is flushed to the window.
        /// Any drawing in this function will happen directly on the window rather than the internal fbo.
        /// </summary>
        public virtual void DirectDraw()
        {

        }
    }
}