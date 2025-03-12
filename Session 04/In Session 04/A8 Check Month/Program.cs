Console.WriteLine("Enter a birth month");

int checkMonth = Convert.ToInt32(Console.ReadLine());

if (checkMonth <= 1 && checkMonth >= 12)
{
    Console.WriteLine("ERROR");
}
else
{
    Console.WriteLine(checkMonth + " is a valid month");
}

///////////////////////////////////////////////////////

Console.WriteLine("Enter a birth month");

int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a birth day");

int day = Convert.ToInt32(Console.ReadLine());

if (month == 1 && day <= 1 && day >= 31)
{
    Console.WriteLine("ERROR");
}
else
{
    Console.WriteLine(month + " " + day + " " + " is a valid date");
}

// int checkMonth2 = Convert.ToInt32(Console.ReadLine());