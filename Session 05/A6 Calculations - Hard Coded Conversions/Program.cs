const decimal USD = 1m;
const decimal CAD = 1.35m;
const decimal EUR = 0.93m;

decimal amount_usd = 7.00m;
decimal amount_cad = 12.00m;
decimal amount_eur = 5.00m;

decimal totalUSD = (decimal)(amount_cad / CAD) + (amount_eur / EUR) + (amount_usd / USD);

decimal totalCAD = (decimal)(totalUSD * CAD);

decimal totalEUR = (decimal)(totalUSD * EUR);

Console.WriteLine($"{amount_cad} CAD + {amount_eur} EUR + {amount_usd} USD = {totalCAD:F2} CAD or {totalEUR:F2} EUR or {totalUSD:F2} USD.");




