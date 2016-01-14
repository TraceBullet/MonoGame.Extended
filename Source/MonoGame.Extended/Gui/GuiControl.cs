﻿using Microsoft.Xna.Framework;
using MonoGame.Extended.Shapes;

namespace MonoGame.Extended.Gui
{
    public abstract class GuiControl : IUpdate
    {
        public abstract IShapeF Shape { get; set; }
        public virtual void Update(GameTime gameTime) { }
    }
}