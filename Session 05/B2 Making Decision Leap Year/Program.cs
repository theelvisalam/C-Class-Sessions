Console.WriteLine("Enter a year:");
int leapYearNum;
leapYearNum = int.Parse(Console.ReadLine());

if (leapYearNum % 4 == 0)
{
    Console.WriteLine($"{leapYearNum} is a leap year.");
}
else if (leapYearNum % 4 == 0 && leapYearNum % 400 == 0)
{
    Console.WriteLine($"{leapYearNum} is a leap year.");
}
else if (leapYearNum % 100 == 0)
{
    Console.WriteLine($"{leapYearNum} is not a leap year");
}
