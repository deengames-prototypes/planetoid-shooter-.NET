#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Nucleus;
using Nucleus.Core;

#endregion

namespace PlanetoidShooter.Core
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : CommonGame
	{
        protected override void Initialize()
        {
            base.Initialize();
            Screen.ShowScreen(new CoreGameScreen());
        }
	}
}

