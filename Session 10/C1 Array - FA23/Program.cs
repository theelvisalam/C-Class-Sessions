int[] a = new int[10];
int[] b = new int[10];
int value = -5;

for (int i = 0; i <= a.Length; i++)
{
    if (value == 0)
    {
        value++;
    }
    a[i] = value;
    value++;
    Console.WriteLine(a[i]);

}

for (int j = 0; j <= b.Length; j++)
{
    Console.WriteLine("Input a positive integer");
    int input = int.Parse(Console.ReadLine());

    if (input == 0 || input < 0)
    {
        Console.WriteLine("Input a Positive integer");
    }
    b[j] = input;
    Console.WriteLine(b[j]);

}