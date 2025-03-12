const decimal PENNIES = 0.01m;
const decimal NICKLES = 0.05m;
const decimal QUARTERS = 0.25m;

int pennies = 53;
int nickles = 22;
int quarters = 7;

decimal total = (decimal)((PENNIES * pennies) + (NICKLES * nickles) + (QUARTERS * quarters));

Console.WriteLine($"${total} = {pennies} pennies, {nickles} nickles, and {quarters} quarters.");




