using BankMasterData;
using BankServiceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserData;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(new BankService(),"Vasily","Petrov","mail@gmail.com");

            user.AddAccount(new BankMaster(user.Name, user.Surname, user.Email, user.UserStatus));

            user.Add(500);
            
            Console.WriteLine(user.CurrentBankMoney);

            user.Get(200);

            Console.WriteLine(user.CurrentBankMoney);

            user.DeleteAccount();
        }
    }
}
