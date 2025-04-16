namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 10, 27, 30, 34, 51, 56, 65, 77, 81, 82, 93, 99 };
            Console.WriteLine("Enter the item.");
            int item = Convert.ToInt32(Console.ReadLine());
            int index = BinarySearch(array, item);

            if (index >= 0)
            {
                Console.WriteLine($"The item with a value of {array[index]} is found at position {index}.");
            }
            else
            {
                Console.WriteLine("The item is not found in the array");

            }
        }

        static int LinearSearch(int[] a, int item)
        {
            int index = -1;
            // O(n)
            for (int i = 0; i < a.Length; i++)
            {
                if (item == a[i])
                {
                    index = i;
                }
            }
            return index;
        }

        static int BinarySearch(int[] a, int item)
        {
            int index = -1;
            int low = 0;
            int high = a.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (item > a[mid])
                {
                    low = mid + 1;
                }
                if (item < a[mid])
                {
                    high = mid - 1;
                }
                if (item == a[mid])
                {
                    index = mid;
                    break;
                }

            }

            return index;
        }
    }
}
