using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account 
    {
        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; private set; }

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual void Deposit(decimal money)
        { }
        public virtual void Withdraw(decimal money)
        { }
        public virtual decimal CalculateInterestAmount(byte months)
        {
            return months * this.InterestRate;
        }
        
    }
        
}
