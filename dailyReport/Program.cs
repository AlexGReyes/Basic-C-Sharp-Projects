using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyReport
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("####################################");                                                      // DISPLAYING A SHORT HEADER
            Console.WriteLine("##        The Tech Academy        ##");                                                      // IF THE USER INSERTS A DIFFERENT DATA THAN REQUIRED, AN ERROR WILL BE DISPLAYED
            Console.WriteLine("------------------------------------");
            Console.WriteLine("         Student Daily Report\n\n");


            Console.WriteLine("\nWhat is your name?");                                                                      // 
            string name = Console.ReadLine();                                                                               // SAVING NAME AS A STRING
            Console.WriteLine("\nWhat course are you on?");
            string course = Console.ReadLine();                                                                             // SAVING COURSE AS A STRING
            Console.WriteLine("\nWhat page number?");
            string page = Console.ReadLine();                                                                               // SAVING PAGE AS A STRING
            int pageInt = Convert.ToInt32(page);                                                                            // CASTING THE STRING AS A 32-BIT INTEGER
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();                                                                               // SAVING HELP AS A STRING
            bool helpBoolean = Convert.ToBoolean(help);                                                                     // CASTING AS A BOOL
            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();                                                                        // SAVING EXPERIENCES AS A STRING
            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific");
            string feedback = Console.ReadLine();                                                                           // SAVING FEEDBACK AS A STRING
            Console.WriteLine("\nHow many hours did you study today?");
            string hours = Console.ReadLine();                                                                              // SAVING HOURS AS A STRING
            int hoursInt = Int16.Parse(hours);                                                                              // OTHER WAY TO CAST A STRING AS A 16-BIT INTEGER


            Console.WriteLine("\n\n------------------------------------");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
