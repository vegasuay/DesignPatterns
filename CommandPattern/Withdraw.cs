using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class Withdraw:ITransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;

        public bool IsComplete { get; set; }

        public Withdraw(Account account, decimal amount)
        {
            this._account = account;
            this._amount = amount;

            IsComplete = false;
        }

        public void Execute()
        {
            if(_account.Balance >= _amount)
            {
                _account.Balance -= _amount;

                IsComplete = true;
            }
        }
    }
}
