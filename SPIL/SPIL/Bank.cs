using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    class Bank : GameObject
    {
        public Bank()
        {
            Thread bankThread = new Thread(RunBank);
            bankThread.Start();
            sprite = Assets.BankSprite;
        }

        private void RunBank()
        {
            //Do some banking, mate
            while (true)
            {
                
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        public override void OnCollision(GameObject otherObject)
        {
            
        }
    }
}
