Console.WriteLine("Enter a starting number");
int start = int.Parse(Console.ReadLine());

Console.WriteLine("Enter an ending number");
int end = int.Parse(Console.ReadLine());

int len = (start - end) + 1;

int[] arr1 = new int[len];
int[] arr2 = new int[len];

int arr1Ct = 0;
int arr2Ct = 0;

int arr1Sum = 0;
int arr2Sum = 0;

if (start <= end)
{
    for (int i = start + 1; i <= end - 1; i++)
    {
        arr1Ct++;
        arr1Sum += arr1[i];
        arr1[i] = i;
    }
}
else if (start >= end)
{
    for (int i = end - 1; i <= start + 1; i++)
    {
        arr2Ct++;
        arr2Sum += arr2[i];
        arr2[i] = i;

    }
}

foreach (int i in arr1)
{
    Console.WriteLine(i); ;
}