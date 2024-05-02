using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class Item
    {
        private string? _sku;
        private string? _name;
        private string? _description;
        private decimal _price;
        private int _quantity;

        public Item() { }
        public Item(string sku, string name, string description, decimal price, int quantity)
        {
            _sku = sku;
            _name = name;
            _description = description;
            _price = price;
            _quantity = quantity;
        }

        public string? SKU { get { return _sku; } set { _sku = value; } }
        public string? Name { get { return _name; } set { _name = value; } }
        public string? Description { get { return _description; } set { _description = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }

        public Item CreateItem()
        {

            Console.WriteLine("Insert item SKU: ");
            string? sku = Console.ReadLine();

            Console.WriteLine("Insert item name: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Insert item description: ");
            string? description= Console.ReadLine();

            Console.WriteLine("Insert item price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insert item quantity in stock: ");
            int quantity= Convert.ToInt32(Console.ReadLine());

            Item item = new Item(sku, name, description, price, quantity);
            
            return item;
        }

    }
}