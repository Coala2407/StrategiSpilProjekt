﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

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
            size = 0.2f;
            position = new Vector2(795, 135);
        }

        private void CoalMethod()
        {
            //do something
        }
    }
}
