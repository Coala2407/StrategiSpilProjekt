using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SPIL
{
    public class Bank : GameObject

    {		

        public Bank()
        {
            Thread bankThread = new Thread(RunBank);
            bankThread.IsBackground = true;
            bankThread.Start();
            sprite = Assets.BankSprite;
            size = .12f;
            position.Y = GameWorld.WindowHeight / 2 - 50;
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
