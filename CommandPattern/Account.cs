using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// This is the receiver
    /// our command will execute somenthing on the Account object
    /// Ex, a deposit command will increase the account object balance
    /// </summary>
    public class Account
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }

        public Account(string ownerName, decimal balance)
        {
            this.OwnerName = ownerName;
            this.Balance = balance;
        }
    }
}
