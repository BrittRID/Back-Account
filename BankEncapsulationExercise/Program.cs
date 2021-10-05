using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount be = new BankAccount();
            Console.WriteLine("How much money do you need to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            be.Deposit(amountToDeposit);
            double userBalance = be.GetBalance();

            Console.WriteLine($"Balance available{userBalance, 0:c}");
        }
    }
}
