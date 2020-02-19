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
    class FontCoal : GameObject
    {
        public int coalCurrency = 0;
        public FontCoal()
        {
            Thread fontThread = new Thread(fontMethod);
            fontThread.Start();            
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
    }
}
