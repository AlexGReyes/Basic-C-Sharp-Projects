using System;

namespace whileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
                                                            // this block displays fibonacci sequence using a while bucle
            int fibo1 = 1, fibo2 = 0, fibo3;                // declaring variables
            int total = 0;

            while (total < 10)                              // displays the first 10 elements from fibonnacci sequence
            {
                fibo3 = fibo1 + fibo2;                      // calculating the next fibonacci number
                Console.WriteLine(fibo3);                   // displaying the number
                total++;                                    // increments the number of elements
                fibo1 = fibo2;                              // setting the actual and the last fibonacci numers
                fibo2 = fibo3;
            }


                                                            // this block uses a do-while bucle to guess my age
            string ageStr;                                  // declaring variables

            do
            {                                               // requesting an age 
                Console.WriteLine("What is my age?");
                ageStr = Console.ReadLine();                // I did no cast as a number because I don't do math operations
            } while (ageStr != "35");                       // repeat the do-block until the user enters 35
            Console.WriteLine("I am 35 years Old!!");
            Console.Read();
        }
    }
}
