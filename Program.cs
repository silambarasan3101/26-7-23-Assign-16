using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_7_23_Assign_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount bank = new BankAccount("Str");
                bool flag = true;
                flag = bank.Deposit(3000);
                flag = bank.Withdraw(500);
                if (flag)
                    bank.Display();             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
