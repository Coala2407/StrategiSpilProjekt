using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class DiamondMine : GameObject
    {
        public override void OnCollision(GameObject otherObject)
        {

        }
        public DiamondMine()
        {
            Thread diamondMineThread = new Thread(DiamondMineMethod);
            diamondMineThread.Start();
            sprite = Assets.DiamondMine;
        }
        private void DiamondMineMethod()
        {
            //do something
        }
    }
}
