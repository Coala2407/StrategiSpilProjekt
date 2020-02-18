using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SPIL
{
	class Collector : GameObject
	{
		delegate void DelegateResources(int a);
		void Start()
		{
			DelegateResources myDelegate = Resources;
		}

		protected Vector2 velocity;
		protected float moveSpeed;
		protected Vector2 position;

		public Collector()
		{

		}

		public override void Update(GameTime gameTime)
		{

		}
		public override void OnCollision(GameObject otherObject)
		{
			
		}
		private void Move(GameTime gameTime)
		{
			float deltaTime= (float)gameTime.ElapsedGameTime.TotalSeconds;
			position += ((velocity * moveSpeed) * deltaTime);
		}
		protected void Resources(int a) 
		{ 
			
		}

	}
}
