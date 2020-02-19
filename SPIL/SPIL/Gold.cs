using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class Gold : GameObject
    {
        public override void OnCollision(GameObject otherObject)
        {

        }
        public Gold()
        {
            Thread goldThread = new Thread(GoldMethod);
            goldThread.Start();
            sprite = Assets.GoldCurrency;
        }
        private void GoldMethod()
        {
            //do something
        }
    }
}
