using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();                                                // DECLARATION OF A INTEGER LIST AND ADDING SIX ELEMENTS
        numbers.Add(45);
        numbers.Add(6554);
        numbers.Add(7878);
        numbers.Add(234);
        numbers.Add(87);

        Console.WriteLine("Write a Number :");                                              // DISPLAY A MESSAGE TO REQUEST A NUMBER
        int div;
        
        try { 
            int numStr = Convert.ToInt32(Console.ReadLine());                               // READ THE USER INPUT AND CASTING TO A INTEGER
            foreach(int a in numbers)
            {
                div = a / numStr;                                                           // DIVIDE ALL ELEMENTS BY THE USER NUMBER
                Console.WriteLine( a.ToString() + " / " + numStr.ToString() + " is equals to "+ div.ToString());
            }
        }
        catch (DivideByZeroException e)                                                     // EXCEPTION IF THE USER INSERTS A 0 VALUE
        {
            Console.WriteLine("You Cannot divide by 0");
        }
        catch(FormatException e)                                                            // EXCEPTION IF THE USER INSERTS A NON-INTEGER VALUE
        {
            Console.WriteLine("You must write an integer");
        }

        Console.WriteLine("\nThe program has emerged from the try/catch block");            // DISPLAYING A MESSAGE TO LET THE USER KNOWS THE PROGRAM HAS EMERGED FROM
        Console.Read();                                                                 // TRY CATCH BLOCK
    }
}

