using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_7_23_Assign_16
{
    internal class BankAccount
    {
        public int accNo { get; }
        public string name { get; }
        public double balance { get; set; }
        public BankAccount(string name)
        {
            this.name = name;
            balance = 0;
            accNo = GenerateAccNo();
        }
        private int GenerateAccNo()
        {
            Random rand = new Random();
            int num = rand.Next(5000);
            return num;
        }
        public bool Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
            else
            {
                Console.WriteLine("Invalid deposit amount");
                return false;
            }
            return true;
        }
        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount < balance)
                balance -= amount;
            else
            {
                Console.WriteLine("Invalid withdrawal amount");
                return false;
            }
            return true;
        }
        public void Display()
        {
            Console.WriteLine($"Account Number : {accNo}");
            Console.WriteLine($"Account Holder Name : {name}");
            Console.WriteLine($"Balance Remaining : {balance}");
        }
    }
}
