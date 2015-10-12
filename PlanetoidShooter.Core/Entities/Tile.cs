using System;
using Nucleus;
using Nucleus.Ecs.Components;
using Nucleus.Ecs;

namespace PlanetoidShooter.Core.Entities
{
    public class Tile : Entity
    {
        public Tile(int x, int y, int tileWidth, int tileHeight, bool isWall)
        {
            var s = new SpriteSheetComponent("Tiles", tileWidth, tileHeight);
            if (!isWall)
            {
                s.CurrentFrame = 1;
            }
            this.Add(new TwoDComponent(x * tileWidth, y * tileHeight));
            this.Add(s);
        }
    }
}

