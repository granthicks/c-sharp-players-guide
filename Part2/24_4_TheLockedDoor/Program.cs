/* The Locked Door
 * Define a door class that can keep track of whether it is locked, open, or closed
 * Make it so you can perform the gour transitions defined above with methods
 * Build a constructor that requires starting numeric passcode
 * Build a method that will allow you to change the passcode for an existing
 * door by supplying the current passcode and new passcode
 * Only change the passcode if the current passcode is correct.
 * Make your main method ask the user for a starting passcode
 * then create a door instance.
 * Allow the user to attempt the four transitions described above
 * open, close, lock, unlock, and change the code by typing text commands */

Console.Title = "The Locked Door";

Console.Write("Enter initial passcode: ");
int initialCode = Convert.ToInt32(Console.ReadLine());
Door door = new Door(initialCode);

while (true)
{
  Console.WriteLine($"The door is currently {door.State}.");
  Console.WriteLine("What would you like to do?");
  string input = Console.ReadLine();
  switch (input)
  {
    case "open":
      door.Open();
      break;
    case "close":
      door.Close();
      break;
    case "lock":
      door.Lock();
      break;
    case "unlock":
      Console.Write("Enter passcode: ");
      int code = Convert.ToInt32(Console.ReadLine());
      door.Unlock(code);
      break;
    case "change code":
      Console.Write("Enter current passcode: ");
      int current = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter new passcode: ");
      int newCode = Convert.ToInt32(Console.ReadLine());
      bool success = door.ChangePasscode(current, newCode);
      if (success)
      {
        Console.WriteLine("The passcode has been changed.");
      }
      else
      {
        Console.WriteLine("Current passcode incorrect. The passcode has not been changed.");
      }
      break;
    default:
      Console.WriteLine("Sorry, I don't know what that means. Try again.");
      break;
  }
}

public class Door
{
  private int _currentCode;

  public DoorState State { get; set; } = DoorState.Closed;
  
  public Door(int initialCode)
  {
    _currentCode = initialCode;
  }

  public void Open()
  {
    if (State == DoorState.Closed)
    {
      State = DoorState.Open;
    }
  }

  public void Close()
  {
    if (State == DoorState.Open)
    {
      State = DoorState.Closed;
    }
  }
  
  public void Lock()
  {
    if (State == DoorState.Closed)
    {
      State = DoorState.Locked;
    }
  }

  public void Unlock(int code)
  {
    if (State == DoorState.Locked && code == _currentCode)
    {
      State = DoorState.Closed;
    }
  }

  public bool ChangePasscode(int currentCode, int newCode)
  {
    if (currentCode == _currentCode)
    {
      _currentCode = newCode;
      return true;
    }
    return false;
  }
}

public enum DoorState { Locked, Open, Closed }
