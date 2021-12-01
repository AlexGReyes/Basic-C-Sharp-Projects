using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] sentences = new string[5];                                         // DECLARING AN ARRAY OF STRINGS AND FILLED WITH SOME SMALL SENTENCES
        sentences[0] = "Open the jar carefully";
        sentences[1] = "Read the directions.";
        sentences[2] = "Use common sense.";
        sentences[3] = "Make the best of things.";
        sentences[4] = "He was eating and talking.";


        string num;                                                                 // DECLARING A STRING VAR TO ALLOCATE THE USER INPUT
        short Num;                                                                  // DECLARING A INTEGER VAR TO CAST A STRING VAR TO INTEGER
        Console.WriteLine("Please write a number from 0 to 4 :");
        while (true)                                                                // INFINITE WHILE LOOP TO READ ALL USER'S INPUTS AND VALIDATE IF
        {                                                                           // THE SELECTED VALUE EXISTS IN THE ARRAY
            num = Console.ReadLine();                                               // IF THE SELECTED VALUE EXIST, THE WHILE LOOP WILL BE BROKEN
            Num = Int16.Parse(num);                                                 // OTHERWISE IT WILL CONTINUE UNTIL THE USER WRITES A CORRECT VALUE
            Console.WriteLine(Num);
            if (Num >= 0 && Num <= 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("This number doesn not exist, Please write a number from 0 to 4 :");
            }
        }

        Console.WriteLine("Sentence selected : " + sentences[Num] + "\n\n\n");
                                                                                    // DECLARING AN ARRAY OF INT AND FILLED WITH PRIME NUMBERS
        int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61 };

        Console.WriteLine("Please select a number from 0 to 17 :");
        while (true)                                                                // INFINITE WHILE LOOP TO READ ALL USER'S INPUTS AND VALIDATE IF
        {                                                                           // THE SELECTED VALUE EXISTS IN THE ARRAY
            num = Console.ReadLine();                                               // IF THE SELECTED VALUE EXIST, THE WHILE LOOP WILL BE BROKEN
            Num = Int16.Parse(num);                                                 // OTHERWISE IT WILL CONTINUE UNTIL THE USER WRITES A CORRECT VALUE
            if (Num >= 0 && Num <= 17)
                break;
            else
                Console.WriteLine("This number doesn not exist, Please write a number from 0 to 17 :");
        }

        Console.WriteLine("Prime number selected : " + prime[Num].ToString());

        List<string> dinosaurs = new List<string>();                                // DECLARING A LIST OF STRINGS AND ADDED SOME DINOSAURS' NAMES
        dinosaurs.Add("Tyrannosaurus Rex");
        dinosaurs.Add("Stegosaurus");
        dinosaurs.Add("Triceratops");
        dinosaurs.Add("Velociraptor");
        dinosaurs.Add("Spinosaurus");
        dinosaurs.Add("Allosaurus");
        dinosaurs.Add("Archaeopteryx");
        dinosaurs.Add("Megalosaurus");

        int totalDinosaurs = dinosaurs.Count;                                       // GETTING THE AMOUNT OF ELEMENTS IN THE LIST
                                                                                    // 
        Console.WriteLine("\n\n\nPlease write a numer from 0 to " + (totalDinosaurs - 1).ToString() + " to select a dinosaur");
        while (true)                                                                // DECLARING AN INFINITE WHILE BUCLE O READ ALL USER'S INPUTS AND VALIDATE IF
        {                                                                           // THE SELECTED VALUE EXISTS IN THE LIST
            num = Console.ReadLine();
            Num = Int16.Parse(num);

            if (Num >= 0 && Num < totalDinosaurs)                                   // IF THE SELECTED VALUE EXIST, THE WHILE LOOP WILL BE BROKEN
                break;
            else
                Console.WriteLine("This number doesn not exist, Please write a numer from 0 to " + (totalDinosaurs - 1).ToString() + " to select a dinosaur");

        }

        Console.WriteLine("You have selected the " + dinosaurs[Num]);
        Console.Read();

    }
}

