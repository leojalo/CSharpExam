using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the first array
            string[] names = { "Alice", "John", "Mia" };

            // Creates the second array
            int[] numbers = { 12, 45, 78, 3, 99, 21, 8 };

              // Loops through the first array and prints hello for every name
            foreach (var name in names)
            {
                Console.WriteLine($"Hello, {name}");
            }

            // 4. Sort the second array in descending order, remove the last element, and print the result
            numbers = numbers.OrderByDescending(n => n).ToArray();
            numbers = numbers.Take(numbers.Length - 1).ToArray();

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }


            Console.ReadLine();

        }
    }
}
    

