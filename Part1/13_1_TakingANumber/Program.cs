/* Taking a Number
 *  - Make a method with the signature int AskForNumber(string text).
 *      - Display the text parameter in the console window
 *      - Get a response from the user
 *      - Convert to int
 *      - Return it
 *  - Make a method with the signature int AskForNumberInRange(string text, int min, int max)
 *      - Only return if the entered number is between the min and max values
 *          - Otherwise, ask again */

Console.Title = "Taking a Number";

int AskForNumber(string text)
{
    Console.WriteLine(text);
    int response = Convert.ToInt32(Console.ReadLine());
    return response;
}

int AskForNumberInRange(string text, int min, int max)
{
    Console.WriteLine(text);
    int guess = Convert.ToInt32(Console.ReadLine());
    while (guess < min || guess > max)
    {
        Console.WriteLine("Guess again!");
        guess = Convert.ToInt32(Console.ReadLine());
    }
    return guess;
}


// Testing
Console.WriteLine(AskForNumber("What is the answer to this question?"));

AskForNumberInRange("Guess a number!", 2, 35);