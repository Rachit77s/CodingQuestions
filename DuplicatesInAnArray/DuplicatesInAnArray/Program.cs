using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicatesInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //FindDuplicateInArrayNormalApproach();
            //FindDuplicateInArrayUsingDictionary();
            FindDuplicateInArrayUsingLinq();
           // RemoveDuplicatesFromArray();

            Console.ReadKey();
        }

        //Algorithm

        //Declare and initialize an array.
        //Duplicate elements can be found using two loops.The outer loop will iterate through the array from 0 to length of the array.
        //The outer loop will select an element.The inner loop will be used to compare the selected element with the rest of the elements of the array.
        //If a match is found which means the duplicate element is found then, display the element.
        public static void FindDuplicateInArrayNormalApproach()
        {
            //array.Length = 16
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count = count + 1;
                    }                                   
                }
                //Console.WriteLine("\t\n " + array[i] + " Occurs " + count + " times");
            }

            //Alternate Way
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = i; j < array.Length - 1; j++)
            //    {

            //        if (array[j] == array[j + 1])
            //            count = count + 1;
            //    }
            //    Console.WriteLine("\t\n " + array[i] + "occurse" + count);
            //    Console.ReadKey();
            //}

        }

        public static void FindDuplicateInArrayUsingDictionary()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };

            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                //Gets called only when duplicate value is present
                if (dict.ContainsKey(value))
                {
                    //Increment the occurrence by 1
                    dict[value]++;
                }
                else
                {
                    //Set default occurrence as 1 since every element is present once
                    dict[value] = 1;
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);

                // if frequency is more than 1 print the element
                //if (pair.Value > 1)
                //    Console.Write(pair.Key + " ");
            }
        }

        public static void FindDuplicateInArrayUsingLinq()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            //List<int> list = new List<int>() { 3, 5, 3, 2, 7, 7, 5, 6 };

            IEnumerable<int> duplicates = array.GroupBy(x => x)
                                              .Where(g => g.Count() > 1)
                                              .Select(x => x.Key);

            Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));
        }


        public static void RemoveDuplicatesFromArray()
        {
            int[] array = new int[] { 4, 8, 4, 1, 1, 4, 8 };
            int numDups = 0, prevIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool foundDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        foundDup = true;
                        numDups++; // Increment means Count for Duplicate found in array.
                        break;
                    }
                }

                if (foundDup == false)
                {
                    array[prevIndex] = array[i];
                    prevIndex++;
                }
            }

            // Just Duplicate records replce by zero.
            for (int k = 1; k <= numDups; k++)
            {
                array[array.Length - k] = '\0';
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        public static void RemoveDuplicatesFromArrayUsingList()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 13 };

            List<int> distinctValues = new List<int>();
            foreach (int val in array)
            {
                if (!distinctValues.Contains(val))
                {
                    distinctValues.Add(val);
                }
            }

            // Print updated array
            for (int i = 0; i < distinctValues.Count; i++)
                Console.Write(distinctValues[i] + " ");

        }
    }
}
