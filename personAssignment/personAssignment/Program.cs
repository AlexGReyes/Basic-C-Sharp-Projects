using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();               // CREATION OF AN INSTANCE OF EMPLOYEE CLASS
            e1.fistName = "Sample";                     // ASSIGNING VALUES TO PROPERTIES
            e1.lastName = "Student";
            e1.SayName();                               // CALLING OF A METHOD

            Console.Read();
        }
    }
}
