using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personAssignment
{
    class Employee : Person
    {
        public override void SayName()                          // IMPLEMENTED METHOD INHERIT FROM AN ABSTRACT CLASS
        {
            Console.WriteLine(fistName + " " + lastName);
        }
    }
}
