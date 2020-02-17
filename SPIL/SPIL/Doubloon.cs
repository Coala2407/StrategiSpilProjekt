using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPIL
{
    class Doubloon
    {
        int ammount;

        public void GiveDoubloon(int ammountToGive)
        {
            ammount += ammountToGive;
        }

        public void RemoveDoubloon(int ammountToRemove)
        {
            ammount -= ammountToRemove;
            if (ammount < 0)
            {
                ammount = 0;
            }
        }
    }
}
