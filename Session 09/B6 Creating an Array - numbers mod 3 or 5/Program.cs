
Console.WriteLine("Enter length of an array");
int arrLength = int.Parse(Console.ReadLine());

if (arrLength <= 0)
{
    Console.WriteLine("array = { }");
    return;
}

int[] arr = new int[arrLength];
int count = 0;
int num = 10;
int sum = 0;

while (count < arrLength)
{
    if (num % 3 != 0 && num % 5 != 0)
    {
        arr[count] = num;
        sum += num;
        count++;
    }
    num++;
}

Console.Write("array = { ");
for (int i = 0; i < arrLength; i++)
{
    if (i == arrLength - 1)
        Console.Write(arr[i]);
    else
        Console.Write(arr[i] + " ");
}
Console.WriteLine(" }");

double avg = (double)sum / arrLength;
Console.WriteLine($"The average is {avg}");