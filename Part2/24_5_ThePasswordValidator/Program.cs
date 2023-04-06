/* The Password Validator
 *
 * Passwords must be
 * Between 6 and 13 letters long
 * Must contain at least:
 *  one uppercase letter
 *  one lowercase letter
 *  one number
 * Passwords cannot contain:
 *  uppercase T
 *  ampersand (&)
 */

PasswordValidator validator = new PasswordValidator();

while (true)
{
  Console.Write("Enter a password to check: ");
  string password = Console.ReadLine();
  bool isValid = validator.IsValid(password);
  if (isValid)
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("That password is VALID.");
  }
  else
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("That password is INVALID!");
  }
  Console.ResetColor();
}
public class PasswordValidator
{
  public bool IsValid(string password)
  {
    if (password.Length < 6)
    {
      Console.WriteLine("Password is too short, must be longer than 6 characters.");
      return false;
    }
    if (password.Length > 13)
    {
      Console.WriteLine("Password is too long, must be less than 13 characters.");
      return false;
    }

    int upperCount = 0;
    int lowerCount = 0;
    int numCount = 0;
    int capitalTCount = 0;
    int ampersandCount = 0;

    foreach (char letter in password)
    {
      if (char.IsUpper(letter))
      {
        upperCount++;
      }
      if (char.IsLower(letter))
      {
        lowerCount++;
      }
      if (char.IsDigit(letter))
      {
        numCount++;
      }
      if (letter == 'T')
      {
        capitalTCount++;
      }
      if (letter == '&')
      {
        ampersandCount++;
      }
    }

    if (upperCount == 0)
    {
      Console.WriteLine("Password must contain an uppercase letter.");
      return false;
    }
    if (lowerCount == 0)
    {
      Console.WriteLine("Password must contain a lowercase letter.");
      return false;
    }
    if (numCount == 0)
    {
      Console.WriteLine("Password must contain a number.");
      return false;
    }
    if (capitalTCount != 0)
    {
      Console.WriteLine("Password must not contain an uppercase T.");
      return false;
    }
    if (ampersandCount != 0)
    {
      Console.WriteLine("Password must not contain an ampersand.");
      return false;
    }

    return true;
  }
}
