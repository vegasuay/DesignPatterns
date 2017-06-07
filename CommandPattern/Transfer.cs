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
    public class Transfer: ITransaction
    {
        private readonly decimal _amount;
        private readonly Account _fromAccount;
        private readonly Account _toAccount;

        public bool IsComplete { get; set; }

        public Transfer(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;

            IsComplete = false;
        }

        public void Execute()
        {
            if(_fromAccount.Balance >= _amount)
            {
                _fromAccount.Balance -= _amount;
                _toAccount.Balance += _amount;

                IsComplete = true;
            }
        }
    }
}
