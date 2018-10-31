using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMasterData.Interafces
{
    public interface IBankAccount
    {
        int MoneyCount { get; set; }
        int AddMoney(int count);
        int GetMoney(int count);
    }
}
