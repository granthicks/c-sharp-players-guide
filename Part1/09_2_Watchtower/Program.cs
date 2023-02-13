/* Watchtower
 * Prompt for an x and y value as cordinates of an enemy relative to watchtower location
 * Display which direction the watchtower would report the enemy is coming from */

Console.Title = "Watchtower";

Console.WriteLine("Enter the x coordinate of the enemy");
string str_x = Console.ReadLine();
int x = Convert.ToInt32(str_x);

Console.WriteLine("Enter the y coordinate of the enemy");
string str_y = Console.ReadLine();
int y = Convert.ToInt32(str_y);

Console.Clear();

if (x < 0 && y > 0)
    Console.WriteLine("The enemy is to the northwest!");
else if (x == 0 && y > 0)
    Console.WriteLine("The enemy is to the north!");
else if (x > 0 && y > 0)
    Console.WriteLine("The enemy is to the northeast!");
else if (x < 0 && y == 0)
    Console.WriteLine("The enemy is to the west!");
else if (x == 0 && y == 0)
    Console.WriteLine("The enemy is here!");
else if (x > 0 && y == 0)
    Console.WriteLine("The enemy is to the east!");
else if (x < 0 && y < 0)
    Console.WriteLine("The enemy is to the southwest!");
else if (x == 0 && y < 0)
    Console.WriteLine("The enemy is to the south!");
else if (x > 0 && y < 0)
    Console.WriteLine("The enemy is to the southeast!");
else
    Console.WriteLine("Unable to see the enemy!");