/* The Laws of Freach
 * Modify code from earlier in the chapter to use for each loops instead of for loops */

Console.Title = "The Laws of Freach";
/* Original

// Finding minimum values in array

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
        currentSmallest = array[index];
}

Console.WriteLine(currentSmallest);


// Average numbers in array
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
for (int index = 0; index < array.Length; index++)
    total += array[index];

float average = (float)total / array.Length;
Console.WriteLine(average);
*/

// Using foreach

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
foreach (int num in array)
{
    if (num < currentSmallest)
    { currentSmallest = num; }
}
Console.WriteLine($"The smallest number in the array is {currentSmallest}");

int total = 0;
foreach(int num in array)
{
    total += num;
}
Console.WriteLine($"The total of the numbers in the array is {total}");