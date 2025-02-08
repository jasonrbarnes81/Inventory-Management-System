using System;

namespace InventoryManagement
{
    class AddItem
    {
        public static void Add(List<string> items, List<double> prices, List<int> quantities)
        {
            string item = string.Empty;
            double price = 0;
            int quantity = 0;



                while (string.IsNullOrEmpty(item))
                {
                    Console.WriteLine("Enter the item name:");
                    item = Console.ReadLine() ?? string.Empty;
                }

                while (price <= 0)
                {
                    try
                    {
                        Console.WriteLine("Enter the price:");
                        string priceInput = Console.ReadLine() ?? "0";
                        price = double.Parse(priceInput);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        
                    }
                }

                while (quantity <= 0)
                {   
                    try
                    {
                        Console.WriteLine("Enter the quantity:");
                        string quantityInput = Console.ReadLine() ?? "0";
                        quantity = int.Parse(quantityInput);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        
                    }
                }                
          
                items.Add(item);
                prices.Add(price);
                quantities.Add(quantity);
           
            

            Console.WriteLine("Item added successfully!");
        }
    }
}