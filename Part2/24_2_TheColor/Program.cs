/* The Color
 * Define a color class with properties for its red, green, and blue channels.
 * Add appropriate constructors that you feel make sense for creating new Color objects.
 * Create statid properties to define the eight commonly used colors for easy access.
 * In your main method, make two Color-typed variables. Use a constructor to create a color
 * instance and use a static property for the other. Display each of their red, green, and 
 * blue channel values. */

Console.Title = "The Color";


public class Color
{
  public int RedChannel { get; set; }
  public int GreenChannel { get; set; }
  public int BlueChannel { get; set; }

  // TODO make constructors that limit ints between 0 and 255

  public static Color CreateWhite()
  {
    return new Color(255, 255, 255);
  }

  public static Color CreateBlack()
  {
    return new Color(0, 0, 0);
  }

  public static Color CreateRed()
  {
    return new Color(255, 0, 0);
  }
  
  public static Color CreateOrange()
  {
    return new Color(255, 165, 0);
  }

  public static Color CreateYellow()
  {
    return new Color(255,255,0);
  }

  public static Color CreateGreen()
  {
    return new Color(0,128,0);
  }

  public static Color CreateBlue()
  {
    return new Color(0,0,255);
  }

  public static Color CreatePurple()
  {
    return new Color(128,0,128);
  }
}
