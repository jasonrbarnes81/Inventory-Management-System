using System;

namespace InventoryManagement
{
    class UpdateItem
    {
        public static void Update(List<string> items, List<double> prices, List<int> quantities)
        {
            Console.WriteLine("Enter the item name to update:");
            string item = Console.ReadLine();
            int index = items.IndexOf(item);
            if (index == -1)
            {
                Console.WriteLine("Item not found.");
            }
            else
            {
                Console.WriteLine("Enter the new item name:");
                string newItem = Console.ReadLine();
                items[index] = newItem;

                Console.WriteLine("Enter the new price:");
                double newPrice = Convert.ToDouble(Console.ReadLine());
                prices[index] = newPrice;

                Console.WriteLine("Enter the new quantity:");
                int newQuantity = int.Parse(Console.ReadLine());
                quantities[index] = newQuantity;

                Console.WriteLine("Item updated successfully!");
            }
        }
    }
}