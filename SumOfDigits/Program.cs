using System;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number,a;
                int sum = 0;
                Console.Write("Enter a number : ");
                number = Convert.ToInt32(Console.ReadLine());
                int numb = number;
                while(number > 0)
                {
                    a = number % 10;
                    sum += a;
                    number /= 10;
                }
                Console.WriteLine("\nSum of the digits of "+numb+" is "+sum);

            }
            catch(Exception m)
            {
                Console.WriteLine(m.Message);
            }
            Console.ReadLine();
        }
    }
}
