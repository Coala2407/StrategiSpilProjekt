using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPIL
{
    delegate void StartBanksHandler(Bank b);

    class Bank
    {
        public event StartBanksHandler StartBanks;
        public event StartBanksHandler StartBank;

        public Bank()
        {
            Thread bankThread = new Thread(RunBank);
        }

        private void RunBank()
        {
            //Do some banking, mate
        }

        protected virtual void OnBankStart()
        {
            StartBanks?.Invoke(this);
        }
    }
}
