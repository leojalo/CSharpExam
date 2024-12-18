using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            
           // Asks user for an integer and convert it
            Console.Write("Enter an integer: ");
            int integerInput = Convert.ToInt32(Console.ReadLine());

            // Asks user for a double and convert it
            Console.Write("Enter a double: ");
            double doubleInput = Convert.ToDouble(Console.ReadLine());

             // Asks user for a float and convert it
            Console.Write("Enter a float: ");
            float floatInput = float.Parse(Console.ReadLine());

            // Asks the user for a string input 
            Console.Write("Enter a string: ");
            string stringInput = Console.ReadLine();

            
            // Print all inputs
            Console.WriteLine("\nYour inputs:");
            
            Console.WriteLine($"Integer with .0: {integerInput}.0");
            
            Console.WriteLine($"Double: {doubleInput}");
            
            Console.WriteLine($"Float: {floatInput}");
            
            Console.WriteLine($"String: {stringInput}");

            
            // Prints brief explanations
            Console.WriteLine("\nDifferent data type explanations:");
            
            Console.WriteLine("int: Stores whole numbers.");
            
            Console.WriteLine("double: Stores decimal numbers with high precision.");
            
            Console.WriteLine("float: Stores decimal numbers with lower precision than double.");
            
            Console.WriteLine("string: Stores text.");
        
        
            Console.ReadLine();
        }

    }
}
    

