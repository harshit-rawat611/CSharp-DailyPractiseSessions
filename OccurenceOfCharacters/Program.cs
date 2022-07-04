using System;
using System.Text.RegularExpressions;

namespace OccurenceOfCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string newString;
                int count = 0;
                Console.Write("Enter a string : ");
                newString = Console.ReadLine();
                string str = Regex.Replace(newString, @"\s", "");
                for (int i = 0; i < str.Length; i++)
                {
                    count = 0;
                    for(int j = 0; j < str.Length; j++)
                    {
                        if(str[j] == str[i] && i>j)
                        {
                            break;
                        }
                        if(str[i] == str[j] )    
                            count++;
                    }
                    if(count> 0)
                    Console.WriteLine(str[i]+" occured "+count+" times.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);    
            }
            Console.ReadLine();
            }
    }
}
