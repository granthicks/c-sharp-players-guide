/* The Four Sisters and the Duckbear
 * Takes input of the number of chocolate eggs gathered
 * Computes how many eggs each of the four sisters should get
 * Also computes the remainder to be fed to the duckbear */

Console.WriteLine("How many eggs were gathered?");
string str_eggs = Console.ReadLine();
int eggs = Convert.ToInt32(str_eggs);

// Divide the eggs between the four sisters
int share_eggs = eggs / 4;

// Determine the remaining eggs for the duckbear
int remainder_eggs = eggs % 4;

Console.WriteLine("Each sister gets " + share_eggs + " eggs.");
Console.WriteLine(remainder_eggs + " eggs remain to be fed to the duckbear.");