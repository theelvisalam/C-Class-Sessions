namespace MethodOverloads;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Min(3, 2));
        Console.WriteLine(Min(3, 2, 1));
        Console.WriteLine(Min(3.5m, 2.1m, 1));

        Console.WriteLine($"The maximum is {Max(new int[] { 4, 3, 1, 5, 2 })}");
        Console.WriteLine($"The maximum (variable arguments) is {Max(4, 3, 1, 5, 6, 2)}");
        //        Convert.ToInt32()
    }

    static int Min(int a, int b)
    {
        return a < b ? a : b;
    }

    static int Min(int a, int b, int c)
    {
        // Math.Min()
        int min = Min(a, b);
        min = Min(min, c);
        return min;
    }

    /*
    An ambiguous method
        static double Min(int aa, int bb, int cc)
        {
            // Math.Min()
            int min = Min(a, b);
            min = Min(min, c);
            return min;
        }
        */

    static decimal Min(decimal a, decimal b)
    {
        return a < b ? a : b;
    }

    static decimal Min(decimal a, decimal b, decimal c)
    {
        // Math.Min()
        decimal min = Min(a, b);
        min = Min(min, c);
        return min;
    }

    static int Max(params int[] array)
    {
        // int max = array[0];
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
