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
        private Entity e;

        public override void Initialize()
        {
            base.Initialize();
            e = new Entity();
            e.Add(new ImageComponent("Icon"));
            e.Add(new TwoDComponent(50, 50));
            this.Add(e);
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            e.Get<TwoDComponent>().Rotation += 1;
        }
    }
}

