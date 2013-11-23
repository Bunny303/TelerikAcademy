using System;
using System.Linq;

namespace Bank
{
    public interface IWithdrawable
    {
        void Withdraw(decimal money);
    }
}
