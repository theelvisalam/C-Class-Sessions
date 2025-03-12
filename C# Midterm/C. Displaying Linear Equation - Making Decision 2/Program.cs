Console.WriteLine("Enter an integer value for variable m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter an integer value for variable b");
int b = int.Parse(Console.ReadLine());

int bPositive = b - b - b;

Console.Write("y = ");

if (m == 1) {
    Console.Write("x ");
}
else if (m == -1) {
    Console.Write("-x ");
}
else if (m == 0) {
    Console.Write("");
}

if (b >= 1) {
    Console.Write($"+ {b}");
}
else if (b <= -1) {
    Console.Write($"- {bPositive}");
}
else if (b == 0) {
    Console.Write("0");
}