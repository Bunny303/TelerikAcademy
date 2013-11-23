using System;
using System.Linq;

namespace Bank
{
    class MortgageAccount: Account, IDepositable
    {
        public MortgageAccount (Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateInterestAmount(byte months)
        {
            if (months <= 6 && this.Customer is IndividualCustomer)
            {
                return 0;
            }
            else if (months <= 12 && this.Customer is CompanyCustomer)
            {
                return (months*this.InterestRate*this.Balance)/2;
            }
            else
            {
                return months * this.InterestRate * this.Balance;
            }
        }
    }
}
