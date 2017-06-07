using CommandPattern.enums;
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
            get
            {
                return _transactions.Any(x => 
                    x.Status == CommandState.Unprocessed ||
                    x.Status == CommandState.ExecuteFailed ||
                    x.Status == CommandState.UndoFailed);
            }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            // Execute transactions that are unprocessed, or had a previous Execute fail.
            foreach(ITransaction transaction in _transactions.Where(x=>
                x.Status == CommandState.Unprocessed || x.Status == CommandState.ExecuteFailed))
            {
                transaction.Execute();
            }

            // Retry the Undo, for transactions that had a previous Undo fail.
            foreach (ITransaction transaction in _transactions.Where(x=> x.Status == CommandState.UndoFailed))        
            {
                transaction.Undo();
            }
        }

        /// <summary>
        /// Get the Command object that has the passed ID.
        /// If it does not exist in _transactions, the result will be null (default, for this object type).
        /// </summary>
        /// <param name="id"></param>
        public void UndoTransactionNumber(int id)
        {
            ITransaction transaction = _transactions.FirstOrDefault(x => x.ID == id);

            if(transaction == null)
            {
                throw new ArgumentException(string.Format("There are not transaction with id: {0}", id));
            }

            if(transaction.Status != CommandState.ExecuteSucceeded)
            {
                throw new ArgumentException(string.Format("Can only undo transactions that have been successfully executed."));
            }

            transaction.Undo();

            if (transaction.Status == CommandState.UndoSucceeded)
                _transactions.Remove(transaction);
        }

        /// <summary>
        /// // Remove transaction that have been Executed, and are more than 15 days old.
        /// </summary>
        public void RemoveOldTransactions()
        {
            _transactions.RemoveAll(x =>
                x.Status == CommandState.ExecuteSucceeded &&
                (DateTime.UtcNow - x.CreatedOn).Days > 15);
        }
    }
}
