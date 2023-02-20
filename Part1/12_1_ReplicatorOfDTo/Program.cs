/* The Replicator of D'To
 * - Make a program that creates an array of lenth 5
 * - Ask the user for 5 numbers and put them in the array.
 * - Make a second array of length 5
 * - Use a loop to copy the values out of the original array and into the new one
 * - Display the contents of both arrays one at a time to illustrate that the replicator works */

Console.Title = "The Replicator of D'To";

// Create array
int[] original = new int[5];

// Prompt user for 5 values to be stored in array and store them in the array
Console.WriteLine("Please enter the numbers for the array, one at at time.");

for (int index = 0; index < original.Length;index++)
{
    original[index] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("Replicating array...");

// Create new array with length 5
int[] duplicate = new int[5];

// Use a loop to copy the values from the original to the new array
for (int index = 0; index < duplicate.Length;index++)
{
    duplicate[index] = original[index];
}

// Display the contents of both arrays
Console.WriteLine("Here is the original array:");
Array.ForEach(original, Console.WriteLine);
Console.WriteLine();
Console.WriteLine("Here is the duplicate array:");
Array.ForEach(duplicate, Console.WriteLine);