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

public class Door
{
  public DoorState State { get; set; } = DoorState.Closed;

  public void Open()
  {
    if (State == DoorState.Closed)
    {
      State = DoorState.Open;
    }
  }

  public void Close()
  {
    if (State = DoorState.Open)
    {
      State = DoorState.Closed;
    }
  }
}

public void Lock()
{
  
}

public enum DoorState { Locked, Open, Closed }
