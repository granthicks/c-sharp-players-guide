/* Arrow Factories
 * Most arrows are one of three standard arrows.
 * - The Elite Arrow
 *      steel arrowhead
 *      plastic fletching
 *      95cm shaft
 * - The Beginner Arrow
 *      wood arrowhead
 *      goose feathers
 *      75cm shaft
 * - The Marksman Arrow
 *      steel arrowhead
 *      goose feathers
 *      65cm shaft
 * Modify your Arrow class one final time to incude static methods of the fiorm
 * public static Arrow CreateEliteArrow() { ... }
 * 
 * Modify the program to allow users to choose one of these pre-defined types or a custom arrow.
 * If they select one of the predefined styles, produce an Arrow instance using one of the new static
 * methods. If they choose to make a custom arrow, use your earlier code to get their custom data about
 * the desired arrow. */

Console.Title = "Arrow Factories";

int arrowhead_choice;
int fletching_choice;
int length_choice = 0;
Arrow arrowSelection;

Console.WriteLine("Would you like to buy a standard arrow or a custom one?");
Console.WriteLine("1 - The Elite Arrow");
Console.WriteLine("2 - The Beginner Arrow");
Console.WriteLine("3 - The Marksman Arrow");
Console.WriteLine("4 - Custom Arrow");

int first_choice = PromptForChoice(4);

if (first_choice == 1)
{
     arrowSelection = Arrow.CreateEliteArrow();
     Console.Clear();
}
else if (first_choice == 2)
{
     arrowSelection = Arrow.CreateBeginnerArrow();
     Console.Clear();
}
else if (first_choice == 3)
{
     arrowSelection = Arrow.CreateMarksmanArrow();
     Console.Clear();
}
else
{
    Console.Clear();

    Console.WriteLine("What type of arrowhead would you like to use?");
    Console.WriteLine("1 - Steel");
    Console.WriteLine("2 - Wood");
    Console.WriteLine("3 - Obsidian");

    arrowhead_choice = PromptForChoice(3);

    Console.Clear();

    Console.WriteLine("What type of fletching would you like to use?");
    Console.WriteLine("1 - Plastic");
    Console.WriteLine("2 - Turkey Feathers");
    Console.WriteLine("3 - Goose Feathers");

    fletching_choice = PromptForChoice(3);

    Console.Clear();

    while (length_choice < 60 || length_choice > 100)
    {
        Console.WriteLine("How long (in cm) would you like the arrow shaft to be? (0-60)");
        string strLengthChoice = Console.ReadLine();
        try
        {
            length_choice = Convert.ToInt32(strLengthChoice);
        }
        catch
        {
            Console.WriteLine("Sorry! That's not a valid option.");
            Thread.Sleep(1000);
            Console.Clear();
            continue;
        }
        if (length_choice < 60)
        {
            Console.WriteLine("That's too short!");
        }
        else if (length_choice > 100)
        {
            Console.WriteLine("That's too long!");
        }
        else if (length_choice == 69)
        {
            Console.WriteLine("Nice.");
        }
        Thread.Sleep(1000);
        Console.Clear();
    }
    arrowSelection = new Arrow(arrowhead_choice, fletching_choice, length_choice);
}


Console.WriteLine($"Your arrow selection costs {arrowSelection.GetCost()} gold.");
Console.ReadLine();

int PromptForChoice(int numChoices)
{
bool isValid = false;
int choice = 0;
string strChoice;
while (!isValid)
{
Console.Write("Enter the number for your selection: ");
strChoice = Console.ReadLine();
try
{
choice = Convert.ToInt32(strChoice);
}
catch
{
Console.WriteLine("Sorry! That's not an option.");
continue;
}
if (choice >= 1 && choice <= numChoices)
{
isValid = true;
}
else
{
Console.WriteLine("Sorry! That's not an option.");
continue;
}
}
return choice;
}

class Arrow
{
    private ArrowheadType _arrowhead;
    private FletchingType _fletching;
    private int _length;

    public Arrow(int arrowheadChoice, int fletchingChoice, int lengthChoice)
    {
        _arrowhead = (ArrowheadType)arrowheadChoice;
        _fletching = (FletchingType)fletchingChoice;
        _length = lengthChoice;
    }

    public ArrowheadType Arrowhead { get; set; }
    public FletchingType Fletching { get; set; }
    public int Length { get; set; }

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(1, 1, 95);
    }

    public static Arrow CreateBeginnerArrow()
    {
        return new Arrow(2, 3, 75);
    }

    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(1, 3, 65);
    }

    public float GetCost()
    {
        double cost = 0.00;
        if (_arrowhead == ArrowheadType.Steel)
        {
            cost += 10;
        }
        else if (_arrowhead == ArrowheadType.Wood)
        {
            cost += 3;
        }
        else
        {
            cost += 5;
        }
        if (_fletching == FletchingType.Plastic)
        {
            cost += 10;
        }
        else if (_fletching == FletchingType.TurkeyFeather)
        {
            cost += 5;
        }
        else
        {
            cost += 3;
        }
        cost += (_length * 0.05);
        return (float)cost;
    }
}

enum ArrowheadType
{
    Steel = 1,
    Wood = 2,
    Obsidian = 3
};
enum FletchingType
{
    Plastic = 1,
    TurkeyFeather = 2,
    GooseFeather = 3
};
