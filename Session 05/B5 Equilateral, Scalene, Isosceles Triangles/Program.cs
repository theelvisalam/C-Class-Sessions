Console.WriteLine("Input the first side");
int firstSide = int.Parse(Console.ReadLine());

Console.WriteLine("Input second side");
int secondSide = int.Parse(Console.ReadLine());

Console.WriteLine("Input third side");
int thirdSide = int.Parse(Console.ReadLine());

if (firstSide == secondSide && secondSide == thirdSide)
{
    Console.WriteLine("Triangle is equilateral triangle");
}
else if (firstSide == secondSide || secondSide == thirdSide || firstSide == thirdSide)
{
    Console.WriteLine("Triangle is isosceles triangle");
}
else if (firstSide != secondSide || secondSide != thirdSide || firstSide != thirdSide)
{
    Console.WriteLine("Triangle is Scalene Triangle");
}