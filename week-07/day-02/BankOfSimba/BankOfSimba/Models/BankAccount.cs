using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public object AnimalType { get; set; }

        public BankAccount(string name, int balance, object animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }
    }
}
