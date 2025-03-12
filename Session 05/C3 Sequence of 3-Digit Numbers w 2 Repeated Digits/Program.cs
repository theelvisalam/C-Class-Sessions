for (int i = 100; i <= 999; i++) {

    string num = i.ToString();
    char first = num[0];
    char second = num[1];
    char third = num[2];

    if ((first == second && second != third) || 
    (first == third && first != second) ||
    (second == third && second != first)) {
        Console.WriteLine("" + i);
    }
}