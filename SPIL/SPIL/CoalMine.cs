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
    public class CoalMine : GameObject
    {
		public static Semaphore collectorCoalAccess = new Semaphore(0, 5);
		
		int amount = 1000;

        public int Amount
        {
            get { return amount; }
            set {
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
        public CoalMine()
        {
            Thread coalMineThread = new Thread(coalMineMethod);
            coalMineThread.IsBackground = true;
            coalMineThread.Start();

			collectorCoalAccess.Release(5);

			sprite = Assets.CoalMine;
            position = new Vector2((960/2+50), 40);
        }

        private void coalMineMethod()
        {
            while (true)
            {
                Thread.Sleep(500);
                amount += 10;
            }
        }
		public void CollectCoal()
		{

			collectorCoalAccess.WaitOne();
			Thread.Sleep(5000);
			amount -= 10;
			GameWorld.Sslave.carriedCoal += 10;
			Console.WriteLine(amount);
			
			collectorCoalAccess.Release();
		}
	}
}
