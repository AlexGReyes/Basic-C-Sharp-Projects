using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please, write one day of the week");

                day day = (day)Enum.Parse(typeof(day), Console.ReadLine().ToUpper());       // PARSING DATA AS A ENUM
                                                                                            // 

                Console.WriteLine(day);                                                     // DISPLAYING AS A STRING
                Console.WriteLine(Convert.ToInt32(day));                                    // DISPLAYING ITS VALUE
            }
            catch (ArgumentException)                                                       // CATCH AN EXCEPTION IF THE INPUT DOESN'T MATCH WITH AN ENUM VALUE
            {
                Console.WriteLine("Please enter an actual day of the week");
            }

            Console.Read();
        }
    }

    public enum day                                                                         // A DAY OF THE WEEK ENUM
    {
        MONDAY, 
        TUESDAY, 
        WEDNESDAY, 
        THURSDAY, 
        FRIDAY, 
        SATURDAY,
        SUNDAY
    }
}
