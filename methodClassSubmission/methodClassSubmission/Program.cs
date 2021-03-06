using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please, write a integer Number");                        // REQUESTING A INTEGER NUMBER
            string numStr = Console.ReadLine();
            if (!int.TryParse(numStr, out int value))                                   // IF IT IS NOT AN INTEGER, DISPLAY A MESSAGE
            {
                Console.WriteLine("You have to write a integer Number");
            }
            else
            {
                Console.WriteLine("Please, write another integer Number");              // REQUESTING A SECOND INTEGER NUMBER
                string numStr2 = Console.ReadLine();
                if (!int.TryParse(numStr2, out int value2))                             // CHECKING IF IT IS A INTEGER NUMBER
                {
                    Console.WriteLine("You have to write a integer Number");
                }
                else
                {                                                                       // IF BOTH ARE INTEGER NUMBERS
                    Operation1 o1 = new Operation1();                                   // INSTANTIATE THE CLASS
                    int numA = Int32.Parse(numStr);
                    int numB = Int32.Parse(numStr2);
                    o1.Oper1(numA, numB);                                               // CALLING A METHOD FROM Operation1 CLASS

                    
                    o1.Oper1(a : numA, b : numB);                                       // CALLING A METHOD FROM Operation1 CLASS SPECIFYING THE PARAMETER BY NAME
                }
            }
            Console.Read();
        }
    }
}
