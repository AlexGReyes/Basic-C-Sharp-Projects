using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchAssignemt2
{
    public class LessThanCeroException : Exception
    {
        public LessThanCeroException ()
            : base(){
        }

        public LessThanCeroException(string msg) 
            : base(msg)
        {

        }
    }
}
