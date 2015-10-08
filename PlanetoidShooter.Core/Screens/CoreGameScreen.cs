using System;
using Nucleus;
using Microsoft.Xna.Framework.Graphics;

namespace PlanetoidShooter.Core
{
    public class CoreGameScreen : Screen
    {
        public override void Initialize()
        {
            base.Initialize();
            this.Add(new SpriteComponent("Icon"));
        }
    }
}

