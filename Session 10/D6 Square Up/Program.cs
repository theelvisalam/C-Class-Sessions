static int[] SquareUp(int n)
{
    int[] array = new int[n * n];
    int k = 0;
    for (int j = 1; j <= 1; j++)
    {

        for (int i = n; i >= 1; i--)
        {
            if (i <= j)
            {
                array[k] = i;
            }
            else
            {
                array[k] = 0;
            }
        }
    }
}



for (int j = 1; j < 10; j++)