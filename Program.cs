using InventoryManager;
using System.Collections;

string? sku = "";
string? name = "";
string? description = "";
string? price = "";
string? quantity = "";
Inventory inventory = new Inventory();

Console.WriteLine("Welcome to Inventory Manager v1.0");
Console.WriteLine("Press any key: ");
string exit = Console.ReadLine();
do
{
    Console.WriteLine("What you want to do? ");
    Console.WriteLine("1-List inventory");
    Console.WriteLine("2-Add item to the inventory");
    Console.WriteLine("4-Remove item to the inventory");
    Console.WriteLine("9-Exit");

    string selectOption = Console.ReadLine();
    switch (selectOption)
    {
        case "1":
            inventory.ShowItems();
            break;
        case "2":
            Console.WriteLine("Insert SKU");
            sku = Console.ReadLine();
            Console.WriteLine("Insert Name");
            name = Console.ReadLine();
            Console.WriteLine("Insert Description");
            description = Console.ReadLine();
            Console.WriteLine("Insert Price");
            price = Console.ReadLine();
            Console.WriteLine("Insert Quantity");
            quantity = Console.ReadLine();
            ProductItem item = new ProductItem(sku, name, description, Convert.ToDecimal(price), Convert.ToInt32(quantity));
            inventory.AddItem(item);
            break;
        case "4":
            Console.WriteLine("Insert SKU to remove products: ");
            int index = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveItem(index);
            break;
        case "9":
            Console.WriteLine("Exit? YES/NO");
            exit = Console.ReadLine();
            break;
    }

} while (exit.ToUpper() != "YES");




ProductItem newitem = new ProductItem("124812", "tablet", "tablet samsung", 999.99m, 20);
inventory.AddItem(newitem);
