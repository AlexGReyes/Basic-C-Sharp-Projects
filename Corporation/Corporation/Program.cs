using System;


namespace Corporation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();                 // CREATING AN INSTANCE OF CLASS EMPLOYEE
            employee.FirstName = "Sample";                      // INITIALIZING TWO PROPERTIES
            employee.LastName = "Student";
            employee.SayName();                                 // CALLING A METHOD FROM CLASS EMPLOYEE
            Console.Read();
        }
    }
}
