/* The Defense of Consolas
 * City of Consolas is represented by an 8x8 square.
 * Prompt for target row and column
 * Compute neighboring rows/columns to place squad
 * Display deployment instructions. 
 * Play beep when complete */

Console.Title = "The Defense of Consolas";

Console.WriteLine("Target Row?");
string str_row = Console.ReadLine();
int row = Convert.ToInt32(str_row);

Console.Clear();

Console.WriteLine("Target Column?");
string str_col = Console.ReadLine();
int col = Convert.ToInt32(str_col);

Console.Clear();

Console.WriteLine("Deploy to:");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"({row}, {col - 1})");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"({row - 1}, {col})");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"({row}, {col + 1})");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"({row + 1}, {col})");

Console.Beep(659, 125);
Console.Beep(659, 125);
Thread.Sleep(125);
Console.Beep(659, 125);
Thread.Sleep(167);
Console.Beep(523, 125); 
Console.Beep(659, 125);
Thread.Sleep(125);
Console.Beep(784, 125);
Thread.Sleep(375);
Console.Beep(392, 125);