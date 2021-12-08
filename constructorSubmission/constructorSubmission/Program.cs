using System;


namespace constructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SCHOOL = "The Tech Academy";                                                           // DECLARATION OF A CONSTANT VARIABLE

            Person user01 = new Person("Alejandro", "Reyes", 35);                                               // CREATION OF AN INSTANCE OF PERSON

            Console.WriteLine("{0} {1}({2}) Welcome to {3}\n\n\n", user01.FirstName, user01.LastName, user01.ID, SCHOOL);// DISPLAYING DATA FROM PERSON AND THE SCHOOL


            var user02 = new Person(30);                                                                        // DELARATION OF AN INSTANCE OF PERSON USING KEYWORD VAR
            Console.WriteLine("{0} {1}({2}) Welcome to {3}\n\n\n", user02.FirstName, user02.LastName, user02.ID, SCHOOL);

            Console.Read();


        }
    }
}
