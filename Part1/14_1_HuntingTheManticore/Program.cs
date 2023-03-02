/* Hunting the Manticore
 * First Boss 
 * Game starting state:
 *      Manticore begins with 10 health points
 *      City begins with 15 health points
 *      Game starts at round 1
 * Ask the first player to choose the Manticore's distance from the city (0 to 100)
 * Clear the screen
 * Run the game in a loop until either the Manticore's or city's health reduces to 0
 * Before the second players turn display:
 *      The round number
 *      The city's health
 *      The Manticore's health
 * Compute how much damage teh cannon will deal this round:
 *      10 points if the round number is a multiple of both 3 and 5
 *      3 if it is a multiple of 3 or 5 (but not both)
 *      1 otherwise
 * Display damage to the player
 * Get a target range from the second player and resolve its effect
 *      Overshot
 *      fell short
 *      hit
 *          if hit reduce the Manticore's health by the expected amount
 * If the Manticore is still alive, reduce the city's health by 1
 * Advence to next round
 * When the Manticore or City health is 0, end the game and display the outcome. */

Console.Title = "Hunting the Manticore";

int ManticoreHealth = 10;
int CityHealth = 15;
int GameRound = 1;

// Prompt for Manticore distance
int ManticoreDistance = PromptForNumber("Player 1: Input the Manticore's distance from the city (0-100): ", 0, 100);
Console.Clear();

while (ManticoreHealth > 0 && CityHealth > 0)
{
    Console.WriteLine($"Round {GameRound}");
    Console.WriteLine($"City Health: {CityHealth}");
    Console.WriteLine($"Manticore Health: {ManticoreHealth}");
    Console.WriteLine("-----------------------------------");

    int RangeGuess = PromptForNumber("Player 2: Input the range to fire the cannon.", 0, 100);

    if (RangeGuess > ManticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Too far! The shot fell beyond the Manticore.");
        Console.ResetColor();
        Thread.Sleep(1000);
        CityHealth--;
    }
    else if (RangeGuess < ManticoreDistance)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Too short! The shot didn't make it to the Manticore.");
        Console.ResetColor();
        Thread.Sleep(1000);
        CityHealth--;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Direct hit!");
        int DamageDone = CalcDamage(GameRound);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The Manticore took {DamageDone} points of damage!");
        Console.ResetColor();
        Thread.Sleep(1000);
        ManticoreHealth -= DamageDone;
    }
    Console.Clear();
    GameRound++;
}

if (CityHealth > 0)
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("Success! The Manticore has been defeated!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Oh no! We weren't able to stop the Manticore and the city is lost!");
    Console.ResetColor();
}
Console.Write("Press enter to exit.");
string Quit = Console.ReadLine();

int PromptForNumber(string message, int MinNum, int MaxNum)
{
    int PromptNum = MinNum - 1;
    bool IsValid = false;

    while (PromptNum < MinNum || PromptNum > MaxNum)
    {
        while (!IsValid)
        {
            Console.WriteLine(message);
            string strDistance = Console.ReadLine();
            bool IsInt = int.TryParse(strDistance, out PromptNum);
            if (IsInt == true && PromptNum >= MinNum && PromptNum <= MaxNum)
                IsValid = true;
            else if (PromptNum > MaxNum || PromptNum < MinNum)
            {
                Console.WriteLine($"Number must be between {MinNum} and {MaxNum}!");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        if (PromptNum == 69)
        {
            Console.WriteLine("Nice.");
            Thread.Sleep(1000);
        }
    }
    return PromptNum;
}

int CalcDamage(int CurrentRound)
{
    if (CurrentRound % 3 == 0 && CurrentRound % 5 == 0)
    {
        return 10;
    }
    else if (CurrentRound % 3 == 0 || CurrentRound % 5 == 0)
    {
        return 3;
    }
    else
    {
        return 1;
    }
}