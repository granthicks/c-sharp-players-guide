/* Discounted Inventory
 * Display menu of the shop
 * Ask user to enter number from the menu
 * Ask user for name
 * If name is Grant, give a 50% discount
 * Display the cost of the selected item */

string item;
int price;

Console.Title = "Discounted Inventory";

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.WriteLine("What number do you want to see the price of?");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        item = "Rope";
        price = 10;
        break;
    case 2:
        item = "Torches";
        price = 15;
        break;
    case 3:
        item = "Climbing Equipment";
        price = 25;
        break;
    case 4:
        item = "Clean Water";
        price = 1;
        break;
    case 5:
        item = "Machete";
        price = 20;
        break;
    case 6:
        item = "Canoe";
        price = 200;
        break;
    case 7:
        item = "Food Supplies";
        price = 1;
        break;
    default:
        item = "Nothing";
        price = 0;
        break;
}

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

if (name == "Grant")
{
    Console.WriteLine("Oh! It's you! We have a special price for someone as awesome as you!");
    price = price / 2;
}
else
    Console.WriteLine("That's a funny sounding name.");

if (item != "Nothing")
    Console.WriteLine($"{item} costs {price} gold.");
else
    Console.WriteLine("I don't seem to have that in stock...");