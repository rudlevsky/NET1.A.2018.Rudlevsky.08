using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMasterData.Interafces;

namespace BankServiceData.Interfaces
{
    public interface IService
    {
        int Add(int count);
        int Get(int count);
        void CreateAccount(IBankAccount account);
        void DeleteAccount();
    }
}
