using InventoryManager;
using System.Collections;
using System.ComponentModel;

Inventory inventory = new Inventory();

Console.WriteLine("Welcome to Inventory Manager v1.0");
Console.WriteLine("Press any key to initialize the aplication: ");
string exit = Console.ReadLine();

do
{
    Console.WriteLine("What you want to do? ");
    Console.WriteLine("1-List inventory");
    Console.WriteLine("2-Add item to the inventory");
    Console.WriteLine("3-Update inventory item");
    Console.WriteLine("4-Remove item to the inventory");
    Console.WriteLine("9-Exit");

    string selectOption = Console.ReadLine();
    switch (selectOption)
    {
        case "1":
            inventory.ShowItems();
            break;
        case "2":
            Item item = new();
            inventory.AddItem(item.CreateItem());
            break;
        case "3":
            Console.WriteLine("Insert item sku to update products: ");
            Item updatedItem = new();
            string index = Console.ReadLine();
            inventory.UpdateItem(index);
            break;
        case "4":
            Console.WriteLine("Insert item SKU to remove products: ");
            int removedItem = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveItem(removedItem);

            break;
        case "9":
            Console.WriteLine("Exit? YES/NO");
            exit = Console.ReadLine();
            break;
    }

} while (exit.ToUpper() != "YES");




Item newitem = new Item("124812", "tablet", "tablet samsung", 999.99m, 20);
inventory.AddItem(newitem);
