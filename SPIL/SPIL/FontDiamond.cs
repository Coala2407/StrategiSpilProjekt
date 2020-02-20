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
    public class FontDiamond : GameObject
    {
        public int diamondCurrency = 0;
		public static Semaphore depositDiamondAccess = new Semaphore(0, 5);
		SpriteFont spriteFont;
        public FontDiamond()
        {
            Thread fontThread = new Thread(fontMethod);
            fontThread.Start();

			depositDiamondAccess.Release(5);
        }
        private void fontMethod()
        {
            //diamondCurrency++;
        }
        public override void OnCollision(GameObject otherObject)
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
            spriteBatch.DrawString(Assets.font, $"{diamondCurrency}", new Vector2(875, 150), Color.Black);
        }
		public void DiamondDeposit()
		{
			depositDiamondAccess.WaitOne();
			Thread.Sleep(1000);
			GameWorld.Sslave.carriedDiamond -= 1;
			diamondCurrency += 1;
			depositDiamondAccess.Release();
		}
	}
}
