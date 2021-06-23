using System;

namespace SecondLargestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 35, 1, 10, 34, 1 };
            int n = arr.Length;
            Print2ndLargest(arr, n);
            Console.ReadKey();
        }

        public static void Print2ndLargest(int[] arr, int arr_size)
        {
            int first, second;

            if (arr_size < 2)
            {
                Console.WriteLine(" Invalid Input ");  
                return;
            }

            first = second = int.MinValue;

            for (int i = 0; i < arr_size; i++)
            {
                // If current element is smaller than
                // first then update both first and second
                if (arr[i] > first)
                {  
                    // Put first value in second
                    second = first;
                    // Update the first with new value
                    first = arr[i];
                }
                // If arr[i] is in between first
                // and second then update second
                else if (first > arr[i] && arr[i]> second)   
                {
                    second = arr[i];
                }
            }

            if (second == int.MinValue)
            {
                Console.Write("There is no second largest" + " element\n");
            }
            else
            {
                Console.Write("The second largest element" + " is " + second);

            }
        }
    }
}
