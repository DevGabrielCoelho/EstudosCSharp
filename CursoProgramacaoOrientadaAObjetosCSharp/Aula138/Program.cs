using Aula138.Entities;
using System;
using System.Globalization;

namespace Aula138
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new BusinessAccount(123, "BOB", 2000.00, 2000.00); //FUNCIONA!!
            Account account1 = new SavingsAccount(234, "NPN", 3000.00, 3000.00); //FUNCIONA!!

            //BusinessAccount businessAccount = new Account(345, "MQM", 4000.00); //NÃO FUNCIONA!!
            BusinessAccount businessAccount1 = (BusinessAccount)account; //FUNCIONA POIS O "ACCOUNT RECEBEU UM BUSINESSACCOUNT ATERIORMENTE"
            SavingsAccount savingsAccount = account1 as SavingsAccount;

            //MESMO SENDO UM ACCOUNT PADRÃO, ALOCADO NA MEMORIA ELE TEM AS VARIAVEIS DA BUSSINESS ACCOUNT ALOCADAS, MAS NÃO PODE REALIZAR AS
            //FUNCÕES DE UMA BUSINESS ACCOUNT SENDO UMA ACCOUNT PADRÃO

            //TOMAR CUIDADO AO CONVERTER IMPLICITAMENTE USANDO (tipo) OU "as"

            if (account is BusinessAccount) Console.WriteLine("account é businessAccount");
            else Console.WriteLine("account não é businessAccount");

            if (account1 is SavingsAccount) Console.WriteLine("account é savingsAccount");
            else Console.WriteLine("account não é savingsAccount");

            if (businessAccount1 is Account) Console.WriteLine("\nbusinessAccount1 é account");
            else Console.WriteLine("\nbusinessAccount1 não é account");

            if (savingsAccount is Account) Console.WriteLine("savingsAccount é account");
            else Console.WriteLine("savingsAccount não é account");

            if (businessAccount1 is SavingsAccount) Console.WriteLine("\nbussinesAccount é savingsAccount");
            else Console.WriteLine("\nbussinesAccount não é savingsAccount");

            if (savingsAccount is BusinessAccount) Console.WriteLine("savingsAccount é bussinesAccount");
            else Console.WriteLine("savingsAccount não é bussinesAccount");

        }
    }
}