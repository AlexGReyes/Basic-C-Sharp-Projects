using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(45);
        numbers.Add(6554);
        numbers.Add(7878);
        numbers.Add(234);
        numbers.Add(87);

        Console.WriteLine("Write a Number :");
        int Number = Convert.ToInt32(Console.ReadLine());
        int div = 5;
        Console.WriteLine(Number);
        Console.Read();
        foreach(int a in numbers)
        {
            //div = a / Number;
            Console.WriteLine("{0} asasas {1} is equals to {3}", a, Number, div);
        }

        Console.Read();
    }
}

