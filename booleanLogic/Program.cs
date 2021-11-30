using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program{
        static void Main(string[] args){
            int age, tickets;                                                       // declaring variables
            string ageStr, haveDUIStr, ticketsStr;
            bool haveDUI;
            Console.WriteLine("What is you age?");                                  // requesting age
            ageStr = Console.ReadLine();
            age = Int32.Parse(ageStr);                                              // casting as a 32-bit integer
            Console.WriteLine("Have you ever had a DUI? (true/false)");             // requesting if the person has ever has a DUI
            haveDUIStr = Console.ReadLine();
            haveDUI = bool.Parse(haveDUIStr);                                       // casting as a bool
            Console.WriteLine("How many speeding tickets do you have?");            // requesting how many speeding tickets does the person has
            ticketsStr = Console.ReadLine();
            tickets = Int32.Parse(ticketsStr);                                      // casting as a 32-bit integer

            Console.WriteLine("Quialified?");
            Console.WriteLine(age > 15 && !haveDUI && tickets <= 3);                // validating if the person qualifies for car insurance
            Console.Read();

        }
    }
}
