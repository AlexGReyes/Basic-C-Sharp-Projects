using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismSubmission
{
    class Employee : Person, IQuittable
    {
        public override void SayName()                          // IMPLEMENTED METHOD INHERIT FROM AN ABSTRACT CLASS
        {
            Console.WriteLine(fistName + " " + lastName);
        }

        public void Quit()                                      // IMPLEMENTED METHOD FROM AN INTEFACE
        {
            //throw new NotImplementedException();
            Console.WriteLine("I Quit!!");
        }
    }
}
