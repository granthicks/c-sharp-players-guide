/* Simula's Soup
* 
* Define enumerations for the three variations on food:
*	type (soup, stew, gumbo)
*	main ingredient (mushrooms, chicken, carrots, potatoes)
* 	seasoning (spicy, salty, sweet)
* Make a tuple variable to represent a soup composed of the three above enumeration types.
* Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple with the results
* When done, display the contesnts of the soup tuple variable in a format like "Sweet Chicken Gumbo" */

Console.Title = "Simula's Soup";

FoodType type;
MainIngredient ingredient;
SeasoningType seasoning;


Console.WriteLine("What type of food do you want to make?");
Console.WriteLine("1 - Soup");
Console.WriteLine("2 - Stew");
Console.WriteLine("3 - Gumbo");

int firstChoice = PromptForChoice(3);

type = firstChoice switch
{
	1 => FoodType.Soup,
	2 => FoodType.Stew,
	_ => FoodType.Gumbo,
};

Console.Clear();

Console.WriteLine("What would you like as the main ingredient?");
Console.WriteLine("1 - Mushrooms");
Console.WriteLine("2 - Chicken");
Console.WriteLine("3 - Carrots");
Console.WriteLine("4 - Potatoes");

int secondChoice = PromptForChoice(4);

ingredient = secondChoice switch
{
	1 => MainIngredient.Mushroom,
	2 => MainIngredient.Chicken,
	3 => MainIngredient.Carrot,
	_ => MainIngredient.Potato
};

Console.Clear();

Console.WriteLine("What type of seasoning would you like?");
Console.WriteLine("1 - Spicy");
Console.WriteLine("2 - Salty");
Console.WriteLine("3 - Sweet");

int thirdChoice = PromptForChoice(3);

seasoning = thirdChoice switch
{
	1 => SeasoningType.Spicy,
	2 => SeasoningType.Salty,
	_ => SeasoningType.Sweet
};

Console.Clear();

var food = (Type: type, Ingredient: ingredient, Seasoning: seasoning);

Console.WriteLine($"{food.Seasoning} {food.Ingredient} {food.Type}");

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

enum FoodType { Soup, Stew, Gumbo };
enum MainIngredient { Mushroom, Chicken, Carrot, Potato };
enum SeasoningType { Spicy, Salty, Sweet };