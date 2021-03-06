﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace SPIL
{
    public class GoldMine : GameObject
    {
		public static Semaphore collectorGoldAccess = new Semaphore(0, 5);
		int amount = 500;

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
            goldMineThread.IsBackground = true;
            goldMineThread.Start();

			collectorGoldAccess.Release(5);

            sprite = Assets.GoldMine;
            position = new Vector2(970 / 2 + 40, 490 / 2-20);
        }
        private void GoldMineMethod()
        {
            while (true)
            {
                Thread.Sleep(500);
                amount += 5;
            }
        }

		public void CollectGold()
		{
			collectorGoldAccess.WaitOne();
			Thread.Sleep(5000);
			amount -= 5;
			GameWorld.Sslave.carriedGold += 5;
			Console.WriteLine(amount);

			collectorGoldAccess.Release();
		}
    }
}
