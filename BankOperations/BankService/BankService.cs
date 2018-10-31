using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMasterData.Interafces;
using BankServiceData.Interfaces;

namespace BankServiceData
{
    public class BankService : IService
    {
        private IBankAccount account;

        public int Add(int count) => account.AddMoney(count);

        public int Get(int count) => account.GetMoney(count);

        public void CreateAccount(IBankAccount account)
        {
            this.account = account;
        }

        public void DeleteAccount()
        {
            account = null;
        }
    }
}
