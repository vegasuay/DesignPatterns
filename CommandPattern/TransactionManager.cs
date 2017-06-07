using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// The 'Invoker' class
    /// Invoker doesn’t know anything about what the Command objects do, 
    /// or what parameters they need. All it needs to know is that the Command can be executed.
    /// </summary>
    public class TransactionManager
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get { return _transactions.Any(x => !x.IsComplete); }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            // Apply transactions in the order they were added.
            foreach(ITransaction transaction in _transactions.Where(x=> !x.IsComplete))
            {
                transaction.Execute();
            }
        }
    }
}
