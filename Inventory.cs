﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Inventory
    {
        private readonly List<Item> ListItems;

        public Inventory()
        {
            ListItems = new List<Item>();
        }


        public void AddItem(Item item)
        {
            
            Item newItem = new Item
            {
                SKU = item.SKU,
                Name = item.Name,
                Description= item.Description,
                Price= item.Price,
                Quantity= item.Quantity,

            };
            ListItems.Add(newItem);
        }

        public void ShowItems() {
            
            foreach (var item in ListItems) {
                Console.WriteLine($"\nSKU: {item.SKU}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Description: {item.Description}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Quantity in stock: {item.Quantity}");
                Console.WriteLine("_______________________________________");

            }
        }
        public void RemoveItem(int index)
        {
            ListItems.RemoveAt(index);
        }

        public void UpdateItem(string sku)
        {
            Console.WriteLine(ListItems.Find(p => p.SKU.Contains(sku)));
            
        }
    }
}
