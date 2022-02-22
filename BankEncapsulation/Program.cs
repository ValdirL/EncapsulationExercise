using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Account balance = new Bank_Account();

            Console.WriteLine("How much would you like to deposit?");
            double amount = double.Parse(Console.ReadLine());

            balance.Deposit(amount);
            double userBalance = balance.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance} ");
        }
    }
}
