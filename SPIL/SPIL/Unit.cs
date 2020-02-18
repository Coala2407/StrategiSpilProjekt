using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class Unit : GameObject
    {
        int health;
        
        bool alive = true;

        float speed;

        int goldTaken;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public bool IsDead
        {
            get { return health <= 0; }
        }

        public int GoldTaken
        {
            get { return goldTaken; }
        }

        public Unit(Texture2D texture, Vector2 position, int health, int goldTaken, float speed)
        {
            this.health = health;
            this.goldTaken = goldTaken;
            this.speed = speed;
        }

        public override void OnCollision(GameObject otherObject)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            if(health <= 0)
            {
                alive = false;
            }


        }
    }
}
