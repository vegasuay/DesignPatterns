using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.enums
{
    public enum CommandState
    {
        Unprocessed,
        ExecuteFailed,
        ExecuteSucceeded,
        UndoFailed,
        UndoSucceeded
    }
}
