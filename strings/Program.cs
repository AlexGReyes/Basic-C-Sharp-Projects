using System;
using System.Text;


namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "this is an String ";                                            // declaring 3 strings
            string b = "this is another String ";
            string c = "this is the final String";

            string ABC = a + b + c;                                                     // concatenating 3 strings
            Console.WriteLine(ABC);

            Console.WriteLine(a.ToUpper());                                             // converting string a to uppercase

            StringBuilder sb = new StringBuilder();                                     // creating a new instance of StringBuilder

            sb.Append("In mathematics and mathematical logic, Boolean algebra ");       // appending text to the object sb
            sb.Append("is the branch of algebra in which the values of ");
            sb.Append("the variables are the truth values true and false");

            Console.WriteLine(sb);                                                      // displaying the string

            Console.Read();

        }
    }
}
