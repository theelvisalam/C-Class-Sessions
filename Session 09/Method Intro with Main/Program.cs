namespace Method_Intro_with_Main;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the selling price:");
        decimal sellingPrice = decimal.Parse(Console.ReadLine());
        DisplaySalesTax(sellingPrice);

    }

    /// <summary>
    /// Display the sales tax on the console from the selling price.
    /// </summary>
    /// <param name="sellingPrice">the selling price of an item</param>
    static void DisplaySalesTax(decimal sellingPrice)
    {

        decimal salesTax = CalculateSalesTax(sellingPrice, 0.0775m);
        Console.WriteLine($"The sales tax of selling price {sellingPrice:c} is {salesTax:c}. ");
    }

    /// <summary>
    /// Calculate the sales tax from the given selling price
    /// </summary>
    /// <param name="sellingPrice">the selling price of an item</param>
    /// <param name="salesTax">the sales tax</param>
    /// <returns>The sales tax</returns>
    static decimal CalculateSalesTax(decimal sellingPrice, decimal salesTax)
    {
        decimal tax = salesTax * sellingPrice;
        return tax;
    }
}
