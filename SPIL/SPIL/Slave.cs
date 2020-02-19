using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
	public class Slave
	{
		protected List<Texture2D> Currentspritesheet = new List<Texture2D>();

		protected Texture2D currentSprite;
		public bool setToIdle = true;
		protected float animTime;
		public float speed = 0.00001f;
		private int spriteIndex;		
		protected Vector2 position;

		protected int Coal;
		protected int carriedCoal;
		protected bool carryingCoal;

		protected int Gold;
		protected int carriedGold;
		protected bool carryingGold;

		protected int Diamond;
		protected int carriedDiamond;
		protected bool carryingDiamond;

		protected Vector2 velocity;
		protected string name;
		

		public Slave(Vector2 position, string name)
		{
			this.position = position;
			this.name = name;
			 
			//sprite = Assets.PirateWalkU[spriteIndex];

			Thread collectorAI = new Thread(CollectorAI);
			collectorAI.Start();
		}

		public void Update(GameTime gameTime)
		{

			Move(gameTime);

		}

		public void OnCollision(GameObject otherObject)
		{
			if (true)
			{

			}
		}
		
		private void CollectorAI()
		{
			bool isDead = false;
			while (isDead == false)
			{
				switch (name)
				{
					case "CoalMiner":
						while (carryingCoal == false)
						{
							velocity += new Vector2( 0, 0);
							Thread.Sleep(10);
							
						}
						while (carryingCoal == true)
						{
							velocity += new Vector2((float)1, 0);
							Thread.Sleep(10);

						}
						break;

					case "GoldMiner":
						while (carryingGold == false)
						{
							velocity += new Vector2((float)1, 0);
						}
						break;

					case "DiamondMiner":
						while (carryingDiamond == false)
						{
							velocity += new Vector2((float)1, 0);
						}
						break;
				}
			}
			Thread.Sleep(10);
		}
		private void Move(GameTime gameTime)
		{
			float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
			position += ((velocity * speed) * deltaTime);
		}
		public static bool CheckCollision(GameObject object1, GameObject object2)
		{
			if (object1.collisionBox.Intersects(object2.collisionBox))
			{
				object1.DebugIsColliding = true;
				return true;
			}
			else
			{
				return false;
			}

		}
	}
}
