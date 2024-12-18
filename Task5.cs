using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary to store items and their definitions
            Dictionary<string, string> Items = new Dictionary<string, string>();
            string userInput;

            do
            {
                // Display menu options
                Console.WriteLine("a. Add an item and its definition");
                 Console.WriteLine("b. Remove an item");
                Console.WriteLine("c. Show all items and their definitions"); 
               Console.WriteLine("d. Leave");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "a":
                        // Add an item and its definition
                        Console.Write("Enter the item: ");
                        string item = Console.ReadLine();
                        Console.Write("Enter the description: ");
                         string description = Console.ReadLine();

                        if (Items.ContainsKey(item))
                        {
                            Console.Write("This item already exists. Do you want to overwrite it? (yes/no): ");
                            string overwrite = Console.ReadLine().ToLower();

                            if (overwrite == "yes")
                            {
                                Items[item] = description;
                                Console.WriteLine("Item was successfully uptated.");
                            }
                            else
                            {
                                Console.WriteLine("Item was not updated.");
                            }
                        }
                         else
                        {
                            Items.Add(item, description);
                            Console.WriteLine("Item was added.");
                        }
                        break;

                    case "b":
                        // Remove an item
                        Console.Write("Enter the item to remove: ");
                        string itemToRemove = Console.ReadLine();

                        if (Items.ContainsKey(itemToRemove))
                        {
                            Items.Remove(itemToRemove);
                            Console.WriteLine("Item removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Item was not found.");
                        }
                        break;

                    case "c":
                        // Show all items and their definitions
                        Console.WriteLine("\nItems and their definitions:");
                        foreach (var pair in Items)
                        {
                            Console.WriteLine($"- {pair.Key}: {pair.Value}");
                        }
                        break;

                    case "d":
                        // Exit the program
                        Console.WriteLine("Exiting...");
                        break;

                     default:
                        Console.WriteLine("Invalid option please try again.");
                        break;
                }
            } while (userInput != "d");
       
        
        
        }
    }
}
  