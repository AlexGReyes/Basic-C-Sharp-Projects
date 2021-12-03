using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmission
{
    class Operation1
    {
        public void Divide(int a)                                               // VOID METHOD WITH A PARAMETER
        {
            Console.WriteLine("{0} divided by 2 is equals to {1}", a, a/2);    // DISPLAYS THE PARAMETER AND IT'S VALUE DIVIDED BY 2
        }

        public void Divide(int a, out int b)                                    // OVERLOADS THE METHOD
        {
            b = a / 2;                                                          // ASIGNING AT PARAMETER 2 THE RESULT OF PARAMETER 1 DIVIDED BY 2
        }
    }
}
