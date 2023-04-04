/* The Point
 * Define a new Point class with proerties for X and Y
 * Add a constructor to create a point from a specific x and y coordinate
 * Add a paramerless constructor to create a point at the origin (0,0)
 * In your main method, create a point at (2,3) and another at (-4,0)
 * Display these points on the console window in the format (x, y) to 
 * show that the class works.
 */

Console.Title = "The Point";

Point p1 = new Point(2, 3);
Point p2 = new Point(-4, 0);

Console.WriteLine($"Points: ({p1.X}, {p1.Y}) and ({p2.X}, {p2.Y})");

public class Point
{
  public int X { get; set; }
  public int Y { get; set; }

  public Point() : this(0,0)
  {
  }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }
}
