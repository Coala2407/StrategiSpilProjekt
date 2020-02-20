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
            position = new Vector2(800, 75);
        }
        private void GoldMethod()
        {
            //do something
        }
    }
}
