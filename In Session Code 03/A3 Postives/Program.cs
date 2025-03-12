Console.WriteLine("Please enter your first integer");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your second integer");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < 0 && num2 < 0)
{
    Console.WriteLine("These are not positive integers");
}
else
{
    Console.WriteLine("These are positive integers");
}