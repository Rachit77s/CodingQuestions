using System;

namespace StringContainsSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "for";
            string s2 = "geeksforgeeks";

            int res = 0;//IsSubstring(s1, s2);
            PrintSubstring(s1, s2);
            if (res == -1)
                Console.Write("Not present");
            else
                Console.Write("Present at index " + res);

            Console.ReadKey();
        }

        public static int IsSubstring(string s1, string s2)
        {
            //string s1 = "for";
            //string s2 = "geeksforgeeks";

            int s1Length = s1.Length;
            // Considering s2 has larger length
            int s2Length = s2.Length;

            for (int i = 0; i < s2Length - s1Length; i++)
            {
                int j;

                //the inner loop from 0 to Small String
                for (j = 0; j < s1Length; j++)
                {
                    if (s2[i+j] != s1[j])
                    {
                        // Break the inner for loop
                        break;
                    }
                }

                if (j == s1Length)
                {
                    return i;
                }
            }

            return -1;
        }


        public static void PrintSubstring(string s1, string s2)
        {
            //string s1 = "for";
            //string s2 = "geeksforgeeks";

            int s1Length = s1.Length;
            // Considering s2 has larger length
            int s2Length = s2.Length;
            string tempStr= string.Empty;
            string matchedSubString = string.Empty;

            for (int i = 0; i < s2Length - s1Length; i++)
            {
                tempStr = "";

                //the inner loop from 0 to Small String
                for (int j = 0; j < s1Length; j++)
                {
                    if (s2[i + j] != s1[j])
                    {
                        // Break the inner for join
                        break;
                    }
                    else
                    {
                        tempStr += s2[i + j];
                    }                   
                }

                if (tempStr == s1)
                {
                    matchedSubString = tempStr;
                    break;
                }
            }

            if (matchedSubString == s1)
            {
                Console.WriteLine("Contains the word");
            }
        }
    }
}
