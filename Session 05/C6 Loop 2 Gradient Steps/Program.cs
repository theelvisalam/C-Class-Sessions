Console.WriteLine("Enter a starting INTEGER");
int start = int.Parse(Console.ReadLine());

int decrement = 0;

// POSITIVES
if (start > 0)
{

    Console.WriteLine($"{start}");

    while (start > 0)
    {
        decrement++;
        start -= decrement;
        Console.WriteLine($"{start}");

    }


}
// NEGATIVES
else if (start < 0)
{

    Console.WriteLine($"{start}");

    while (start < 0)
    {
        decrement++;
        start += decrement;
        Console.WriteLine($"{start}");

    }

}
// IF START IS 0
else
{
    Console.WriteLine($"{start}");
}