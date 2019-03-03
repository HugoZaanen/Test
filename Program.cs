using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static string[] x = { "is", "valid", "right","sdeda","sssss","1"};
        
        static void Main(string[] args)
        {
            //struct test
            #region            
            //Initialize:
            Coords coords1 = new Coords();
            Coords coords2 = new Coords(10, 10);

            //display results:
            Console.Write("Coords 1 : ");
            Console.WriteLine("x = {0}, y = {1}", coords1.x, coords1.y);

            Console.Write("Coords 2: ");
            Console.WriteLine("x = {0}, y = {1}", coords2.x,coords2.y);

            //Keep the console window open in debug mode
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            #endregion
        }

        public static void printRound(double num)
        {
            Console.WriteLine(Math.Round(num));
        }

        public static int commonCharacterCount(string s1, string s2)
        {
            int count = 0;
            ArrayList arr = new ArrayList();

            foreach (var s in s1)
            {
                if(!(arr.Contains(s)))
                {
                    arr.Add(s);
                }
            }

            foreach (var s in s2)
            {
                if(arr.Contains(s))
                {
                    count++;
                }
            }

            return count;
        }

        private static string[] AllLongestString(string[] inputArray)
        {
            ArrayList str = new ArrayList();
            int lenght = 0;

            foreach (string word in inputArray)
            {
                if (word.Length > lenght)
                {
                    lenght = word.Length;
                }
            }

            foreach (string word in inputArray)
            {
                if(word.Length == lenght)
                {
                    str.Add(word);
                }
            }

            return str.ToArray(typeof(string)) as string[];
        }

        private static bool isValid(string[] words, string validation)
        {           
            int k = 0;

            for(int i = 0; i < validation.Length;i++)
            {
                if(validation[i].ToString() == validation[i].ToString().ToUpper())
                {                   
                    string check = validation[i].ToString().ToLower();
                    
                    while(i < validation.Length - 1  && validation[i + 1].ToString() != validation[i + 1].ToString().ToUpper())
                    {
                        check += validation[i + 1].ToString();
                        i++;
                    }

                    foreach(string word in words)
                    {
                        if(word == check)
                        {
                            k++;
                        }
                    }

                    if(k == 0)
                    {
                        return false;
                    }
                }              
            }

            if (k == 0)
            {
                return false;
            }
            return true;
        }
    }    
}
