using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace studentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                //  create and save a new student
                Console.Write("Enter a First Name for a new Student: ");
                var fname = Console.ReadLine();

                Console.Write("Enter a Last Name for a new Student: ");
                var lname = Console.ReadLine();

                var student = new Student { fName = fname, lName = lname };
                db.Student.Add(student);
                db.SaveChanges();

                //display all students from the database
                var query = from b in db.Student
                            select b;

                Console.WriteLine("All students in the database");
                foreach (var st in query)
                {
                    Console.WriteLine(st.fName+" "+st.lName);
                }

                Console.Read();

            }
        }
    }

    public class Student
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }

    public class Grade
    {
        public int id { get; set; }
        public string subject { get; set; }
        public float grade { get; set; }
        public virtual Student student { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }
    }

}
