int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == array.Length - 1)
    {
        Console.WriteLine($"Last element of the array: {array[i]}");
        break;
    }
    else
    {
        Console.WriteLine("No last element in the array");
        break;
    }
}