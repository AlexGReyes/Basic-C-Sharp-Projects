using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClassSubmission
{
    class Operation1
    {
        public void Oper1(int a, int b)                                                                     // VOID METHOD THAT TAKES TWO INTEGERS AS PARAMETERS
        {
            Console.WriteLine("Math operation with the first parameter: {0} x {0} = {1}", a, a*a);          // DO A MATH OPERATION WITH THE FIRST PARAMETER
            Console.WriteLine("the second parameter is : {0}", b);                                          // DISPLAYING THE SECOND PARAMETER
        }
    }
}
