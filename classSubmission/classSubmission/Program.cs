using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation1 o1 = new Operation1();
            Console.WriteLine("Please, write a integer number : ");
            string numStr = Console.ReadLine();
            if (!int.TryParse(numStr, out int value))                                   // IF IT IS NOT AN INTEGER, DISPLAY A MESSAGE
            {
                Console.WriteLine("You have to write a integer Number");
            }
            else{
                o1.Divide(Int32.Parse(numStr)) ;                                        // CALLING OF Divide METHOD

                int param2;
                o1.Divide(Int32.Parse(numStr), out param2);                             // CALLING A OVERLOADED METHOD

                Console.WriteLine("This is the second parameter from an overloaded method -> {0}", param2);
            }

            Operation2.Oper2();                                                         // CALLING A METHOD FROM A STATIC CLASS

            Console.Read();
        }
    }
}
