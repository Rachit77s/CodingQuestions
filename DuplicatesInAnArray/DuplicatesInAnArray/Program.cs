using System;
using System.Collections.Generic;

namespace DuplicatesInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            FindDuplicateInArrayNormalApproach();
            FindDuplicateInArrayUsingDictionary();
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
    }
}
