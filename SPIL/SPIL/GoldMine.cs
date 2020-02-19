using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace SPIL
{
    class GoldMine : GameObject
    {
        int amount = 1000;

        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                if (amount < 0)
                {
                    amount = 0;
                }
            }
        }

        public override void OnCollision(GameObject otherObject)
        {

        }
        public GoldMine()
        {
            Thread goldMineThread = new Thread(GoldMineMethod);
            goldMineThread.Start();
            sprite = Assets.GoldMine;
            size = 0.5f;
            position = new Vector2(960 / 2 + 40, 540 / 2-20);
        }
        private void GoldMineMethod()
        {
            while (true)
            {
                Thread.Sleep(500);
                amount += 10;
            }
        }
    }
}
