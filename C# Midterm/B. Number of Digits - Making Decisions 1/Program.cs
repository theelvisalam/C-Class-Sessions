Console.WriteLine("Input a short integer variable");
short x = short.Parse(Console.ReadLine());

if (x <= 9 && x >= -9) {
    Console.WriteLine("1");
}
else if (x <= 99 && x >= 10) {
    Console.WriteLine("2");
}
else if (x <= -10 && x >= -99) {
    Console.WriteLine("2");
}
else if (x <= 999 && x >= 100) {
    Console.WriteLine("3");
}
else if (x <= -100 && x >= -999) {
    Console.WriteLine("3");
}
else if (x <= 9999 && x >= 1000) {
    Console.WriteLine("4");
}
else if (x <= -1000 && x >= -9999) {
    Console.WriteLine("4");
}
else if (x <= 32767 && x >= 10000) {
    Console.WriteLine("5");
}
else if (x <= -10000 && x >= -32768) {
    Console.WriteLine("5");
}
else {
    Console.WriteLine("Not a short integer variable must range from -32768 to 32767");
}