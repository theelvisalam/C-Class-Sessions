// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
const string course = "ISAM 5430";
// course = "ISAM 3333";
string name = "C#"; // declaration and initialization
name = "C Sharp";
bool t = true; // assigning
bool f = false; // assigning
char c = '1'; // assigning

decimal someMoney = 39.45M;
Console.Write("They money is $");
Console.WriteLine(someMoney);

Console.WriteLine("The money is ${0:c}", someMoney);

Console.WriteLine($"The money is {someMoney:c}");

Console.WriteLine(45 / 6); //7
Console.WriteLine(45.0 / 6); //7.5

int x = 100;
x &= 10;
// x >= 10;
Console.WriteLine(x);

// short s = (sbyte) 0;
float xx = (int)1324; //possible

Console.WriteLine("What is your name?");
string name2 = Console.ReadLine();

Console.WriteLine("What is your age?");
int age = int.Parse(Console.ReadLine());
