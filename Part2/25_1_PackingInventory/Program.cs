/* Packing Inventory
 * 
 * Create an InventoryItem class that represents any of the different item types. 
 *      This class must represent the item's weight and volume, which it needs at creation time (constructor).
 * (1) An arrow has a weight of 0.1 and a volume of 0.05. (2) A bow has a weight of 1 and a volume 
 * of 4.(3) Rope has a weight of 1 and a volume of 1.5.(4) Water has a weight of 2 and a volume of 3. (5) Food 
 * rations have a weight of 1 and a volume of 0.5. (6) A sword has a weight of 5 and a volume of 3.
 * Create derived classes for each of they types of items above.
 *      Each class should pass the correct weight and volume to the base class constructor but should be createable 
 *      themselves with a parameterless constructor.
 * Build a Pack class that can store an array of items. The total number of items, the maximum weight,
 *      and maximum volume are provided at creation time and cannot change afterward.
 *  Make a public bool Add(InventoryItem item) method to Pack that allows you to add items 
 *       of any type to the pack’s contents.This method should fail (return false and not modify the pack’s 
 *       fields) if adding the item would cause it to exceed the pack’s item, weight, or volume limit.
 *  Add properties to Pack that allow it to report the current item count, weight, and volume, and the
 *      limits of each.
 *   Create a program that creates a new pack and then allow the user to add (or attempt to add) items 
 *      chosen from a menu. */

Console.Title = "Packing Inventory";

Pack pack = new Pack(10, 20, 30);

while (true)
{
    Console.WriteLine($"Pack is currently at {pack.CurrentCount}/{pack.MaxCount} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");

    Console.WriteLine("What do you want to add?");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    Console.WriteLine("0 - Exit");

    Console.Write("Choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    if (choice == 0) 
    {
        Console.WriteLine("Goodbye.");
        break;
    }

    if (choice < 0 || choice > 6)
    {
        Console.WriteLine("Invalid choice.");
        continue;
    }

    InventoryItem newItem = choice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };

    if (!pack.Add(newItem))
        Console.WriteLine("Could not add this to the pack.");
}

public class Pack
{
    public int MaxCount { get; }
    public float MaxVolume { get; }
    public float MaxWeight { get; }

    private InventoryItem[] _items;
    
    public int CurrentCount { get; private set; }
    public float CurrentVolume { get; private set; }
    public float CurrentWeight { get; private set; }

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        MaxCount = maxCount;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;

        _items = new InventoryItem[maxCount];
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentCount >= MaxCount) return false;
        if (CurrentVolume + item.Volume > MaxVolume) return false;
        if (CurrentWeight + item.Weight > MaxWeight) return false;

        _items[CurrentCount] = item;
        CurrentCount++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;
    }
}

public class InventoryItem
{
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem { public Arrow() : base(0.1f, 0.05f) { } }
public class Bow : InventoryItem { public Bow() : base(1, 4) { } }
public class Rope : InventoryItem { public Rope() : base(1, 1.5f) { } }
public class Water : InventoryItem { public Water() : base(2, 3) { } }
public class Food : InventoryItem { public Food() : base(1, 0.5f) { } }
public class Sword : InventoryItem { public Sword() : base(5, 3) { } }