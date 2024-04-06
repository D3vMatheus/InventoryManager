using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Inventory
    {
        private readonly List<ProductItem> productItems;

        public Inventory()
        {
            productItems = new List<ProductItem>();
        }

        public void AddItem(ProductItem item)
        {
            ProductItem newItem = new ProductItem
            {
                SKU = item.SKU,
                ItemName = item.ItemName,
                Description= item.Description,
                Price= item.Price,
                Quantity= item.Quantity,

            };
            productItems.Add(newItem);
        }

        public void ShowItems() {
            
            foreach (var item in productItems) {
                Console.WriteLine($"\nSKU: {item.SKU}");
                Console.WriteLine($"Name: {item.ItemName}");
                Console.WriteLine($"Description: {item.Description}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Quantity in stock: {item.Quantity}");

            }
        }
        public void RemoveItem(int index)
        {
            productItems.RemoveAt(index);
        }
    }
}
