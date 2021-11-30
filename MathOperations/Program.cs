using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");                            // this code requires a number and multiplies it by 50
            string num = Console.ReadLine();
            long numA = Int64.Parse(num);
            numA *= 50;
            Console.WriteLine(num + " times 50  = " + numA);

            Console.WriteLine("\n\nWrite a number");                        // this code requires a number and adds 25
            num = Console.ReadLine();
            numA = Int64.Parse(num);
            numA += 25;
            Console.WriteLine(num + " plus 25  = " + numA);



            Console.WriteLine("\n\nWrite a number");                        // this code requires a number and divides it by 12.5
            num = Console.ReadLine();
            double numB = double.Parse(num);
            numB /= 12.5;
            Console.WriteLine(num + " / 12.5  = " + numB);


            Console.WriteLine("\n\nWrite a number");                        // this code requires a number and compares if it is greater than 50
            num = Console.ReadLine();
            numB = double.Parse(num);
            Console.WriteLine(numB > 50);


            Console.WriteLine("\n\nWrite a number");                        // this code requires a number and applies module operation by 7
            num = Console.ReadLine();
            numA = Int32.Parse(num);
            numA %= 7;
            Console.WriteLine(numA);
            Console.Read();
        }
    }
}
