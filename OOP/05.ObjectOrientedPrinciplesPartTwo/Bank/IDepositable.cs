using System;
using System.Linq;

namespace Bank
{
    public interface IDepositable
    {
        void Deposit(decimal money);
    }
}
