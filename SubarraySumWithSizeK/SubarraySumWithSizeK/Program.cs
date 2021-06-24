using System;

namespace SubarraySumWithSizeK
{
    // https://www.geeksforgeeks.org/find-subarray-with-given-sum/
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int n = arr.Length;
            int sum = 23;
            var k2 = CheckSubarraySumMethod1(arr, n,sum);

            Console.ReadKey();
        }

        // Function to check if any Subarray
        // of size K has a given Sum
        static int CheckSubarraySumMethod1(int[] arr, int n, int sum)
        {
            //From every index start another loop from i to the end of array to get all subarray starting from i,
            //keep a variable sum to calculate the sum.
            //For every index in inner loop update sum = sum + array[j]

            int currentSum = 0;

            // Loop over each array element one by one
            //let i = subArrayStart
            for (int i = 0; i < n; i++)
            {
                //{ 15, 2, 4, 8, 9, 5, 10, 23 };

                currentSum = arr[i];

                //let j = subArrayEnd
                // Compare i(th) array element with each element
                for (int j = i+1; j <= n; j++)
                {
                    if (currentSum == sum)
                    {
                        //subArrayEnd - 1
                        int p = j - 1;
                        Console.WriteLine("Sum found between " + "indexes " + i + " and " + p);

                        for (int k = 1; k <= 4; k++)
                        {
                            Console.Write(arr[k] + ", ");
                        }
                        return 1;
                    }

                    //Break the inner loop if its sum gets > requiredSum
                    if (currentSum > sum || j == n)
                        break;

                    // Calculate the current sum
                    currentSum = currentSum + arr[j];
                }                 
            }
            Console.Write("No subarray found");
            return 0;
        }

        static int CheckSubarraySumMethod2(int[] arr, int n, int sum)
        {
            int curr_sum = arr[0],
            start = 0, i;

            // Pick a starting point
            for (i = 1; i <= n; i++)
            {
                // If curr_sum exceeds the sum, then remove the starting elements
                while (curr_sum > sum && start < i - 1)
                {
                    curr_sum = curr_sum - arr[start];
                    start++;
                }

                // If curr_sum becomes equal to sum, then return true
                if (curr_sum == sum)
                {
                    int p = i - 1;
                    Console.WriteLine("Sum found between " + "indexes " + start + " and " + p);
                    return 1;
                }

                // Add this element to curr_sum
                if (i < n)
                    curr_sum = curr_sum + arr[i];
            }
            Console.WriteLine("No subarray found");
            return 0;
        }
    }
}
