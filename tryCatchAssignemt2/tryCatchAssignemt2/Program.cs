using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchAssignemt2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please. write your Age : ");
                int age;

                if (Int32.TryParse(Console.ReadLine(), out age))
                {
                    if(age < 0)
                    {
                        throw new LessThanCeroException();
                    }else if(age == 0)
                    {
                        throw new EqualsToZeroException();
                    }
                    DateTime date = DateTime.Now.AddYears((age * -1));
                    Console.WriteLine("You have born in "+ date.ToString());
                }
                else
                {
                    Console.WriteLine("Please, write only digits, no decimal");
                }
            }
            catch (LessThanCeroException)
            {
                Console.WriteLine("Age cannot be a negative number");
            }
            catch (EqualsToZeroException)
            {
                Console.WriteLine("Age cannot be equals to zero");
            }
            catch (Exception)
            {
                Console.WriteLine("An error has ocurred");
            }
            finally
            {
                Console.WriteLine("Bye :(");
            }

            Console.Read();

        }
    }
}
