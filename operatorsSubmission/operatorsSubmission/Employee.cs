using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorsSubmission
{
    class Employee : Person, IQuittable
    {
        public string ID;                                       // ADDED A PROPERTY

        public override void SayName()                          // IMPLEMENTED METHOD INHERIT FROM AN ABSTRACT CLASS
        {
            Console.WriteLine(fistName + " " + lastName);
        }

        public void Quit()                                      // IMPLEMENTED METHOD FROM AN INTEFACE
        {
            //throw new NotImplementedException();
            Console.WriteLine("I Quit!!");
        }

        public static bool operator==(Employee A, Employee B)   // OVERLOADING OF THE == OPERATOR
        {
            return A.ID.Equals(B.ID);
        }

        public static bool operator!=(Employee A, Employee B)   // OVERLOADING OF THE != OPERATOR
        {
            return !A.ID.Equals(B.ID);
        }
    }
}
