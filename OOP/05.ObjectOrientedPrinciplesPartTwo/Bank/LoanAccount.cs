using System;
using System.Linq;

namespace Bank
{
    class LoanAccount: Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateInterestAmount(byte months)
        {
            if (months <= 3 &&  this.Customer is IndividualCustomer)
            {
                return 0;
            }
            else if (months <= 2 && this.Customer is CompanyCustomer)
            {
                return 0;
            }
            else
            {
                return months * this.InterestRate;
            }
        }
    }
}
