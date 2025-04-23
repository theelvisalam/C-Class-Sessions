Console.WriteLine("Danielle, Edward, and Fatima are salespeople at Holiday Homes. Enter the initial of the salesperson (D, E, or F). Enter Z to enter amount of a sale");
string salesPerson = Console.ReadLine();
int sumD = 0;
int sumE = 0;
int sumF = 0;

int grandTotal = 0;

if (salesPerson == "D")
{

    if (salesPerson == "Z")
    {
        Console.WriteLine("Enter amount of sale");
        int salesPriceD = int.Parse(Console.ReadLine());
        sumD += salesPriceD;
    }

}
else if (salesPerson == "E")
{
    if (salesPerson == "Z")
    {
        Console.WriteLine("Enter amount of sale");
        int salesPriceE = int.Parse(Console.ReadLine());
        sumE += salesPriceE;
    }

}
else if (salesPerson == "F")
{
    if (salesPerson == "Z")
    {
        Console.WriteLine("Enter amount of sale");
        int salesPriceF = int.Parse(Console.ReadLine());
        sumF += salesPriceF;
    }

}
else
{
    Console.WriteLine("INVALID INITIAL");
}

Console.WriteLine($"Total of all sales for Danielle: {sumD}");

Console.WriteLine($"Total of all sales for Edward: {sumE}");

Console.WriteLine($"Total of all sales for Fatima: {sumF}");

grandTotal = sumD + sumE + sumF;
Console.WriteLine($"Grand Total of all sales: {grandTotal}");

if (sumD > sumE && sumD > sumF)
{
    Console.WriteLine($"Danielle is the salesperson with the most sales with {sumD} total sales");
}
else if (sumE > sumD && sumE > sumF)
{
    Console.WriteLine($"Edward is the salesperson with the most sales with {sumE} total sales");
}
else
{
    Console.WriteLine($"Fatima is the salesperson with the most sales with {sumF} total sales");
}



