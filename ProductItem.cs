using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public class ProductItem
    {
        private string? _sku;
        private string? _itemName;
        private string? _description;
        private decimal _price;
        private int _quantity;

        public ProductItem() { }
        public ProductItem(string sku, string itemName, string description, decimal price, int quantity)
        {
            _sku = sku;
            _itemName = itemName;
            _description = description;
            _price = price;
            _quantity = quantity;
        }

        public string? SKU { get { return _sku; } set { _sku= value; } }
        public string? ItemName { get { return _itemName; } set { _itemName = value; } }
        public string? Description { get { return _description; } set { _description = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }

    }
}