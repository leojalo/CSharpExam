using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks the user to enter their age
            Console.Write("Please enter the number: ");
            string ageInput = Console.ReadLine();
            int Age = int.Parse(ageInput);
            const int LegalAge = 0;

                //
            if (Age == LegalAge) 
            {
                // Tells the user their number is zero
                Console.WriteLine("The number is zero");
            }
                // Checks if number is positve or negative
            if (Age > LegalAge)
            {
                // Tells the user their number is positive
                Console.WriteLine("The number is positive");
            }

            if (Age < LegalAge)
            {
                // Tells the user their number is negative
                Console.WriteLine("The number is negative");
            }
            
            Console.ReadLine(); 
           
        }
    }   
}
