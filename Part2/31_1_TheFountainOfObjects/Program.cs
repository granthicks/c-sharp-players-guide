/* The Fountain of Objects is a 2D grid-based world full of rooms.
* Most rooms are ampty, but a few are unique rooms.
* One room is the cavern entrance.
* Another is the fountain room, containing the fountain of objects.
* The player moves through the cavern system one room at a time to find the Fountain of Objects.
* They activate it and then return to the entrance room.
* If they do this without falling into a pit, they win the game.
* 
* Objectives
* The world consists of a grid of rooms, where each room can be referenced by its row and column.
* North is up, east is right, south is down, and west is left.
*
* The player is told what they can sense in the dark (see, hear, smell).
* Then the player gets a chance to perform some action by typing it
* Their chosen action is resolved (The player moves, state of things in the game changes, checking for win/loss, etc).
*
* Most rooms are empty rooms, and there is nothing to sense.
*
* The player is in one of the rooms and can move between them by typing commands like the 
* following: “move north”, “move south”, “move east”, and “move west”. The player should not be able 
* to move past the end of the map.
*
* The room at (Row=0, Column=0) is the cavern entrance (and exit). The player should start here.The 
* player can sense light coming from outside the cavern when in this room. (“You see light in this room
* coming from outside the cavern. This is the entrance.”)
*
* The room at (Row=0, Column=2) is the fountain room, containing the Fountain of Objects itself. The 
* Fountain can be either enabled or disabled. The player can hear the fountain but hears different 
* things depending on if it is on or not. (“You hear water dripping in this room. The Fountain of Objects 
* is here!” or “You hear the rushing waters from the Fountain of Objects. It has been reactivated!”) The 
* fountain is off initially. In the fountain room, the player can type “enable fountain” to enable it. If the 
* player is not in the fountain room and runs this, there should be no effect, and the player should be 
* told so.
*
* The player wins by moving to the fountain room, enabling the Fountain of Objects, and moving back 
* to the cavern entrance. If the player is in the entrance and the fountain is on, the player wins.
*
* Use different colors to display the different types of text in the console window. For example, 
* narrative items (intro, ending, etc.) may be magenta, descriptive text in white, input from the user 
* in cyan, text describing entrance light in yellow, messages about the fountain in blue. */

Console.Title = "The Fountain of Objects";

// Represents the map and what each room is made out of
public class Map
{
    private readonly Room[,] _rooms;
    public int Rows { get; }
    public int Columns { get; }

    public Map(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        _rooms = new Room[rows, columns];
    }

    // Returns what type a room at a specific location is
    
}

public record Location(int Row, int Column);

// Represent the player
public class Player
{
    // current location
    public Location Location { get; set; }

    // Indicates if the player is alive
    public bool IsAlive { get; private set; } = true;

    // Explains why the player died
    public string DeathReason { get; private set; } = "";

    // Creates a new player at the given location
    public Player(Location location)
    {
        Location = location;
    }

    // Kills the player and sets the death reason
    public void Die(string reason)
    {
        IsAlive = false;
        DeathReason = reason;
    }
}