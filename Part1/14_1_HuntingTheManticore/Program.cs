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
int ManticoreDistance = -1;
bool ValidDistance = false;
int GameRound = 1;

// Prompt for Manticore distance
while (ManticoreDistance < 0 || ManticoreDistance > 100)
{
    while (!ValidDistance)
    {
        Console.WriteLine("Player 1: Input the Manticore's distance from the city (0-100): ");
        string strDistance = Console.ReadLine();
        bool IsInt = int.TryParse(strDistance, out ManticoreDistance);
        if (IsInt == true && ManticoreDistance >= 0 && ManticoreDistance <= 100)
            ValidDistance = true;
        else if (ManticoreDistance > 100 || ManticoreDistance < 0)
        {
            Console.WriteLine("Distance must be between 0 and 100!");
        }
        else
        {
            Console.WriteLine("Please enter a valid number for the distance.");
        }
    }
    
    if (ManticoreDistance == 69)
    {
        Console.WriteLine("Nice.");
        Thread.Sleep(1000);
    }
}
Console.Clear();

while (ManticoreHealth > 0 && CityHealth > 0)
{
    Console.WriteLine($"Round {GameRound}");
    Console.WriteLine($"City Health: {CityHealth}");
    Console.WriteLine($"Manticore Health: {ManticoreHealth}");
    Thread.Sleep(1000);
    Console.Clear();
    GameRound++;
    CityHealth--;
    ManticoreHealth--;
}