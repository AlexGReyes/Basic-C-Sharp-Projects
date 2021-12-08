using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorSubmission
{
    public class Person
    {
        public Person(int age) : this("Annonymous", "User", age)        // CHAINING A CONTRUCTOR
        {

        }

        public Person(string firstName, string lastName, int id)       // MAIN CONSTRUCTOR
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
        }

        public string FirstName { get; set; }                           // ADDING 3 PROPERTIES
        public string LastName { get; set; }
        public int ID { set; get; }
    }
}
