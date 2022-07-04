using System;

namespace Temperature_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int resultTemp = 0;
                Console.WriteLine("Enter the Temperature value");
                int temp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPress 1 to convert the temperature to Celcius");
                Console.WriteLine("\nPress 2 to convert the temperature to Celcius");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    resultTemp = (5 * (temp - 32)) / 9;
                else if (choice == 2)
                    resultTemp = ((9 * temp) / 5) + 32;

                Console.WriteLine("\n Final Temperature is : " +resultTemp);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
