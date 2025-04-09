static void Main(string[] args)
{
    Console.WriteLine("Enter the length of the room in feet:");
    int length = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the width of the room in feet:");
    int width = int.Parse(Console.ReadLine());

    decimal price = JobPrice(length, width);
    Console.WriteLine($"The total painting cost is: ${price}");
}

static decimal JobPrice(int length, int width)
{
    int height = 9;
    int surfaceArea = (length * width) + (2 * length * height) + (2 * width * height);
    decimal totalCost = surfaceArea * 6;
    return totalCost;
}