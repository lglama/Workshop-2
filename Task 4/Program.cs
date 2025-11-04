int[] favoriteNumbers = { 7, 3, 9, 1, 5 };

Array.Sort(favoriteNumbers);

Array.Reverse(favoriteNumbers);

Console.WriteLine("Array elements after sorting and reversing:");
for (int i = 0; i < favoriteNumbers.Length; i++)
{
    Console.WriteLine(favoriteNumbers[i]);
}
int searchNumber = 5;
int position = Array.IndexOf(favoriteNumbers, searchNumber);

if (position >= 0)
    Console.WriteLine($"\nThe number {searchNumber} is found at index {position}.");
else
    Console.WriteLine($"\nThe number {searchNumber} is not found in the array.");