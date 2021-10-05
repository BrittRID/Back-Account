using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Get user deposit of {amount} to your account!!");
        }

        public double GetBalance()
        {
            return _balance;

        }
    }
}
