using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class CoalMine : GameObject
    {
        public override void OnCollision(GameObject otherObject)
        {

        }
        public CoalMine()
        {
            Thread coalMineThread = new Thread(coalMineMethod);
            coalMineThread.Start();
            sprite = Assets.CoalMine;
        }
        private void coalMineMethod()
        {
            //do something
        }
    }
}
