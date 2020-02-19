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
	class Slave
	{
		protected List<Texture2D> Currentspritesheet = new List<Texture2D>();

		protected Texture2D currentSprite;
		public bool setToIdle = true;
		protected float animTime;
		public float speed = 0.00001f;
		private int spriteIndex;
		protected int doubloon;
		protected int carriedDoubloons;
		protected bool carryingDoubloons;
		protected Vector2 position;

		protected int salvage;
		protected int carriedSalvage;
		protected bool carryingSalvage;

		protected Vector2 velocity;
		protected string name;

		public Slave(Vector2 position, string name)
		{
			this.position = position;
			this.name = name;
			size = 1;
			//sprite = Assets.PirateWalkU[spriteIndex];

			Thread collectorAI = new Thread(CollectorAI);
			collectorAI.Start();
		}

		public void Update(GameTime gameTime)
		{

			Move(gameTime);

		}

		public override void OnCollision(GameObject otherObject)
		{

		}
		private void CollectorAI()
		{
			bool isDead = false;
			while (isDead == false)
			{
				switch (name)
				{
					case "collector":
						while (carryingDoubloons == false)
						{
							velocity += new Vector2((float)1, 0);
						}
						break;

					case "Salvager":
						while (carryingSalvage == false)
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

	}
}
