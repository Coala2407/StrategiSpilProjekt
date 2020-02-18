using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace SPIL
{
    class Level
    {
        public void UnitSpawner()
        {
            //GameWorld.AddGameObject(GameObject )
        }
        private Queue<Vector2> waypoints = new Queue<Vector2>();

        public Level()
        {
            waypoints.Enqueue(new Vector2(0, 1) * 32);
            waypoints.Enqueue(new Vector2(4, 1) * 32);
            waypoints.Enqueue(new Vector2(4, 16) * 32);
        }

        public Queue<Vector2> Waypoints
        {
            get { return waypoints; }
        }
        
		/*
		public void UnitSpawner()

        public void UnitSpawner()*/

		

    }

}
