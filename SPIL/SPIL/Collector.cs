using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
	class Collector : GameObject
	{
		protected List<Texture2D> Currentspritesheet = new List<Texture2D>();
		public bool setToIdle = true;
		protected Texture2D currentSprite;
		protected float animTime;
		private int spriteIndex;
		public Collector(Vector2 position)
		{
			this.position = position;

			size = 1;
			sprite = Assets.PirateWalkU[spriteIndex];
			
		}

		public override void Update(GameTime gameTime)
		{

			
		}
		
		public override void OnCollision(GameObject otherObject)
		{
			
		}
		
	}
}
