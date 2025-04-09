// Boolean isEven;

// Console.WriteLine("Enter an integer");
// int n = int.Parse(Console.ReadLine());

// if (n % 2 == 0)
// {
//     isEven = true;
//     Console.WriteLine(isEven);
// }
// else
// {
//     isEven = false;
//     Console.WriteLine(isEven);
// }

static void Main()
{
    DisplayInteger(0);
}

static void DisplayInteger(int n)
{
    Console.WriteLine("Enter an integer");
    n = int.Parse(Console.ReadLine());

    Console.WriteLine($"{n} is {(IsEven(n) ? "Even" : "Odd")}");
}

static bool IsEven(int n) => n % 2 == 0;