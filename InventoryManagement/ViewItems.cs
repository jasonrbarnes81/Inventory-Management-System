using System;

namespace InventoryManagement
{
    class ViewItem
    {
        public static void View(List<string> items, List<double> prices, List<int> quantities)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Item: " + items[i] + " Price: " + prices[i] + " Quantity: " + quantities[i]);
                Console.WriteLine();
            }
        }
    }
}