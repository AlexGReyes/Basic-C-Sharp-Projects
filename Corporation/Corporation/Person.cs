using System;


namespace Corporation
{
    class Person
    {
        public string FirstName { set; get; }                           // DECLARING TWO PROPERTIES 
        public string LastName { set; get; }

        public void SayName()                                           // DISPLAYING TWO PROPERTIES
        {
            Console.WriteLine( "Name : {0} {1}", FirstName, LastName);
        }
    }
}
