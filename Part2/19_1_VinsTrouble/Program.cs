/* Vin's Trouble
 * Modify your arrow class to have private instead of public fields
 * Add in getter methods for each of the fields that you have. */

using System.ComponentModel.Design;
using System.Threading;
Console.Title = "Vin's Trouble";

int arrowhead_choice;
int fletching_choice;
int length_choice = 0;

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

Arrow arrowSelection = new Arrow(arrowhead_choice, fletching_choice, length_choice);

Console.WriteLine($"Your arrow selection costs {arrowSelection.GetCost()} gold.");
Console.ReadLine();

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

    public ArrowheadType GetArrowhead() => _arrowhead;
    public FletchingType GetFletching() => _fletching;
    public int GetLength() => _length;

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