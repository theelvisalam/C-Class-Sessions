Console.WriteLine("Enter the number");

// if the line is not empty ("") AND the num is an even number, print out even; otherwise odd.

string line = Console.ReadLine();

// short-circuited evaluation
if (line != "" && Convert.ToInt32(line) % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}