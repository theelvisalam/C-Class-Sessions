Console.WriteLine("Enter the authors name as a STRING");
string name = Console.ReadLine();

Console.WriteLine("Enter the year published as an INTEGER");
int year = int.Parse(Console.ReadLine());

if (year >= 1900 && year <= 2025 && name != "")
{
    Console.WriteLine($"{name}, {year}");
}
else
{
    Console.Error.WriteLine("The year is not in the range");
    return;
}