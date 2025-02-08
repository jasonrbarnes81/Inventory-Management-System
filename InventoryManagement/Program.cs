
using System;



namespace InventoryManagement
{
    class Program
    {
        static List<string> items = new List<string>();
        static List<double> prices = new List<double>();
        static List<int> quantities = new List<int>();
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Welcome to the Inventory Management System!");

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Remove an item");
                Console.WriteLine("3. Update an item");
                Console.WriteLine("4. View an item");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddItem.Add(items, prices, quantities);
                        break;
                    case 2:
                        RemoveItem.Remove(items, prices, quantities);
                        break;
                    case 3:
                        UpdateItem.Update(items, prices, quantities);
                        break;
                    case 4:
                        ViewItem.View(items, prices, quantities);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            // Your code here
        }
    }
}