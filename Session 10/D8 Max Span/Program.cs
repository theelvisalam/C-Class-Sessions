int MaxSpan(int[] array)
{
    int max = 0;
    for (int start = 0; start < array.Length; start++)
    {
        for (int end = start + 1; end < array.Length; end++)
        {
            if (array[start] == array[end])
            {
                int count = end - start + 1;
                if (count > max)
                {
                    max = count;
                }
            }
        }
    }
    return max;
}
Console.WriteLine(MaxSpan(new[] { 4, 4, 2, 1, 4, 4, 4, 1 }));