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
		public static List<Texture2D> GrassTile1 = new List<Texture2D>();
		public static List<Texture2D> GrassTile2 = new List<Texture2D>();
		public static List<Texture2D> GrassTile3 = new List<Texture2D>();
		public static List<Texture2D> SandTile = new List<Texture2D>();

		/// <summary>
		/// Her bliver de individuelle sprites tilføjet til deres egen liste som "PlayerCharWalkingRight"
		/// </summary>
		/// <param name="content"></param>
		public static void LoadContent(ContentManager content)
		{
			int elapsedTime = 0;
			int i = 0;


			GrassTile1.Add(content.Load<Texture2D>("PlayableCharacter/grass_tile_1"));
			GrassTile2.Add(content.Load<Texture2D>("PlayableCharacter/grass_tile_2"));
			GrassTile3.Add(content.Load<Texture2D>("PlayableCharacter/grass_tile_3"));
			SandTile.Add(content.Load<Texture2D>("PlayableCharacter/sand_tile"));


		}

	}
}
