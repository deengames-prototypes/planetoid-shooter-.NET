using System;
using Nucleus;
using Microsoft.Xna.Framework.Graphics;
using Nucleus.Core;
using Nucleus.Ecs.Components;
using Nucleus.Ecs;

namespace PlanetoidShooter.Core
{
    public class CoreGameScreen : Screen
    {
        public override void Initialize()
        {
            base.Initialize();
            var e = new Entity();
            e.Add(new ImageComponent("Icon"));
            e.Add(new TwoDComponent(100, 50));
            this.Add(e);
        }
    }
}

