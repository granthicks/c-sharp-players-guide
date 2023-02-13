/* Repairing the Clocktower
 * Take a number as input
 * Display the word 'tick' if number is even
 * Display the word 'tock' if number is odd */

Console.Title = "Repairing the Clocktower";

Console.WriteLine("Please input a number");
string user_input = Console.ReadLine();

int num = Convert.ToInt32(user_input);

if (num % 2 == 0)
    Console.WriteLine("Tick");
else if (num % 2 != 0)
    Console.WriteLine("Tock");
else
    Console.WriteLine("Something went wrong!");