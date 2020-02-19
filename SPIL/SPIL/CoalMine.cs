using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace SPIL
{
    public class CoalMine : GameObject
    {
        public override void OnCollision(GameObject otherObject)
        {

        }
        public CoalMine()
        {
            Thread coalMineThread = new Thread(coalMineMethod);
            coalMineThread.Start();
            sprite = Assets.CoalMine;
            size = 0.2f;
            position = new Vector2((960/2+50), 50);
        }
        private void coalMineMethod()
        {
            //do something
        }
    }
}
