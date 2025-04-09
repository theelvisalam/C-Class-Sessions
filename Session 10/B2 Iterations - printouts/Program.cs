int count = 1;
double increment = 0.1;
double start = 1.0;
double end = 5.0;

// for (double next = start + 0.1; next <= end; next += increment)

for (double i = start; i <= end; i += increment)
{
    if (i % 1 == 0)
    {
        count++;
        i += increment;
        Console.Write($"{i:F1}, ");
    }
    else
    {
        count++;
        Console.Write($"{i:F1}, ");
    }
}
return count;
