 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("What is your age?");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0) { throw new ArgumentException(); }
                    Console.WriteLine("You were born in {0}", DateTime.Now.Year - age);
                    Console.ReadLine();
                
                
            }
            catch (ArgumentException)
            {
                
                Console.WriteLine("Invalid Input; Age cannot be Negative or Zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter your age as a positive integer");
            }
            Console.ReadLine();
        }
    }
}
