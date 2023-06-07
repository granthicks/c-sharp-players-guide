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

// Main Program
FountainOfObjects game = new FountainOfObjects();
game.Run();

// Main game class
public class FountainOfObjects
{
    public Player Player { get; }
    public Map Map { get; }

    public FountainOfObjects()
    {
        Player = new Player();
        Map = new Map(4, 4);
    }

    // Runs the game
    public void Run()
    {
        PlayerInput playerInput = new PlayerInput();
        while (!HasWon())
        {
            SenseStuff();
            IAction action = playerInput.ChooseAction();
            action.Execute(this);
        }
    }

    // Indicates if the player has won
    private bool HasWon()
    {
       Room playersRoom = Map.GetRoom(Player.Location);
       if (playersRoom is not EntranceRoom) return false;

       for (int row = 0; row < Map.Rows; row++)
       {
           for (int column = 0; column < Map.Columns; column++)
           {
               Room room = Map.GetRoom(row, column);
               if (room is FountainRoom fountainRoom)
               {
                   if (!fountainRoom.IsEnabled) return false;
               }
           }
       }
       return true;
    }

    private void SenseStuff()
    {
        Console.WriteLine($"You are in the room at {Player.Location.Row}, {Player.Location.Column}.");

        SenseEntrance();

        SenseFountain();
    }

    private void SenseEntrance()
    {
        if (Map.GetRoom(Player.Location) is EntranceRoom)
        {
            Console.WriteLine("You see light in this room coming from outside the cavern. This is the entrance.");
        }
    }

    private void SenseFountain()
    {
        if (Map.GetRoom(Player.Location) is FountainRoom fountainRoom)
        {
            if (fountainRoom.IsEnabled)
            {
                Console.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
            }
            else
            {
                Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
            }
        }
    }
}

public interface IAction
{
    public void Execute(FountainOfObjects game);
}

public class MoveAction : IAction
{
    private readonly Direction _direction;
    public MoveAction(Direction direction)
    {
        _direction = direction;
    }
    public void Execute(FountainOfObjects game)
    {
        Location current = game.Player.Location;
        Location next = GetRelativeLocation(current, _direction);
        if (game.Map.IsValidLocation(next))
        {
            game.Player.Location = next;
        }
        else
        {
            Console.WriteLine("You can't move there.");
        }
    }

    private Location GetRelativeLocation(Location start, Direction directionToMove)
    {
        return directionToMove switch
        {
            Direction.North => new Location(start.Row - 1, start.Column),
            Direction.East => new Location(start.Row, start.Column + 1),
            Direction.South => new Location(start.Row + 1, start.Column),
            Direction.West => new Location(start.Row, start.Column - 1),
            _ => throw new ArgumentException("Invalid direction", nameof(directionToMove))
        };
    }
}

// Represents the player input
public class PlayerInput
{
    public IAction ChooseAction()
    {
        do
        {
        Console.Write("What do you want to do? ");
        string? input = Console.ReadLine();
        IAction? playerAction = input switch
        {
            "move north" => new MoveAction(Direction.North),
            "move east" => new MoveAction(Direction.East),
            "move south" => new MoveAction(Direction.South),
            "move west" => new MoveAction(Direction.West),
            _ => null
        };

        if (playerAction != null)
        {
            Console.Clear();
            return playerAction;
        }
        else
        {
            Console.WriteLine("Invalid action.");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }
        }
        while (true);
    }
}

// Represents the map and what each room is made out of
public class Map
{
    private readonly Room[,] _rooms;

    public Map(int rows, int columns)
    {
        _rooms = new Room[rows, columns];
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
                {
                    _rooms[row, column] = new EmptyRoom();
                }
            
            _rooms[0, 0] = new EntranceRoom();
            _rooms[0, 2] = new FountainRoom();
        }
    }

    public int Rows => 4;
    public int Columns => 4;

    // Checks if the location is valid
    public bool IsValidLocation(Location location)
    {
        return location.Row >= 0 && location.Row <= Rows && location.Column >= 0 && location.Column <= Columns;
    }
    // Get room at row and column
    public Room GetRoom(int row, int column) => _rooms[row, column];
    // Get room at location
    public Room GetRoom(Location location) => GetRoom(location.Row, location.Column);
    
}

// Represents a location on the map
public record Location(int Row, int Column);

// Represents a room in the map
public abstract class Room { }

// Represents an empty room
public class EmptyRoom : Room { }

// Represents the entrance room
public class EntranceRoom : Room { }

// Represents the fountain room
public class FountainRoom : Room
{
    // Indicates if the fountain is enabled
    public bool IsEnabled { get; set; } = false;
}

// Represent the player
public class Player
{
    // current location
    public Location Location { get; set; } = new Location(0, 0);

    // Indicates if the player is alive
    public bool IsAlive { get; set; } = true;

    // Explains why the player died
    public string DeathReason { get; set; } = "";

    // Creates a new player at the given location
    // public Player(Location location)
    // {
    //     Location = location;
    // }

    // Kills the player and sets the death reason
    public void Die(string reason)
    {
        IsAlive = false;
        DeathReason = reason;
    }
}

// Parse direction from string
public static class DirectionParser
{
    public static Direction Parse(string direction)
    {
        return direction switch
        {
            "north" => Direction.North,
            "east" => Direction.East,
            "south" => Direction.South,
            "west" => Direction.West,
            _ => throw new ArgumentException("Invalid direction", nameof(direction))
        };
    }
}

// Different directions
public enum Direction
{
    North,
    East,
    South,
    West
}

// Different room types
public enum RoomType
{
    Empty,
    Entrance,
    Fountain
}
