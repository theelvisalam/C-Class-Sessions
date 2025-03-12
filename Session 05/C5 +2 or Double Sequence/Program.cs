int num = 10;

/*while (num <= 20) {
    for (int i = 0;)
}
*/
for (int i = 1; i <= 20; i++)
{

    Console.WriteLine(num);

    if (i % 5 == 0)
    {

        num *= 2;

    }
    else
    {
        num += 2;
    }
}