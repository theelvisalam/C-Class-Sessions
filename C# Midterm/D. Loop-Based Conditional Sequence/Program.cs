int num = 1;

Console.WriteLine(num);

for (int i = num; i <= 9; i++) {
    if (num % 3 != 0) {
        num += 7;
        Console.WriteLine(num);
    }
    else if (num % 3 == 0) {
        num /= 3;
        Console.WriteLine(num);
    }
}