/* The Color
 * Define a color class with properties for its red, green, and blue channels.
 * Add appropriate constructors that you feel make sense for creating new Color objects.
 * Create statid properties to define the eight commonly used colors for easy access.
 * In your main method, make two Color-typed variables. Use a constructor to create a color
 * instance and use a static property for the other. Display each of their red, green, and 
 * blue channel values. */

Console.Title = "The Color";

Color c1 = Color.Green;
Color c2 = new Color(255, 215, 0);

Console.WriteLine($"Color 1: ({c1.R}, {c1.G}, {c1.B})");
Console.WriteLine($"Color 1: ({c2.R}, {c2.G}, {c2.B})");

public class Color
{
  public byte R { get; set; }
  public byte G { get; set; }
  public byte B { get; set; }

  public Color(byte r, byte g, byte b)
  {
    R = r;
    G = g;
    B = b;
  }
  
  public static Color White { get; } = new Color(255, 255, 255);

  public static Color Black { get; } = new Color(0, 0, 0);

  public static Color Red { get; } = new Color(255, 0, 0);
  
  public static Color Orange { get; } = new Color(255, 165, 0);

  public static Color Yellow { get; } = new Color(255, 255, 0);

  public static Color Green { get; } = new Color(0, 128, 0);

  public static Color Blue { get; } = new Color(0, 0, 255);

  public static Color Purple { get; } = new Color(128, 0, 128);
}
