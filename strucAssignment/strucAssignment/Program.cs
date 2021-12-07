using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strucAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();                       // CREATION OF AN OBJECT OF DATA TYPE NUMBER
            number.Amount = 55.12M;                             // ASIGNING AN AMOUNT

            Console.WriteLine(number.Amount);
            Console.Read();
        }

        public struct Number                                    // CREATION OF A STRUCT WITH ONE PROPERTY OF DECIMAL DATA TYPE
        {
            public  decimal Amount;
        }
    }
}
