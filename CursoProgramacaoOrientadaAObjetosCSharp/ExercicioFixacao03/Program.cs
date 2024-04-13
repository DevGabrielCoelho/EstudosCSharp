using ExercicioFixacao03.Entities;
using ExercicioFixacao03.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercicioFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Account data:\nNumber: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder name: ");
                string accountHolder = Console.ReadLine();
                Console.Write("Balance: ");
                double accountBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double accountWithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(accountNumber, accountHolder, accountBalance, accountWithdrawLimit);

                Console.Write("\nEnter the withdraw amount: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(account);
            }
            catch (AccountExceptions exceptions) 
            {
                Console.WriteLine($"Error! {exceptions.Message}");
            }
            catch (FormatException exceptions)
            {
                Console.WriteLine($"Error! {exceptions.Message}");
            }
            catch (Exception exceptions)
            {
                Console.WriteLine($"Unexpected error! {exceptions.Message}");
            }
            finally
            {
                Console.WriteLine("\nSee you later :)");
            }


        }
    }
}