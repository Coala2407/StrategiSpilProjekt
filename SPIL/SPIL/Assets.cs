using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPIL
{
   public static class Assets
    {
        public static Texture2D BankSprite;
		public static Texture2D SlaveSprite;

        public static void LoadContent(ContentManager content)
        {
            BankSprite = content.Load<Texture2D>("bank");
			SlaveSprite = content.Load<Texture2D>("miner");
        }
    }
}
