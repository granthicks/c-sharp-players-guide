/* Countdown
 * Write code that counts down from 10 to 1 using a recursive method */

Console.Title = "Countdown";

int Countdown(int number)
{
    if (number == 1) return 1;
    else
    {
        Console.WriteLine(number);
        return Countdown(number - 1);
    }
}

// Testing with 10
Console.WriteLine(Countdown(10));