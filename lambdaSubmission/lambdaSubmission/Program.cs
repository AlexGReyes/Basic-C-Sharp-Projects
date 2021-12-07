using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();                // CREATION OF A LIST OF EMPLOYEE
            employees.Add(new Employee(1, "Joe", "Smith"));                 // ADDING ELEVEN EMPLOYEES
            employees.Add(new Employee(9, "Liam", "Johnson"));
            employees.Add(new Employee(66, "Noah", "Williams"));
            employees.Add(new Employee(4, "Joe", "Brown"));
            employees.Add(new Employee(54, "Oliver", "Jones"));
            employees.Add(new Employee(6514, "Elijah", "Garcia"));
            employees.Add(new Employee(2, "Olivia", "Miller"));
            employees.Add(new Employee(365, "Emma", "Davis"));
            employees.Add(new Employee(7415, "Ava", "Rodriguez"));
            employees.Add(new Employee(3, "Charlotte", "Martinez"));
            employees.Add(new Employee(2, "Joe", "Hernandez"));

            List<Employee> l1 = new List<Employee>();                       // CREATION OF A NEW LIST OF EMPLOYEES WITH JOE AS A FIRST NAME USING FOREACH


            foreach (Employee el in employees)
            {
                if(el.fistName.ToUpper() == "JOE")
                {
                    l1.Add(el);
                }
            }
            
            foreach (Employee el in l1)                                     // DISPLAYING THE EMPLOYEES WITH JOE AS A FISRTNAME
            {
                Console.WriteLine(el.fistName+" "+ el.lastName);
            }

                                                                            // CREATION OF A NEW LIST OF EMPLOYEES WITH JOE AS A FIRST NAME USING LAMBDA FUNCTIONS
            List<Employee> l2 = employees.Where(a => a.fistName.ToUpper() == "JOE").ToList();


            foreach (Employee el in l2)                                     // DISPLAYING THE EMPLOYEES WITH JOE AS A FISRTNAME
            {
                Console.WriteLine( el.fistName + " " + el.lastName);
            }


            List<Employee> l3 = employees.Where(a => a.ID > 5).ToList();    // CREATION OF A NEW LIST OF EMPLOYEES WITH ID GREATER THAN 5

            foreach (Employee el in l3)                                     // DISPLAYING THE EMPLOYEES WITH ID GREATER THAN 5
            {
                Console.WriteLine("{0} {1} {2}", el.ID, el.fistName, el.lastName);
            }

            Console.Read();
        }
    }
}
