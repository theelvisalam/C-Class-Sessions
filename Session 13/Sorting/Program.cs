namespace Sorting
{
    class Program
    {
        public static int Times = 0;
        public const int Significance = 100;

        /* To test stability, use LessThan, GreaterThan, Equals, Compare, LessThanOrEquals, and GreaterThanOrEquals helper functions instead of <, >, ==, <=, and >= operators when implementing the sort method. */
        public static bool StabilityCheck = false;

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void BubbleSort(int[] a)
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (GreaterThan(a[i], a[i + 1]))
                    {
                        Swap(ref a[i], ref a[i + 1]);
                    }
                }
            }
        }

        static void ExchangeSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (LessThan(a[j], a[i]))
                    {
                        Swap(ref a[i], ref a[j]);
                    }
                }
            }
        }

        static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (LessThan(a[j], a[min_index]))
                    {
                        min_index = j;
                    }
                }
                if (min_index != i)
                {
                    Swap(ref a[min_index], ref a[i]);
                }
            }
        }

        static void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int element = a[i];
                int j;
                for (j = i - 1; j >= 0; j--)
                {
                    if (GreaterThan(a[j], element))
                    {
                        a[j + 1] = a[j];
                    }
                    else
                    {
                        break;
                    }
                }
                a[j + 1] = element;
            }
        }

        static void MergeSort(int[] a)
        {
            int[] temp = new int[a.Length];
            Partition(a, 0, a.Length - 1, temp);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="start1"></param>
        /// <param name="end1"></param>
        /// <param name="start2">start2 = end1 + 1</param>
        /// <param name="end2"></param>
        static void Merge(int[] a, int start1, int end1, int start2, int end2, int[] temp)
        {

            int i = start1;
            int j = start2;
            for (int k = start1; k <= end2; k++)
            {
                if (i > end1)
                {
                    temp[k] = a[j];
                    j++;
                }
                else if (j > end2)
                {
                    temp[k] = a[i];
                    i++;
                }
                else if (a[i] < a[j])
                {
                    temp[k] = a[i];
                    i++;
                }
                else
                {
                    temp[k] = a[j];
                    j++;
                }
            }
            Array.Copy(temp, start1, a, start1, end2 - start1 + 1);
        }
        static void Partition(int[] a, int start, int end, int[] temp)
        {
            if (end > start)
            {
                int mid = (end + start) / 2;
                Partition(a, start, mid, temp);
                Partition(a, mid + 1, end, temp);
                Merge(a, start, mid, mid + 1, end, temp);
            }
        }
        static void QuickSort(int[] a)
        {
        }

        static void HeapSort(int[] a)
        {
        }

        static void IntroSort(int[] a)
        {
        }

        static void Main(string[] args)
        {
            int length = args is not null && args.Length > 0 ? int.Parse(args[0]) : Significance * Significance;
            Action<int[]>[] sortMethods = { BubbleSort, ExchangeSort, SelectionSort, InsertionSort, MergeSort, QuickSort, HeapSort, IntroSort, Array.Sort };
            var stopwatch = new System.Diagnostics.Stopwatch();
            int[][] array = InitArray(length);

            foreach (var sortMethod in sortMethods)
            {
                Array.Copy(array[0], array[1], length);
                Times = 0;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                stopwatch.Restart();
                long memory = GC.GetTotalMemory(false);
                StabilityCheck = false;
                sortMethod(array[1]);
                var elapsed = stopwatch.Elapsed;
                memory = GC.GetTotalMemory(false) - memory;
                bool assert1 = Assert(array[1], array[2]);
                bool assert2 = false;
                string status = "";
                if (assert1)
                {
                    if (!StabilityCheck)
                    {
                        status = " Sorted ";
                    }
                    else
                    {
                        Array.Copy(array[0], array[1], length);
                        // Sort by the Most Significant Figures first, then by Least Significant Figures.
                        for (Times = 1; Times <= 2; Times++)
                        {
                            sortMethod(array[1]);
                        }
                        status = Assert(array[1], array[2]) ? " Stable " : "Unstable";
                    }
                }
                else
                {
                    status = "   --   ";
                }

                Console.WriteLine("{0,16} {3,8} {1,16} with {2,8:N0} bytes used.",
                    sortMethod.Method.Name,
                    elapsed,
                    memory,
                    status
                );
            }
            Console.ReadLine();
        }

        #region Helper Functions
        static int[][] InitArray(int length, int range = 0)
        {
            int[] array = new int[length];

            Random rand = new Random();
            for (int i = 0; i < length; array[i] = rand.Next(range == 0 ? -length / 2 : range, range == 0 ? length / 2 : range), i++) ;
            return InitArray(array);
        }

        static int[][] InitArray(int[] data)
        {
            int[][] array = { data, new int[data.Length], new int[data.Length] };

            Array.Copy(array[0], array[2], data.Length);
            Array.Sort(array[2]);
            return array;
        }

        static bool Assert(int[] actual, int[] expected)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Comparisons
        ///
        /// Get significant figures
        /// 
        ///
        ///times indicate the number of times significance is taken into consideration; 0 means it takes all.
        /// 

        public static int GetSignificance(int value, int times = 0)
        {
            StabilityCheck = true;
            for (int i = 1; i < times; i++)
            {
                value /= Significance;
            }
            return times > 0 ? value % Significance : value;
        }

        public static bool LessThan(int a, int b)
        {
            StabilityCheck = true;
            a = GetSignificance(a, Times);
            b = GetSignificance(b, Times);
            return a < b;
        }

        public static bool GreaterThan(int a, int b)
        {
            StabilityCheck = true;
            a = GetSignificance(a, Times);
            b = GetSignificance(b, Times);
            return a > b;
        }

        public static bool Equals(int a, int b)
        {
            StabilityCheck = true;
            a = GetSignificance(a, Times);
            b = GetSignificance(b, Times);
            return a == b;
        }

        public static int Compare(int a, int b)
        {
            StabilityCheck = true;
            a = GetSignificance(a, Times);
            b = GetSignificance(b, Times);
            return a.CompareTo(b);
        }

        public static bool LessThanOrEquals(int a, int b) => LessThan(a, b) || Equals(a, b);
        public static bool GreaterThanOrEquals(int a, int b) => GreaterThan(a, b) || Equals(a, b);

        #endregion

    }
}
