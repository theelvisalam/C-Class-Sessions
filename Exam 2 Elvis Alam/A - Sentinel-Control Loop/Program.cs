using System.Globalization;

int sentinel = 50;
int input;
int sum = 0;
int count = 0;

Console.WriteLine("Enter integers one by one. Enter '50' to stop.");

while (true) {
    Console.WriteLine("Enter an integer ==> ");
    input = int.Parse(Console.ReadLine());
    if (input == sentinel) {
        Console.WriteLine("Sentinel value (50) entered. Stopping Input.");
        break;
    }
    else if (input > 10 && input < 99) {
        sum += input;
        count++;
        Console.WriteLine($"  -> {input} added (Sum={sum}, Count={count})");
    }
}

if (count > 0) {
    double avg = (double)sum / count;
    Console.WriteLine($"Average: {avg}");

} else {
    Console.WriteLine("ERROR");
}

