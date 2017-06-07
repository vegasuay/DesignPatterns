using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// the 'Command' object
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// IsCompleted will be used to let us know is the Command executed successfully
        /// </summary>
        bool IsComplete { get; set; }

        /// <summary>
        /// The Execute method is what will be called by the Invoker
        /// </summary>
        void Execute();
    }
}
