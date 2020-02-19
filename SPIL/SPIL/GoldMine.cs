using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class GoldMine : GameObject
    {
        public override void OnCollision(GameObject otherObject)
        {

        }
        public GoldMine()
        {
            Thread goldMineThread = new Thread(GoldMineMethod);
            goldMineThread.Start();
            sprite = Assets.GoldMine;
        }
        private void GoldMineMethod()
        {
            //do something
        }
    }
}
