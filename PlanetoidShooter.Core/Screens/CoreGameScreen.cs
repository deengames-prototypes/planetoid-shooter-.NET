using System;
using Nucleus;
using Microsoft.Xna.Framework.Graphics;
using Nucleus.Core;
using Nucleus.Ecs.Components;
using Nucleus.Ecs;
using PlanetoidShooter.Core.Entities;

namespace PlanetoidShooter.Core
{
    public class CoreGameScreen : Screen
    {
        private const int TileWidth = 32;
        private const int TileHeight = 32;

        public override void Initialize()
        {
            base.Initialize();
            int widthInTiles = (int)Math.Ceiling(1d * this.Width / TileWidth);
            int heightInTiles = (int)Math.Ceiling(1d * this.Height / TileHeight);

            for (int y = 0; y < heightInTiles; y++)
            {
                for (int x = 0; x < widthInTiles; x++)
                {
                    bool isWall = (x == 0 || y == 0 || x == widthInTiles - 1 || y == heightInTiles - 1);
                    this.Add(new Tile(x, y, TileWidth, TileHeight, isWall));
                }
            }
        }
    }
}

