// Given numbers between 0 and 5.

const int Length = 6;

Console.WriteLine("Print out 0 through 5");
for (int i = 0; i < Length; i++)
{
    Console.Write(i);
    Console.Write(" ");
}
Console.WriteLine();


Console.WriteLine("Combinations of two numbers - Print out 01, 02, 03, 04, 05, 10, 11");

for (int i = 0; i < Length; i++)
{
    for (int j = i + 1; j < Length; j++)
    {
        Console.Write(i);
        Console.Write(j);
        Console.Write(" ");
    }

    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Permutations of two numbers - Print out 01, 02, 03, 04, 05, 12, 13, 14, 15, 23...");

for (int i = 0; i < Length; i++)
{
    for (int j = 0; j < Length; j++)
    {
        if (i != j)
        {
            Console.Write(i);
            Console.Write(j);
            Console.Write(' ');
        }
    }

    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Combinations of three numbers - ...");

for (int i = 0; i < Length; i++)
{
    for (int j = i + 1; j < Length; j++)
    {
        for (int k = j + 1; k < Length; k++)
        {
            Console.Write(i);
            Console.Write(j);
            Console.Write(k);
            Console.Write(" ");
        }
        Console.WriteLine();
    }


    Console.WriteLine();
}
Console.WriteLine();


Console.WriteLine("Permutations of three numbers - ...");

for (int i = 0; i < Length; i++)
{
    for (int j = 0; j < Length; j++)
    {
        if (i != j)
        {
            for (int k = 0; k < Length; k++)
            {
                if (k != i && k != j)
                {
                    Console.Write(i);
                    Console.Write(j);
                    Console.Write(k);
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine();
}

Console.WriteLine();