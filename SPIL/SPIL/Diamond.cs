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
    class Diamond : GameObject
    {
        public override void OnCollision(GameObject otherObject)
        {

        }
        public Diamond()
        {
            Thread diamondThread = new Thread(DiamondMethod);
            diamondThread.Start();
            sprite = Assets.DiamondCurrency;
            position = new Vector2(800, 135); 
        }
        private void DiamondMethod()
        {
            //do something
        }
    }
}
