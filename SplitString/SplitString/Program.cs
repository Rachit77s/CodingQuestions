using System;
using System.Collections.Generic;

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SplitString("Hello Rachit Srivastava");
            Console.ReadKey();

        }
        //Rachit is a Boy
        public static void SplitString(string inputStr)
        {
            string tempStr = "";
            char delimiter = ' ';

            List<string> list = new List<string>();
            //list.Add("Hi");
            // String[] strArray = list.ToArray();
            String[] strArray;// = list.ToArray();

            for (int i = 0; i < inputStr.Length; i++)
            {
                //Go into this condition when we come across space
                if (inputStr[i] == delimiter)
                {
                    //If TempStr has something then perform below action and preserve the string in List     RachitSpace
                    if (tempStr.Length > 0)
                    {
                        //Console.WriteLine(tempStr);
                        list.Add(tempStr);
                        tempStr = "";
                    }
                }
                //First go into this condition and fill the tempStr
                else
                {
                    tempStr = tempStr + inputStr[i];
                }
            }

            //This condition is because the last string will not be present in the list, hence we need to insert the last string in the list.
            //It wil not be present because at the last string we are not encountering the delimiter hence we are not adding the string in the list.
            if (tempStr.Length > 0)
            {
                //Console.WriteLine(tempStr);
                //Add the last string in the list of strings
                list.Add(tempStr);
                tempStr = "";
            }

            //strArray = list.ToArray();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
