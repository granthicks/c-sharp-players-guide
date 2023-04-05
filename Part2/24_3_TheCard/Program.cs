/* The Card
 * Define enumerations for card colors (red, green, blue, yellow)
 * and a rank (1-10, $, %, ^, &)
 * Define a Card class to represent a card with a color and rank.
 * Add properties or methods that tell you if a card is a number or symbol card
 * Create a main method that will create a card instance for the whole deck
 * and display each. */

Console.Title = "The Card";

for (int colorNum = 0; colorNum < 4; colorNum++)
{
  for (int rankNum = 0; rankNum < 14; rankNum++)
  {
    Card card = new Card((Color)colorNum, (Rank)rankNum);
    switch(card.Color)
    {
      case Color.Red:
        Console.ForegroundColor = ConsoleColor.Red;
        break;
      case Color.Green:
        Console.ForegroundColor = ConsoleColor.Green;
        break;
      case Color.Blue:
        Console.ForegroundColor = ConsoleColor.Blue;
        break;
      case Color.Yellow:
        Console.ForegroundColor = ConsoleColor.Yellow;
        break;
    }
    Console.WriteLine($"The {card.Color} {card.Rank}");
    Console.ResetColor();
  }
}

public class Card
{
  public Color Color { get; }
  public Rank Rank { get; }

  public Card(Color color, Rank rank)
  {
    Color = color;
    Rank = rank;
  }

  public bool IsNumber()
  {
    return Rank <= Rank.Ten;
  }

  public bool IsSymbol()
  {
    return !IsNumber();
  }
}
public enum Color { Red, Green, Blue, Yellow}

public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Carrot, Ampersnad }
