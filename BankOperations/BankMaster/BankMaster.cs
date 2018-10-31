using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMasterData.Interafces;
using BankMasterData.Models;

namespace BankMasterData
{
    public class BankMaster : IBankAccount
    {
        private int number;
        private string name;
        private string surname;
        private string email;

        private Status status;

        private int BonusPoints;
        private const int AddMoneyCoef = 10;
        private const int GetMoneyCoef = 5;

        public int MoneyCount { get; set; }

        public BankMaster(string name, string surname, string email, Status status)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.status = status;
            number = GenerateNumber();
        }

        public int AddMoney(int count)
        {
            BonusPoints += AddMoneyCoef * StatusCardCoef();
            MoneyCount += count;

            return MoneyCount;
        }

        public int GetMoney(int count)
        {
            BonusPoints -= AddMoneyCoef * StatusCardCoef();
            MoneyCount -= count;

            return MoneyCount;
        }

        private int GenerateNumber()
        {
            var rand = new Random();

            return rand.Next(100);
        }

        private int StatusCardCoef()
        {
            switch(status)
            {
                case Status.Gold:
                    return 5;
                case Status.Platinum:
                    return 10;
                default:
                    return 1;
            }
        }
    }
}
