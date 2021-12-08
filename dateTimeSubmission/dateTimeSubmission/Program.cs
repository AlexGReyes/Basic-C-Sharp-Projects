using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());                                              // PRINTS THE CURRENT DATE AND TIME
            Console.WriteLine("Please write a integer number");                             // REQUESTING FOR A INTEGER NUMBER

            try
            {   
                uint num = UInt32.Parse(Console.ReadLine());                                // CASTING AS A 32-BIT INTEGER

                DateTime timeAfterNow = now.AddHours(num);                                  // ADDING TO THE CURRENT DATE A SPECIFIC NUMBER OF HOURS
                Console.WriteLine("The exact time will be at " + timeAfterNow.ToString());  // PRINTS THE NEW DATE AND TIME
            }
            catch (Exception e)
            {
                Console.WriteLine("You have to write a integer number");                    // A EXCEPTION IF THE USER DOES NOT WRITE A NUMBER
            }
            Console.Read();
        }
    }
}
