﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class Coal : GameObject
    {
        public override void OnCollision(GameObject otherObject)
        {

        }
        public Coal()
        {
            Thread coalThread = new Thread(CoalMethod);
            coalThread.Start();
            sprite = Assets.CoalCurrency;
        }

        private void CoalMethod()
        {
            //do something
        }
    }
}
