/* Packing Inventory
 * 
 * Create an InventoryItem class that represents any of the different item types. 
 *      This class must represent the item's weight and volume, which it needs at creation time (constructor).
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

public class InventoryItem
{
    public double Weight { get; }
    public double Volume { get; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem
{
    public Arrow() : base(0.1, 0.05)
    {

    }
}

public class Bow : InventoryItem
{
    public Bow() : base(1, 4)
    {

    }
}

public class Rope : InventoryItem
{
    public Rope(): base(1, 1.5)
    {

    }
}

public class Water : InventoryItem
{
    public Water() : base(2, 3)
    {

    }
}

public class Rations : InventoryItem
{
    public Rations() : base(1, 0.5)
    {

    }
}

public class Sword : InventoryItem
{
    public Sword() : base(5, 3)
    {

    }
}

public class Pack
{
    private InventoryItem[] items;
    private int maxItems;
    private double maxWeight;
    private double maxVolume;
    private int itemCount;
    private double currentWeight;
    private double currentVolume;

    public Pack(int maxItems, double maxWeight, double maxVolume)
    {
        this.maxItems = maxItems;
        this.maxWeight = maxWeight;
        this.maxVolume = maxVolume;
        items = new InventoryItem[maxItems];
    }

    public bool Add(InventoryItem item)
    {
        if (itemCount >= maxItems || currentWeight + item.Weight > maxWeight || currentVolume + item.Volume > maxVolume)
        {
            return false;
        }
        else
        {
            items[itemCount] = item;
            itemCount++;
            currentWeight += item.Weight;
            currentVolume += item.Volume;
            return true;
        }
    }

    public int ItemCount => itemCount;

    public double CurrentWeight => currentWeight;

    public double CurrentVolume => currentVolume;

    public int MaxItems => maxItems;

    public double MaxWeight => maxWeight;

    public double  MaxVolume => maxVolume;
}

public class Program
{
    static void Main(string[] args)
    {
        Pack pack = new Pack()
}


