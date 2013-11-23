using System;
using System.Linq;

namespace Bank
{
    class DepositAccount : Account, IWithdrawable, IDepositable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        { }

        public override void Deposit(decimal money)
        {
            this.Balance += money;
        }
        public override void Withdraw(decimal money)
        {
            if (this.Balance > money)
            {
                this.Balance -= money;
            }
            else
            {
                throw new Exception("Not enough money");
            }
        }

        public override decimal CalculateInterestAmount(byte months)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
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
