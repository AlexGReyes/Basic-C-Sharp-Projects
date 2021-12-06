using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable iq1 = new Employee();                // CREATION OF AN OBJECT OF TYPE IQUITTABLE
            iq1.Quit();                                     // CALLING OF A METHOD
            Console.Read();
        }
    }
}
