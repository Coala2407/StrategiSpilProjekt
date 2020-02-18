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

        Vector2 velocity;

        int goldTaken;

        Texture2D texture;
        

        private Queue<Vector2> waypoints = new Queue<Vector2>();

        public float DestinationDistance
        {
            get { return Vector2.Distance(position, waypoints.Peek()); }
        }

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

        public Unit()
        {

        }

        public Unit(Vector2 position, int health, int goldTaken, float speed)
        {
            this.health = health;
            this.goldTaken = goldTaken;
            this.speed = speed;
            this.position = position;
        }


        public void SetWaypoints(Queue<Vector2> waypoints)
        {
            foreach(Vector2 waypoint in waypoints)
            {
                this.waypoints.Enqueue(waypoint);
            }
            this.position = this.waypoints.Dequeue();
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

            if(waypoints.Count > 0)
            {
                if(DestinationDistance < speed)
                {
                    position = waypoints.Peek();
                    waypoints.Dequeue();
                }
                else
                {
                    Vector2 direction = waypoints.Peek() - position;
                    direction.Normalize();

                    velocity = Vector2.Multiply(direction, speed);

                    position += velocity;
                }
            }
            else
            {
                alive = false;
            }


        }
    }
}
