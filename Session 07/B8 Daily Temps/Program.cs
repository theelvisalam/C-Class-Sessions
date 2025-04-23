using System.Globalization;

int sentinel = 999;
int input;
int sum = 0;
int count = 0;

Console.WriteLine("Enter temperatures one by one. Enter '999' to stop.");

while (true)
{
    Console.WriteLine("Enter a temperature ==> ");
    input = int.Parse(Console.ReadLine());
    if (input == sentinel)
    {
        Console.WriteLine("Sentinel value (999) entered. Stopping Input.");
        break;
    }
    else if (input > -20 && input < 130)
    {
        sum += input;
        count++;
        Console.WriteLine($"  -> {input} degrees added, (Number of temperatures inputted = {count})");
    }
    else
    {
        Console.WriteLine("INVALID INPUT");
    }
}

if (count > 0)
{
    Console.WriteLine($"Number of temperatures inputted: {count}");
    double avg = (double)sum / count;
    Console.WriteLine($"Average temp: {avg}");

}
else
{
    Console.WriteLine("ERROR");
}
