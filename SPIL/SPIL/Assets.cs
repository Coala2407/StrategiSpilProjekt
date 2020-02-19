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
        public static Texture2D CoalMine;
        public static Texture2D CoalCurrency;
        public static Texture2D GoldMine;
        public static Texture2D GoldCurrency;
        public static Texture2D DiamondMine;
        public static Texture2D DiamondCurrency;

        public static SpriteFont font;
        

        public static void LoadContent(ContentManager content)
        {
            BankSprite = content.Load<Texture2D>("bank");

            SlaveSprite = content.Load<Texture2D>("sprite_16");

            CoalMine = content.Load<Texture2D>("coal mine");
            GoldMine = content.Load<Texture2D>("gold mine");
            DiamondMine = content.Load<Texture2D>("diamond mine");

            CoalCurrency = content.Load<Texture2D>("coal currency");
            GoldCurrency = content.Load<Texture2D>("gold currency");
            DiamondCurrency = content.Load<Texture2D>("diamond currency");

            font = content.Load<SpriteFont>("File");
        }
    }
}
