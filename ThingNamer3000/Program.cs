// See https://aka.ms/new-console-template for more information
/* The Thing Namer 3000 */
// Prompt user for the king of thing to name
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();
// Prompt user for general description of the thing
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();
// Add "of Doom" to the name of the thing
string c = "of Doom";
// Tack 3000 on the end to sound fancy.
string d = "3000";
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
