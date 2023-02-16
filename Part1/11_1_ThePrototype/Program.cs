/* The Prototype
 * Prompt user for a number guess between 0 and 100
 * If the number is above 100 or less than 0, keep asking
 * Clear the screen once the program has collected a good number
 * Ask a second user, the hunter, to guess the number
 * Indicate whether the user guessed too high, too low, or guessed right
 * Loop until they get it right, then end the program. */

Console.Title = "The Prototype";

int user1Guess;
int user2Guess;

do
{
    Console.WriteLine("User 1, enter a number between 0 and 100");
    string response1 = Console.ReadLine();
    user1Guess = Convert.ToInt32(response1);
    Console.Clear();
}
while (user1Guess < 0 || user1Guess > 100);

Console.WriteLine("User 2, enter a number between 0 and 100");
string response2 = Console.ReadLine();
user2Guess = Convert.ToInt32(response2);

while (user2Guess != user1Guess)
{
    if (user2Guess > user1Guess)
    {
        Console.Clear();
        Console.WriteLine("Too high! Guess again.");
        response2 = Console.ReadLine();
        user2Guess = Convert.ToInt32(response2);
    }

    else if (user2Guess < user1Guess)
    {
        Console.Clear();
        Console.WriteLine("Too low! Guess again.");
        response2 = Console.ReadLine();
        user2Guess = Convert.ToInt32(response2);
    }
}

Console.Clear();
Console.WriteLine($"Correct guess! {user1Guess} was right.");
Console.ReadLine();