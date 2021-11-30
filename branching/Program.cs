using System;

namespace branching
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("############################################################################");                      // displaying a header
            Console.WriteLine("##    Welcome to Package Express. Please follow the instructions below    ##");
            Console.WriteLine("----------------------------------------------------------------------------\n\n");

            Console.WriteLine("Please enter the Package weight :");                                                                 // requiring the package weight 
            string weightStr = Console.ReadLine();
            int weight = Int32.Parse(weightStr);                                                                                    // casting as a integer
            if(weight > 50){                                                                                                        // comparing if the package weight is greater than 50
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Please enter the Package width :");                                                                  // requiring the package width
            string widthStr = Console.ReadLine();
            int width = Int32.Parse(widthStr);
            Console.WriteLine("Please enter the Package height :");                                                                 // requiring the package height
            string heightStr = Console.ReadLine();
            int height = Int32.Parse(heightStr);
            Console.WriteLine("Please enter the Package length :");                                                                 // requiring the package length
            string lengthStr = Console.ReadLine();
            int length = Int32.Parse(lengthStr);

            if ((width + height + length) > 50){                                                                                    // calculating if the package can be shipped
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
                System.Environment.Exit(0);
            }

            double totalCost = (width * height * length * weight)/100.0;                                                            // setting the final price
            Console.WriteLine("Your estimated total for shipping this package is : $" + totalCost.ToString());
            Console.WriteLine("Thank you!");
            Console.Read();


        }
    }
}
