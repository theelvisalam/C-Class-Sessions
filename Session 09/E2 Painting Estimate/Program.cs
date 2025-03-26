static void Main(string[] args)
{
    Console.WriteLine("Enter the length of the room in feet");
    int length = int.Parse(Console.ReadLine());
    JobPrice(length);

    Console.WriteLine("Enter the width of the room in feet");
    int width = int.Parse(Console.ReadLine());
}