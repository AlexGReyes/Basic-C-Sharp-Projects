using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace inputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number");                             // REQUESTING FOR A NUMBER
            string a = Console.ReadLine();
            if (int.TryParse(a, out int value))                                     // IF THE STRING IS INTEGER VALUE
            {
                File.WriteAllText(@"C:\Users\Alex\log\text.txt", a);                // SAVE THE STRINF IN A FILE

                Console.WriteLine(File.ReadAllText(@"C:\Users\Alex\log\text.txt")); // READING FROM FILE THE DATA SAVED
            }
            Console.Read();

           
        }
    }
}
