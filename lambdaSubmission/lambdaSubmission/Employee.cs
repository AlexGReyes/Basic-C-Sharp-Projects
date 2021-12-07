using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaSubmission
{
    class Employee : Person, IQuittable
    {
        public Employee(string fName, string lName)             // ADDED A CONTRUCTOR TO SET FIRSTNAME AND LASTNAME PROPERTIES
        {
            fistName = fName;
            lastName = lName;
        }

        public Employee(int id, string fName, string lName)  // ADDED A CONTRUCTOR TO SET ID, FIRSTNAME AND LASTNAME PROPERTIES
        {
            fistName = fName;
            lastName = lName;
            ID = id;
        }

        public int ID;                                       // ADDED A PROPERTY

        public override void SayName()                          // IMPLEMENTED METHOD INHERIT FROM AN ABSTRACT CLASS
        {
            Console.WriteLine(fistName + " " + lastName);
        }

        public void Quit()                                      // IMPLEMENTED METHOD FROM AN INTEFACE
        {
            //throw new NotImplementedException();
            Console.WriteLine("I Quit!!");
        }
        /*
        public static bool operator==(Employee A, Employee B)   // OVERLOADING OF THE == OPERATOR
        {
            return A.ID.Equals(B.ID);
        }

        public static bool operator!=(Employee A, Employee B)   // OVERLOADING OF THE != OPERATOR
        {
            return !A.ID.Equals(B.ID);
        }*/
    }
}
