using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOper2
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationGround peso = new OperationGround();                                               // INSTANTIATION OF A CLASS

            Console.WriteLine("Please insert a integer number : ");                                     // REQUESTING AN INTEGER
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please insert another integer number (you can skip that part): ");       // REQUESTING ANOTHER INTEGER
            string numStr = Console.ReadLine();
            int num2;
            if (!int.TryParse(numStr, out int value))                                                   // VALIDATING IF THE SECOND STRING CAN BE CASTED AS AN INTEGER
                Console.WriteLine("({0} * 100) / 2 is equals to {1}", num1, peso.ExchangeRate(num1));   // CALLING FOR A METHOD WITH ONE PARAMETER
            else
            {
                num2 = Int32.Parse(numStr);                                                             // CALLING FOR A METHOD WITH TWO PARAMETERS
                Console.WriteLine("({0} * 100) / ({1} +1) is equals to {2}", num1, num2, peso.ExchangeRate(num1, num2));
            }

            Console.Read();
        }
    }
}
