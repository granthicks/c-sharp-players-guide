/* Colored Items
 *
 * You have a sword, bow, and axe.
 * Define a generic class to represent a colored item.
 *    It must have properties for the item itself (generic in type)
 *    and a ConsoleColor associated with it.
 *
 * Add a void Display() method to your colored item type that changes the consoles
 *    foreground color to the item's colort and displays the item in that color.
 *
 * In your main method, create a new colored item containing a blue sword, a red bow,
 *    and a green axe. Display all three items to see each item diaplayed in its color. */

Console.Title = "Colored Items";

ColoredItem<Sword> blueSword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue );
ColoredItem<Bow> redBow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red );
ColoredItem<Axe> greenAxe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green );

blueSword.Display();
redBow.Display();
greenAxe.Display();

public class ColoredItem<T>
{
    public T Item { get; }
    public ConsoleColor Color { get; }

    public ColoredItem(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
    }
}

public class Sword { }

public class Bow { }

public class Axe { }