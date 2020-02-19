using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

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
            position = new Vector2(795, 10);
        }

        private void CoalMethod()
        {
            //do something
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
