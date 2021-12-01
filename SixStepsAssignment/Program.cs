using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //************************************************************************************************************************
                                                   // PART ONE ASSIGNMENT
        string[] stringArra1 = new string[5];                                               // DECLARING AN EMPTY ARRAY OF STRINGS WITH LENGTH OF 5
        int stringLength = stringArra1.Length;                                              // ASIGNING TO stringLength THE ARRAY'S LENGTH


        for (int i = 0; i < stringLength; i++)                                              // FOR LOOP TO INSERT STRINGS WRITTEN BY THE USER
        {
            Console.WriteLine("Write {0:d} senteces more", stringLength-i);
            stringArra1[i] = Console.ReadLine();
        }


        Console.WriteLine("\n\n\nYou have written : ");                                     // DISPALYING EACH SENTENCE ON A SEPARATE LINE
        for (int i = 0; i < stringLength; i++)
        {
            Console.WriteLine(stringArra1[i]);
        }

        //************************************************************************************************************************
        // PART TWO ASSIGNMENT
        int j = 0;
        while (j==0)                                            //
        {
            j++;                                                // IF THIS SENTENCE IS REMOVED, IT WILL CREATE AN INFINITE LOOP
        }


        //************************************************************************************************************************
        // PART THREE  ASSIGNMENT
        j = 0;
        while (j<10)                                            // CREATION OF A LOOP WHERE THE COMPARISON THAT’S USED TO DETERMINE 
        {                                                       // WHETHER TO CONTINUE ITERATING THE LOOP IS A “<” OPERATOR.
            j++;
        }

        for(j=0; j<10; j++)                                     // THE SAME BUT USING FOR LOOP
        {

        }

        j = 0;
        while (j <= 10)                                         // CREATION OF A LOOP WHERE THE COMPARISON THAT’S USED TO DETERMINE 
        {                                                       // WHETHER TO CONTINUE ITERATING THE LOOP IS A “<=” OPERATOR.
            j++;
        }

        for (j = 0; j <= 10; j++)                                // THE SAME BUT USING FOR LOOP
        {

        }


        //************************************************************************************************************************
        // PART FOUR  ASSIGNMENT

        List<string> dinosaurs = new List<string>();                                // DECLARING A LIST OF STRINGS AND ADDED SOME DINOSAURS' NAMES
        dinosaurs.Add("Tyrannosaurus Rex");
        dinosaurs.Add("Stegosaurus");
        dinosaurs.Add("Triceratops");
        dinosaurs.Add("Velociraptor");
        dinosaurs.Add("Spinosaurus");
        dinosaurs.Add("Allosaurus");
        dinosaurs.Add("Archaeopteryx");
        dinosaurs.Add("Megalosaurus");

        Console.WriteLine("\n\n\nWrite a dinosaur name to search it on the list : ");   // REQUESTING A NAME TO SEARCH IT ON THE LIST
        string name;
        bool nameFound = false;
        int indexD;

        while (!nameFound)
        {
            indexD = 0;                                                                // DECLARING A VAR TO KNOW AN SPECIFIC POSITION OF THE LIST
            name = Console.ReadLine();
            foreach (string el in dinosaurs)                                            // MOVING THROUGH THE LIST
            {
                if (el.ToUpper().Equals(name.ToUpper()))                                // IF THE NAME IS FOUND, BREAK THE FOREACH BUCLE
                {
                    nameFound = true;
                    break;
                }
                indexD++;                                                               // INCREASING THE POSITION ON THE LIST
            }
            if (nameFound)                                                              // IF THE NAME EXISTS ON THE LIST, SHOWS THE POSITION
            {
                Console.WriteLine("the dinosaur is at position : {0:d}", indexD);
                break;
            }
            else
            {                                                                           // OTHERWISE REQUEST A NAME AGAIN UNTIL FIND IT ON THE LIST
                Console.WriteLine("The Dinosaur not exist on the list, try againg ; ");
            }
        }



        //************************************************************************************************************************
        // PART FIVE  ASSIGNMENT

        dinosaurs.Add("Spinosaurus");                                                   // USING THE SAME LIST, AND ADDING SAME VALUES TO HAVE THE SAME DATA TWO TIMES
        dinosaurs.Add("Allosaurus");
        dinosaurs.Add("Archaeopteryx");
        dinosaurs.Add("Megalosaurus");

        List<int> dinosaursMatching = new List<int>();                                  // DECLARING A LIST WHERE WE SAVE ALL MATCHES
        

        nameFound = false;
        Console.WriteLine("\n\n\nWrite a dinosaur name to search it on the list : ");
        while (true)
        {
            indexD = 0;
            name = Console.ReadLine();
            foreach (string el in dinosaurs)                                            // MOVING THROUGH THE LIST
            {
                if (el.ToUpper().Equals(name.ToUpper()))                                // COMPARING THE USER INPUT WITH AN SPECIFIC LIST VALUE
                {
                    nameFound = true;
                    dinosaursMatching.Add(indexD);
                }
                indexD++;
            }
            if (nameFound)                                                              // IF A NAME EXISTS SHOWS THE POSITIONS WHERE IT IS LOCATED
            {
                Console.WriteLine("The dinosaur is at positions : "+String.Join(", ", dinosaursMatching.ToArray()));
                break;
            }
            else
            {
                Console.WriteLine("The Dinosaur not exist on the list, try againg ; "); // OTHERWISE REQUEST ANOTHER NAME
            }
        }



        //************************************************************************************************************************
        // PART SIX  ASSIGNMENT

        foreach (string el in dinosaurs)                                // MOVING THROUGH THE LIST
        {
            List<string> dinosaursClean = new List<string>();           // DECLARING A NEW LIST TO SAVE COINCIDENCES
            var newList = dinosaurs.FindAll(s => s.Equals(el));         // SEARCHING ALL COINCIDENCES 
            if(newList.Count >1)                                        // IF THERE ARE MORE THAN ONE COINCIDENCES, 
            {
                Console.WriteLine(el + " \tis already in the list");
            }
            else
            {                                                           // IF THERE IS ONLY ONE COINCIDENCE
                Console.WriteLine(el + " \tis not in the list");
            }

        }

        Console.Read();


    }
}

