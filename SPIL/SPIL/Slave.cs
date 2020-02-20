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
		public bool hasCollided = false;

		protected int Coal;
		public int carriedCoal;
		public bool carryingCoal;

		protected int Gold;
		public int carriedGold;
		public bool carryingGold;

		protected int Diamond;
		public int carriedDiamond;
		public bool carryingDiamond;

		protected Vector2 velocity;
		protected Vector2 walkDir;
		protected string name;


		public Slave(Vector2 position, string name)
		{
			this.position = position;
			this.name = name;
			sprite = Assets.SlaveSprite;

			collisionBox = new Rectangle(0, 0, sprite.Width, sprite.Height);

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
							CheckCollision(GameWorld.CcoalMine);

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
							CheckCollision(GameWorld.Bwank);

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
							CheckCollision(GameWorld.GgoldMine);
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
							CheckCollision(GameWorld.Bwank);
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
							CheckCollision(GameWorld.DdiamondMine);
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
							CheckCollision(GameWorld.Bwank);

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
			UpdateCollisionBox();
		}
		public override void OnCollision(GameObject otherObject)
		{
			switch (name)
			{
				case "CoalMiner":
			        if (hasCollided == false)
					{
						if (otherObject is CoalMine)
						{
							GameWorld.CcoalMine.CollectCoal();
							carryingCoal = true;
							hasCollided = true;
						}
					}
					hasCollided = false;
					if (hasCollided == false)
					{
						if (otherObject is Bank)
						{

							GameWorld.fontCoal.CoalDeposit();
							carriedCoal -= 10;
							carryingCoal = false;
						}

					}
					break;
				case "GoldMiner":

					if (hasCollided == false)
					{
						if (otherObject is GoldMine)
						{
							GameWorld.GgoldMine.CollectGold();
							carryingGold = true;
							hasCollided = true;
						}
					}
					hasCollided = false;
					if (otherObject is Bank)
					{
						GameWorld.fontGold.GoldDeposit();
						carriedGold -= 10;
						carryingGold = false;
					}
					break;
				case "DiamondMiner":
					
					if(hasCollided == false)
					{
						if (otherObject is DiamondMine)
						{
							GameWorld.DdiamondMine.CollectDiamond();
							carryingDiamond = true;
							hasCollided = true;
						}
					}
					hasCollided = false;
					if(otherObject is Bank)
					{
						GameWorld.fontDiamond.DiamondDeposit();
						carriedDiamond -= 10;
						carryingDiamond = false;
					}
					break;
			}
		}
		protected void UpdateCollisionBox()
		{
			collisionBox.X = (int)position.X;
			collisionBox.Y = (int)position.Y;
		}
	}
}
