using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static string[] x = { "is", "valid", "right" };
        static string valid = "IsValid"; 

        static void Main(string[] args)
        {                                
            Console.WriteLine(isValid(x,valid));
            Console.ReadLine();
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
