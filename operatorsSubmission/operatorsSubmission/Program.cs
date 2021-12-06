using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee A = new Employee();            // CREATION OR THREE INSTANCES OF EMPLOYEE OBJECT
            Employee B = new Employee();
            Employee C = new Employee();

            A.ID = "c8394326";                      // ASIGNING THE SAME VALUE AT TWO INSTANCES
            B.ID = "c8394326";
            C.ID = "12345678";




            Console.WriteLine(A == B);              // COMPARING DIFFERENT EMPLOYEE OBJECTS
            Console.WriteLine(A != B);
            Console.WriteLine(A == C);
            Console.WriteLine(A != C);
            Console.Read();
        }
    }
}
