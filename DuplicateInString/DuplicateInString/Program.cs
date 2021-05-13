using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateInString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //DuplicateCharInStringNormalApproach();
            //DuplicateCharInStringUsingDictionary();
            //DeleteDuplicateCharFromStringNormalApproach();
            // DuplicateElementInStringUsingLinq();
            //DuplicateElementInListOfStringUsingLinq();
            DeleteDuplicateElementInListOfStringNormalApproach();


            Console.ReadKey();
        }

        static void DuplicateCharInStringNormalApproach()
        {
            int count = 0;
            string inputStr = "Great responsibility";

            //Converts given string into character array  
            char[] str = inputStr.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] == str[j] && str[i] != ' ')
                    {
                        count++;
                        //Set string1[j] to 0 to avoid printing visited character  
                        //str[j] = '0';
                    }
                }

                //A character is considered as duplicate if count is greater than 1  
                if (count > 1 && str[i] != '0')
                    Console.WriteLine(str[i]);
            }
        }


        static void DuplicateCharInStringUsingDictionary()
        {
            string str = "happpppppppy";
            var dict = new Dictionary<char, int>();

            foreach (var value in str)
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


        static void DeleteDuplicateCharFromStringNormalApproach()
        {
            int count = 0;
            //string[] str = { "", "John", "John", "John", "Mary", "Mary", "Mary", "", null, null, "John" };

            //Converts given string into character array  
            //char[] str = inputStr.ToCharArray();

            string inputStr = "DotNetWorld";
            string resultStr = String.Empty;
            string duplicateStr = String.Empty;
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (!resultStr.Contains(inputStr[i]))
                {
                    resultStr = resultStr + inputStr[i];
                }
                //For showing duplicate string
                else
                {
                    duplicateStr = duplicateStr + inputStr[i];
                }
            }

            Console.WriteLine(resultStr);
            Console.WriteLine(duplicateStr);
        }


        static void DuplicateElementInStringUsingLinq()
        {
            //string[] str = { "", "John", "John", "John", "Mary", "Mary", "Mary", "", null, null, "John" };
            string str = "DotNetWorld";

            var query = str.GroupBy(x => x)                    
                          .Where(g => g.Count() > 1)
                          .Select(y => new { Element = y.Key, Counter = y.Count() })
                          .ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            
        }


        static void DeleteDuplicateElementInListOfStringNormalApproach()
        {
            List<string> names = new List<string>(new string[] { "", "John", "John", "John", "Mary", "Mary", "Mary", "", null, null, "John" });
            List<string> uniqueStringList = new List<string>();

            for (int i = 0; i < names.Count; i++)
            {
                if (!string.IsNullOrEmpty(names[i]))
                {
                    // Add the 1st item in the Unique List
                    if (uniqueStringList.Count == 0)
                    {
                        uniqueStringList.Add(names[i]);
                    }
                    else
                    {

                        var itemFoundFlag = false;

                        //Loop over uniqueStringList and if uniqueStringList contains the same element as the original list then break
                        for (int j = 0; j < uniqueStringList.Count; j++)
                        {                           
                            if (uniqueStringList[j] == names[i])
                            {
                                itemFoundFlag = true;
                                break;
                            }
                        }

                        //Add item in the uniqueStringList if the item is not already present in it.
                        if (!itemFoundFlag)
                        {
                            uniqueStringList.Add(names[i]);
                        }
                    }                    
                }               
            }

            foreach (var item in uniqueStringList)
            {
                Console.WriteLine(item);
            }
        }


        static void DuplicateElementInListOfStringUsing2Lists()
        {
            string[] names = { "", "John", "John", "John", "Mary", "Mary", "Mary", "", null, null, "John" };

            List<string> duplicateKeys = new List<string>();
            List<string> notDuplicateKeys = new List<string>();
            foreach (var text in names)
            {
                if (notDuplicateKeys.Contains(text))
                {
                    duplicateKeys.Add(text);
                }
                else
                {
                    notDuplicateKeys.Add(text);
                }
            }

            // show list without duplicates 
            foreach (var s in notDuplicateKeys)
                Console.WriteLine(s);

            // show duplicates list
            foreach (var s in duplicateKeys)
                Console.WriteLine(s);
        }


        static void DuplicateElementInListOfStringUsingLinq()
        {
            string[] str = { "", "John", "John", "John", "Mary", "Mary", "Mary", "", null, null, "John" };

             str = str.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            var query = str.GroupBy(x => x)
                          .Where(g => g.Count() > 1)
                          .Select(y => new { Element = y.Key, Counter = y.Count() })
                          .ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
