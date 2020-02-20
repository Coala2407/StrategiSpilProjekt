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
   public class FontCoal : GameObject
    {
		public static Semaphore depositCoalAccess = new Semaphore(0, 5);
		public int coalCurrency = 1;
        public FontCoal()
        {
            Thread fontThread = new Thread(fontMethod);
            fontThread.Start();

			depositCoalAccess.Release(5);
        }
        private void fontMethod()
        {
            //coalCurrency++;
        }
        public override void OnCollision(GameObject otherObject)
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
            spriteBatch.DrawString(Assets.font, $"{coalCurrency}", new Vector2(875, 25), Color.Black);
        }

		public void CoalDeposit()
		{
			depositCoalAccess.WaitOne();
			Thread.Sleep(2500);
			GameWorld.Sslave.carriedCoal -= 10;
			coalCurrency += 10;
			depositCoalAccess.Release();
		}
    }
}
