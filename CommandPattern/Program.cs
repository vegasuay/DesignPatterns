using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// this 'client' 
    /// The Client creates Command objects and sends them to the Invoker
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //create the invoker
            TransactionManager transactionManager = new TransactionManager();
                        
            Account sueAccount = new Account("Sue Smith", 0);

            //create concrete command object
            Deposit deposit = new Deposit(1,sueAccount, 100);

            transactionManager.AddTransaction(deposit);

            //command has been added to the queue, but not executed
            Console.WriteLine("pending transacton? " + transactionManager.HasPendingTransactions.ToString());
            Console.WriteLine("balance Sue: " + sueAccount.Balance.ToString());

            //execute the commands
            transactionManager.ProcessPendingTransactions();

            //command has been added to the queue, but not executed
            Console.WriteLine("pending transacton? " + transactionManager.HasPendingTransactions.ToString());
            Console.WriteLine("balance Sue: " + sueAccount.Balance.ToString());

            // Add a withdrawal, apply it, and verify the balance changed.
            Withdraw withdrawal = new Withdraw(2, sueAccount, 50);

            transactionManager.AddTransaction(withdrawal);

            //execute the commands
            transactionManager.ProcessPendingTransactions();

            //command has been added to the queue, but not executed
            Console.WriteLine("pending transacton? " + transactionManager.HasPendingTransactions.ToString());
            Console.WriteLine("balance Sue: " + sueAccount.Balance.ToString());

            //test undo
            transactionManager.UndoTransactionNumber(2);

            Console.WriteLine("After Undo");
            Console.WriteLine("pending transacton? " + transactionManager.HasPendingTransactions.ToString());
            Console.WriteLine("balance Sue: " + sueAccount.Balance.ToString());

            //wait for user
            Console.ReadKey();
        }
    }
}
