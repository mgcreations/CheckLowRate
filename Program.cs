using System;

namespace CheckLowRate
{
    class Program
    {
        static void Main()
        {
            double hourlyRate;

            Console.Write("Enter the hourly rate of pay: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            if (hourlyRate <= 5.65)
                Console.WriteLine("Error: Hourly Rate too low.");
        }
    }
}
