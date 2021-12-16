using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchAssignemt2
{
    public class EqualsToZeroException : Exception
    {
        public EqualsToZeroException() 
            : base()
        {

        }

        public EqualsToZeroException(string msg) 
            : base(msg)
        {

        }
    }
}
