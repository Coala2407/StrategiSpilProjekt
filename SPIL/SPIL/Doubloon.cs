using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPIL
{
    class Doubloon
    {
        /// <summary>
        /// Ammount of Doubloons the player has
        /// </summary>
        int ammount;
        public int Ammount { get; set; }

        public void GiveDoubloon(int ammountToGive)
        {
            Ammount += ammountToGive;
        }

        public void RemoveDoubloon(int ammountToRemove)
        {
            Ammount -= ammountToRemove;
            if (Ammount < 0)
            {
                Ammount = 0;
            }
        }
    }
}
