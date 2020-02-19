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
	public class Slave : GameObject
	{
		protected List<Texture2D> Currentspritesheet = new List<Texture2D>();

		protected Texture2D currentSprite;
		public bool setToIdle = true;
		protected float animTime;
		public float speed = 10f;
				
		

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
		protected Vector2 walkDir;
		protected string name;
		

		public Slave(Vector2 position, string name)
		{
			this.position = position;
			this.name = name;
			sprite = Assets.SlaveSprite;
			 
			Thread collectorAI = new Thread(CollectorAI);
            collectorAI.IsBackground = true;
			collectorAI.Start();
		}

		public void Update(GameTime gameTime)
		{

			Move(gameTime);

		}
	
		public void CollectorAI()
		{
			bool isDead = false;
			while (isDead == false)
			{
				switch (name)
				{
					case "CoalMiner":
						while (carryingCoal == false)
						{
							walkDir = GameWorld.CcoalMine.position - position;
							if (walkDir != Vector2.Zero)
							{
								walkDir.Normalize();
							}
							position += walkDir;						
							Thread.Sleep((int)speed);							
						}
						while (carryingCoal == true)
						{
							walkDir = GameWorld.Bwank.position - position;
							if (walkDir != Vector2.Zero)
							{
								walkDir.Normalize();
							}
							position += walkDir;
							Thread.Sleep((int)speed);
						}
						break;

					case "GoldMiner":
						while (carryingGold == false)
						{
							walkDir = GameWorld.GgoldMine.position - position;
							if (walkDir != Vector2.Zero)
							{
								walkDir.Normalize();
							}
							position += walkDir;
							Thread.Sleep((int)speed);
						}
						while (carryingGold == true)
						{
							walkDir = GameWorld.Bwank.position - position;
							if (walkDir != Vector2.Zero)
							{
								walkDir.Normalize();
							}
							position += walkDir;
							Thread.Sleep((int)speed);
						}
						break;

					case "DiamondMiner":
						while (carryingDiamond == false)
						{
							walkDir = GameWorld.DdiamondMine.position - position;
							if (walkDir != Vector2.Zero)
							{
								walkDir.Normalize();
							}
							position += walkDir;
							Thread.Sleep((int)speed);
                            
                        }
						while (carryingDiamond == true)
						{
							walkDir = GameWorld.Bwank.position - position;
							if (walkDir != Vector2.Zero)
							{
								walkDir.Normalize();
							}
							position += walkDir;
							Thread.Sleep((int)speed);
                            
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
		public override void OnCollision(GameObject otherObject)
		{
			
		}
	}
}
