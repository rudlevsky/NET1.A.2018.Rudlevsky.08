using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMasterData.Interafces;
using BankServiceData.Interfaces;
using BankMasterData.Models;

namespace UserData
{
    public class User
    {
        private IService service;

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public Status UserStatus { get; private set; }
        public int CurrentBankMoney { get; private set; }

        public User(IService service, string name, string surname, string email, Status status = Status.Classic)
        {
            this.service = service;
            UserStatus = status;
            Name = name;
            Surname = surname;
            Email = email;
        }

        public void AddAccount(IBankAccount account)
        {
            service.CreateAccount(account);
        }

        public void DeleteAccount()
        {
            service.DeleteAccount();
        }

        public void Add(int count)
        {
            CurrentBankMoney = service.Add(count);
        }

        public void Get(int count)
        {
            CurrentBankMoney = service.Get(count);
        }
    }
}
