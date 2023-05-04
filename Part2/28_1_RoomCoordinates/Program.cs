// Room Coordinates
// Create a Coordinate struct that can represent a room coordinate with a row and column
// Ensure Coordinate is immutable
// Make a method to determine if one coordinate is adjacent to another (differing only by a single row or column)
// Write a main method that creates a few coordinates and determines if they are adjacent to each other

Console.title = "Room Coordinates";

Coordinate a = new Coordinate(1, 1);
Coordinate b = new Coordinate(3, 2);
Coordinate c = new Coordinate(2, 2);
Coordinate d = new Coordinate(5, 5);

public scruct Coordinate
{
  public int X { get; }
  public int Y { get; }

  public Coordinate(int x, int y)
  {
    X = x;
    Y = y;
  }
}
