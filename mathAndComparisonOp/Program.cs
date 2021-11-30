using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathAndComparisonOp
{
    class Program{
        static void Main(string[] args)
        {
            string rateP1, hoursP1, rateP2, hoursP2;                                                                    // variable declarations
            decimal hourlyRateP1, hourlyRateP2, annualSalaryP1, annualSalaryP2;                                         // I selected decimal data type cause we are talking about money
            int hoursWorkedP1, hoursWorkedP2;
            float weeksPerYear = 52.1429f;                                                                              // a year has an average of 52.1429 weeks
            Console.WriteLine("#################################################################");                     // a small header
            Console.WriteLine("###            Anonymous Income Comparison Program            ###");
            Console.WriteLine("-----------------------------------------------------------------\n\n");
            Console.WriteLine("\nPerson 1");                                                                            // requesting data from person 1
            Console.WriteLine("\nHourly Rate?");                                                                        
            rateP1 = Console.ReadLine();
            hourlyRateP1 = decimal.Parse(rateP1);
            Console.WriteLine("\nHours worked per week?");
            hoursP1 = Console.ReadLine();
            hoursWorkedP1 = int.Parse(hoursP1);
            annualSalaryP1 = hourlyRateP1 * (decimal)hoursWorkedP1 * (decimal)weeksPerYear;                             // getting annual salary from person1 and casting all datatypes to decimal

            Console.WriteLine("\n\n\nPerson 2");                                                                        // requesting data from person 2
            Console.WriteLine("\nHourly Rate?");
            rateP2 = Console.ReadLine();
            hourlyRateP2 = decimal.Parse(rateP2);
            Console.WriteLine("\nHours worked per week?");                                                              
            hoursP2 = Console.ReadLine();
            hoursWorkedP2 = int.Parse(hoursP2);
            annualSalaryP2 = hourlyRateP2 * (decimal)hoursWorkedP2 * (decimal)weeksPerYear;                             // getting annual salary from person2 and casting all datatypes to decimal


            Console.WriteLine("\nAnnual salary of Person 1:");                                                          // displaing annual salary from person 1 and person 2
            Console.WriteLine(annualSalaryP1.ToString());
            Console.WriteLine("\nAnnual salary of Person 2:");
            Console.WriteLine(annualSalaryP2.ToString());


            Console.WriteLine("\n\n\nDoes Person1 make more money than Person 2?");                                     // comparing if annual salary from person 1 is greater than person 2 salary
            Console.WriteLine(annualSalaryP1> annualSalaryP2);

            Console.Read();

        }
    }
}
