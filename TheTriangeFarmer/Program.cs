/* The Triangle Farmer
 * Takes input of triange base size and height
 * Computes the area of the triange and writes the result. */

Console.WriteLine("Please enter the base of the triange");
string str_b = Console.ReadLine();
double b = Convert.ToDouble(str_b);
Console.WriteLine("Please enter the height of the triange");
string str_h = Console.ReadLine();
double h = Convert.ToDouble(str_h);
double a = (b * h) / 2;
Console.WriteLine("The area of your triange is " + a);
