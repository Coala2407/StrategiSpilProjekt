using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SPIL
{
	public static class Assets
	{
		/// <summary>
		/// Her bliver listerne der skal indeholde spritesne til animationerne lavet
		/// </summary>
		public static List<Texture2D> PirateWalkR = new List<Texture2D>();
		public static List<Texture2D> PirateWalkU = new List<Texture2D>();
		public static List<Texture2D> PirateWalkD = new List<Texture2D>();
        public static List<Texture2D> TileSprites = new List<Texture2D>();
        public static Texture2D UIBackground;
        /// <summary>
        /// Her bliver de individuelle sprites tilføjet til deres egen liste som "PlayerCharWalkingRight"
        /// </summary>
        /// <param name="content"></param>
        public static void LoadContent(ContentManager content)
		{
			int elapsedTime = 0;
			int i = 0;

			PirateWalkR.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingRight1"));
			PirateWalkR.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingRight2"));
			PirateWalkR.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingRight1"));
			PirateWalkR.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingRight3"));

			PirateWalkU.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingUp1"));
			PirateWalkU.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingUp2"));
			PirateWalkU.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingUp3"));
			PirateWalkU.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingUp2"));

			PirateWalkD.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingDown1"));
			PirateWalkD.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingDown2"));
			PirateWalkD.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingDown3"));
			PirateWalkD.Add(content.Load<Texture2D>("PirateWalkingAnims/PirateWalkingDown2"));

            TileSprites.Add(content.Load<Texture2D>("TileTextures/grass_tile_1"));
            TileSprites.Add(content.Load<Texture2D>("TileTextures/grass_tile_2"));
            TileSprites.Add(content.Load<Texture2D>("TileTextures/grass_tile_3"));
            TileSprites.Add(content.Load<Texture2D>("TileTextures/sand_tile"));
            TileSprites.Add(content.Load<Texture2D>("TileTextures/water_tile"));

            UIBackground = content.Load<Texture2D>("BlurredPlanks");
        }
	}
}
