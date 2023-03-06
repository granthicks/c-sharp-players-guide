/* Simula's Test
 * Define an enumeration for the state of the chest
 *      open
 *      closed
 *      locked
 * Make a variable whose type is this new enumeration
 * Write code to allow you to manipulate the chest with the lock, unlock, open, and close commands
 *      ensure that you don't transition between states that don't support it
 * Loop forever, asking for the next command. */

using System.Reflection.Metadata.Ecma335;

Console.Title = "Simula's Test";

BoxStatus current = BoxStatus.locked;

while (true)
{
    current = NextMove(current);
}

BoxStatus NextMove(BoxStatus currentStatus)
{
    Console.Write($"The chest is {currentStatus}. What do you want to do? ");
    string NextStep = Console.ReadLine();
    if (currentStatus == BoxStatus.open && NextStep == "close")
    {
        return BoxStatus.closed;
    }
    else if (currentStatus == BoxStatus.closed && NextStep == "lock")
    {
        return BoxStatus.locked;
    }
    else if (currentStatus == BoxStatus.closed && NextStep == "open")
    {
        return BoxStatus.open;
    }
    else if (currentStatus == BoxStatus.locked && NextStep == "unlock")
    {
        return BoxStatus.closed;
    }
    else
    {
       return currentStatus;
    }
}

enum BoxStatus
{
    open,
    closed,
    locked
};