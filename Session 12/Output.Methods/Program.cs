using static System.Console;
int sum = 12;
int[] arr = [1, 3, 5, 2];
// this is the time when the method is being called.
Calc(arr, out sum, out decimal avg, out decimal median);

WriteLine($"The sum is {sum} and the average is {avg:N2} with a median of {median}.");

(sum, avg, median) = Calc2(arr);
WriteLine($"The sum is {sum} and the average is {avg:N2} with a median of {median}.");

WriteLine(string.Join(", ", arr));

int a = 10;
int b = 20;
Swap(ref a, ref b);
Console.WriteLine($"The value of a and b are {a} and {b}, respectiviely");

// Create a method that computes the sum and the average of an array
static void Calc(int[] arr, out int sum, out decimal avg, out decimal median)
{
    // the beginning of the executing method.
    sum = 0;
    foreach (int x in arr)
    {
        sum += x;
    }

    // Create a copy of the arr
    int[] newarr = new int[arr.Length];
    Array.Copy(arr, newarr, arr.Length);
    // Find the median in the new copy.
    Array.Sort(newarr);
    if (newarr.Length % 2 == 0)
    {
        // 0, 1, 2, 3 (4/2 = 2)
        median = (newarr[newarr.Length / 2] + newarr[newarr.Length / 2 - 1]) / 2m;
    }
    else
    {
        median = newarr[newarr.Length / 2];
    }

    avg = (decimal)sum / arr.Length;
}

static (int, decimal, decimal) Calc2(int[] arr)
{
    int sum;
    decimal avg;
    decimal median;
    // the beginning of the executing method.
    sum = 0;
    foreach (int x in arr)
    {
        sum += x;
    }

    // Create a copy of the arr
    int[] newarr = new int[arr.Length];
    Array.Copy(arr, newarr, arr.Length);
    // Find the median in the new copy.
    Array.Sort(newarr);
    if (newarr.Length % 2 == 0)
    {
        // 0, 1, 2, 3 (4/2 = 2)
        median = (newarr[newarr.Length / 2] + newarr[newarr.Length / 2 - 1]) / 2m;
    }
    else
    {
        median = newarr[newarr.Length / 2];
    }

    avg = (decimal)sum / arr.Length;
    return (sum, avg, median);
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
    // (a, b) = (b, a);
}