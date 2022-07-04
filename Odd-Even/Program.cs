using System;

namespace Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int userWantsToContinue;
                do
                {
                    Console.Write("\nEnter a number : ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n % 2 == 0)
                        Console.WriteLine(n + " is an Even number !!!");
                    else
                        Console.WriteLine(n + " is an Odd number !!!");
                    Console.WriteLine("\nPress 1 to continue...");
                    userWantsToContinue = Convert.ToInt32(Console.ReadLine());

                } while (userWantsToContinue==1);
                }
            catch(Exception e )
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
