// Declare two integer variables a and b with initial values of 10 and 20, respectively
int a = 10;
int b = 20;

// Calculate c by dividing the square of a by b
int c = (a * a) / b;

// Print the value of c
Console.WriteLine(c);

// Declare the decimal variable d
decimal d;

// Calculate d by dividing the difference between a and b by their sum
d = (decimal)(a - b) / (a + b);

// Print the value of d with 2 decimal places; use string formatting
Console.WriteLine($"The division is {d:F2}");