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
            string[] str = AllLongestString(x);

            foreach (string w in str)
            {
                Console.Write(w + " ");
            }
            Console.ReadLine();
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
