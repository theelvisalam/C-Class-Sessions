// Section B3 Problems 1-5

double money1 = 1234.567;
decimal money2 = 98.76M;

Console.WriteLine("Money 2 is " + money2);
Console.WriteLine("Money 2 is {0}", money2);
Console.WriteLine($"Money 2 is {0}", money2);

Console.WriteLine($"Money 1 is {0}", money1);

double money2double = (double)money2;

Console.WriteLine("Money 1 + Money 2 = " + money1 + money2double);

Console.WriteLine("Money 1 + Money 2 = " + money1 * money2double);















