/* The Magic Cannon
 * A magic cannon has a fire gem and an electic gem
 * every third turn of a crank the fire gem activates
 * every fifth turn the electric gem activates
 * when both line up, it is a combined blast
 * Loop through 1-100 and display what kind of blast the crew should expect.
 * Change the color of the output based on the type of blast.
 * red - fire
 * yellow - electric
 * blue - electric/fire */

Console.Title = "The Magic Cannon";

int crankTurn = 1;

while (crankTurn <= 100)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    if (crankTurn % 3 == 0 && crankTurn % 5 ==0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("POTENT COMBINED BAJA BLAST!");
    }
    else if (crankTurn % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric");
    }
    else if (crankTurn % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
    }
    else 
    {
        Console.WriteLine("Normal");
    }
    crankTurn++;
}