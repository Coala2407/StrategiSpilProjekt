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
    class FontCreateSlave : GameObject
    {
        public FontCreateSlave()
        {
            Thread fontCreateSlaveThread = new Thread(FontCreateSlaveMethod);
            fontCreateSlaveThread.Start();
        }
        private void FontCreateSlaveMethod()
        {
            //stuff
        }
        public override void OnCollision(GameObject otherObject)
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
            spriteBatch.DrawString(Assets.font, "Spawn Miners: 1: Coal Miner. ~ 2: Gold Miner ~ 3: Diamond Miner \nPrices: Coal Miner: 1 coal. ~ Gold Miner: 5 coal. ~ Diamond Miner: 10 gold.", new Vector2((1), 500), Color.Black);
        }
    }
}
