string name;
int SAT;
float GPA;
string reason;

Console.WriteLine("Enter the student's name:");
name = Console.ReadLine();

Console.WriteLine("Enter the SAT score");
SAT = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the GPA:");
GPA = float.Parse(Console.ReadLine());



if (SAT < 400 || SAT > 1600)
{
    Console.WriteLine("SAT entered is invalid");
}
else if (GPA < 0 || GPA > 4.0)
{
    Console.WriteLine("GPA entered is invalid");
}
else if (GPA < 2.0 || GPA >= 3.5 && SAT < 900 || SAT < 1000)
{
    Console.WriteLine("");
}