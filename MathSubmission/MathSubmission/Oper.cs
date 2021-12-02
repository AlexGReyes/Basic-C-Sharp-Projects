using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSubmission
{
    public class Oper
    {
        public int Operation1(int a)                    // creates a method that recives an integer data type
        {
            return a * a;                               // perfoms a multiplication operation
        }

        public int Operation1(decimal a)                // overloads a method and recives a decimal data type
        {
            return (int)a % 6;                          // performs a modulus operation
        }

        public int Operation1(string a)                 // overloads a method and recives astring data type
        {
            return Int32.Parse(a) + 77;                 // performs an addition
        }
    }
}
