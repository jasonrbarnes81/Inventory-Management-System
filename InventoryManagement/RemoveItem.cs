using System;

namespace InventoryManagement
{
    class RemoveItem
    {
        public static void Remove(List<string> items, List<double> prices, List<int> quantities)
        {
            ViewItem.View(items, prices, quantities);
            Console.WriteLine();
            Console.WriteLine("Enter the item name to remove:");
            string item = Console.ReadLine();
            int index = items.IndexOf(item);
            if (index == -1)
            {
                Console.WriteLine("Item not found.");
            }
            else
            {
                items.RemoveAt(index);
                prices.RemoveAt(index);
                quantities.RemoveAt(index);
                Console.WriteLine("Item removed successfully!");
            }
        }
    }
}