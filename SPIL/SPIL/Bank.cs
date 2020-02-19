using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    public class Bank : GameObject
    {
        private int coalCurrency = 0;
        private int goldCurrency = 0;
        private int diamondCurrency = 0;

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
