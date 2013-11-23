using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
    class Program
    {
        static void Main()
        {
            List<Account> testAccounts = new List<Account>();
            testAccounts.Add(new DepositAccount(new IndividualCustomer("Pasho"), 2000, 2m));
            testAccounts.Add(new LoanAccount(new CompanyCustomer("Done Ltd."), 10000, 15m));
            testAccounts.Add(new MortgageAccount (new CompanyCustomer("Blank Ltd."), 30000, 3m));

            foreach (var account in testAccounts)
            {
                Console.WriteLine(account.CalculateInterestAmount(6));
                account.Deposit(2000);
                if (account is LoanAccount)
                {
                    Console.WriteLine("Old balance: {0}", account.Balance);
                    account.Withdraw(300);
                    Console.WriteLine("New balance: {0}", account.Balance);
                }
                if (account is DepositAccount)
                {
                    Console.WriteLine("Old balance: {0}", account.Balance);
                    account.Deposit(300);
                    Console.WriteLine("New balance: {0}", account.Balance);
                }
            }
        }
    }
}
