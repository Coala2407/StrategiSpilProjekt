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
   public class FontGold : GameObject
    {
        public int goldCurrency = 10;
        public FontGold()
        {
            Thread fontThread = new Thread(fontMethod);
            fontThread.Start();
        }
        private void fontMethod()
        {
            //goldCurrency++;
        }
        public override void OnCollision(GameObject otherObject)
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
            spriteBatch.DrawString(Assets.font, $"{goldCurrency}", new Vector2(875, 88), Color.Black);
        }
    }
}
