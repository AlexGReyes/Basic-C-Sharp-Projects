using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personAssignment
{
    abstract class Person                               // DECLARATION OF A CLASS WITH TWO PROPERTIES
    {
        public string fistName { set; get;}
        public string lastName { set; get; }

        public abstract void SayName();                 // ADDED AN ABSTRACT METHOD TO BE IMPLEMENTED IN INHERETED CLASS

    }
}
