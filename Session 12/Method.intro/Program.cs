namespace Method.intro;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        SetOnes(arr);
        WriteLine(string.Join(", ", arr));
        WriteLine($"The sum is {Sum(1, 2)}");
        int sum;
        Calc([1, 3, 5, 2], out sum, out decimal avg);
        WriteLine($"The sum is {sum} and the average is {avg:N2}.");
    }

    // sum up between 1 and 5 arguments

    static int Sum(int n1, int n2 = 0, int n3 = 0, int n4 = 0, int n5 = 0)
    {
        return n1 + n2 + n3 + n4 + n5;
    }

    // Create a method that computes the sum and the average of an array
    static void Calc(int[] arr, out int sum, out decimal avg)
    {
        sum = 0;
        foreach (int x in arr)
        {
            sum += x;
        }
        avg = (decimal)sum / arr.Length;
    }

    // Replace all elements in the array to one.
    static void SetOnes(int[] arr)
    {
        if (arr is not null)
        {
            //            arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1;
            }
        }
    }
}
