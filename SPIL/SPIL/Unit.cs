using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SPIL
{
    class Unit : GameObject
    {
        int health = 4;
        
        bool alive = true;

        float speed = 0.5f;

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
