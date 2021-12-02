using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// THIS EXAMPLE SHOWS HOW IS OVERLOADING IN METHODS

namespace MathSubmission
{
    class Program
    {
        static void Main()
        {
            Oper a = new Oper();                                                            // DECLARATION AND INSTANTIATION OF A CLASS

            Console.WriteLine("Please, Write a Integer Number : ");

            int num = Convert.ToInt32(Console.ReadLine());                                  // CAST A STRING AS A INTEGER DATA TYPE

            Console.WriteLine(" {0} x {0} is equals to  {1}", num, a.Operation1(num)) ;     // PASS num VARIABLE AS A PARAMETER


            Console.WriteLine("Please, Write a Float Number : ");

            decimal num2 = decimal.Parse(Console.ReadLine());                               // CAST A STRING AS A DECIMAL DATA TYPE

            Console.WriteLine(" {0} % 6 is equals to  {1}", num2, a.Operation1(num2));      // PASS num2 VARIABLE AS A PARAMETER



            Console.WriteLine("Please, Write another integer Number : ");
            string num3 = Console.ReadLine();                                               // REQUESTING A STRING

            Console.WriteLine(" {0} + 77 is equals to  {1}", num3, a.Operation1(num3));     // PASS num3 VARIABLE AS A PARAMETER

            Console.Read();
        }
    }
}
