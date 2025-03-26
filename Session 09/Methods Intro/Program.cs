
using System.Reflection.Metadata;

/**
For a method that accepts a parameter, what are the components of the parameter definition that must be included in the method declaration? Show an example of a method declaration with a parameter.
That is, create a method named DisplaySalesTax(), which computes and displays a tax as 7 percent of a selling price.
Also, write in the main app to invoke the method.
Modify the method to include a single argument of selling price.
*/
void DisplaySalesTax()
{
    Console.WriteLine("Enter the selling price:");
    decimal sellingPrice = decimal.Parse(Console.ReadLine());
    decimal salesTax = 0.07m * sellingPrice;
    Console.WriteLine($"The sales tax of selling price {sellingPrice:c} is {salesTax:c}. ");
}

// DisplaySalesTax();

bool IsRateOK()
{
    Console.WriteLine("IsRateOK");
    return false;
}

// IsQuantityOK()
bool IsQuantityOK()
{
    Console.WriteLine("IsQuantityOK");
    return true;
}

Console.WriteLine($"The result is {IsRateOK() && IsQuantityOK()}");