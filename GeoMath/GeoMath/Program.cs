using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoMath
{
    class Program
    {
        static void Main(string[] args)
        {
            GeoOp op = new GeoOp();                                     // DECLARATION AND INSTANTIATION OF A CLASS


            try
            {                                                                                       // THIS PROGRAM THROWNS AN EXCEPTION IF THE USER INPUTS AN NON-INTEGER VALUE
                Console.WriteLine("Please, write a number :");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" {0} + {0}  is equal to {1} ", num,  op.OperOne(num));           // DISPLAYS THE RESULT OF THE OperOne METHOD FROM GEOOP CLASS
                Console.WriteLine(" {0} - 2 is equal to {1} ", num, op.OperTwo(num));               // DISPLAYS THE RESULT OF THE OperTwo METHOD FROM GEOOP CLASS
                Console.WriteLine(" {0} % 7  is equal to {1} ", num, op.OperThree(num));            // DISPLAYS THE RESULT OF THE OperThree METHOD FROM GEOOP CLASS
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have to write an Integer ");
            }


            Console.Read();
        }
    }
}
