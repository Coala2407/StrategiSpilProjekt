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
    class DiamondMine : GameObject
    {
        int amount = 100;

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
        public DiamondMine()
        {
            Thread diamondMineThread = new Thread(DiamondMineMethod);
            diamondMineThread.IsBackground = true;
            diamondMineThread.Start();
            sprite = Assets.DiamondMine;
            size = 0.3f;
            position = new Vector2(960 / 2 + 30,450);
        }
        private void DiamondMineMethod()
        {
            while (true)
            {
                Thread.Sleep(500);
                amount += 1;
            }
        }
    }
}
