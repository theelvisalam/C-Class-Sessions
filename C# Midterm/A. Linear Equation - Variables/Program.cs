double x1 = 1;
double x2 = 8;
double y1 = 2;
double y2 = 4;

double m = y2;
m -= y1;
m /= (x2 - x1);

// double m = (y2 - y1) / (x2 - x1);
// Console.WriteLine($"{m:F2}");

double b = y1 - m * x1;
// Console.WriteLine($"{b:F2}");

Console.WriteLine($"y = {m:F2}x + {b:F2}");


