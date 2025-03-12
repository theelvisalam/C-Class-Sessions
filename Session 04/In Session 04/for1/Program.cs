using System.Net;

const decimal INT_RATE = 0.01m;
Console.Write("Enter the initial bank balance =>");
decimal bankBal = decimal.Parse(Console.ReadLine());
char response;
do
{
    Console.WriteLine($"Bank balance is {bankBal:C}");
    bankBal = bankBal + bankBal * INT_RATE;
    Console.WriteLine("Do you want to see next year's balance? Y or N...");
    // get response and convert to a character
    response = Convert.ToChar(Console.ReadLine());

} while (response == 'Y');
