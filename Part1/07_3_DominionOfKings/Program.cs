/* The Dominion of Kings
 * Calculates a total score to rank a kingdom.
 * Takes input of provinces, duchies, and estates a king has.
 * Estate = 1 point
 * Duchy = 3 points
 * Province = 6 points */

Console.WriteLine("How many estates does the king have?");
string str_estates = Console.ReadLine();
int estates = Convert.ToInt32(str_estates);

Console.WriteLine("How many duchies does the king have?");
string str_duchies = Console.ReadLine();
int duchies = Convert.ToInt32(str_duchies);
int duchies_score = duchies *= 3;

Console.WriteLine("How many Provinces does the king have?");
string str_provinces = Console.ReadLine();
int provinces = Convert.ToInt32(str_provinces);
int provinces_score = provinces *= 6;

int total_score = estates + duchies_score + provinces_score;
Console.WriteLine("The total score for the kingdom is " + total_score);