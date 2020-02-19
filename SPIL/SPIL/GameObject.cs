using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPIL
{
    public abstract class GameObject
    {
        public Vector2 position;

        protected float drawLayer = 0.01f;

        protected float rotation;

        protected float size = 1;

        protected string name;

        protected Vector2 origin;

        protected Texture2D sprite;

        protected bool spriteFlippedX;

        protected bool spriteFlippedY;

		public Rectangle collisionBox;

		public bool DebugIsColliding;

        protected SpriteFont font;


		/// <summary>
		/// Runs on collision with other objects
		/// </summary>
		/// <param name="otherObject"></param>
		public abstract void OnCollision(GameObject otherObject);

        /// <summary>
        /// Draw object sprite
        /// </summary>
        /// <param name="spriteBatch"></param>
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (sprite != null)
            {
                SpriteEffects effect = SpriteEffects.None;
                if (spriteFlippedX)
                {
                    effect = SpriteEffects.FlipVertically;
                }
                else if (spriteFlippedY)
                {
                    effect = SpriteEffects.FlipHorizontally;

                }
                spriteBatch.Draw(sprite, position, null, Color.White, MathHelper.ToRadians(rotation), origin, size, effect, drawLayer);
            }
        }

        /// <summary>
        /// Create the collision box
        /// </summary>
        /// <returns></returns>
        public Rectangle GetCollisionBox()
        {
            if (sprite != null)
            {
                return new Rectangle((int)position.X - (int)origin.X, (int)position.Y - (int)origin.Y, sprite.Width, sprite.Height);
            }
            else
            {
                return new Rectangle();
            }
        }

        /// <summary>
        /// Check for collisions with other objects
        /// </summary>
        /// <param name="otherObject"></param>
        public virtual void CheckCollision(GameObject otherObject)
        {
            if (GetCollisionBox().Intersects(otherObject.GetCollisionBox()))
            {
                OnCollision(otherObject);
            }
        }
    }
}
