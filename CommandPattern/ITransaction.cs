using CommandPattern.enums;
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
        int ID { get; set; }
        DateTime CreatedOn { get; set; }
        CommandState Status { get; set; }
        
        /// <summary>
        /// The Execute method is what will be called by the Invoker
        /// </summary>
        void Execute();

        void Undo();
    }
}
