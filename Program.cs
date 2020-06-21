using System;

namespace CheckLowRate
{
    class Program
    {
        static void Main()
        {
            double hourlyRate;
            const double LOW_RATE = 5.65;

            Console.Write("Enter the hourly rate of pay: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            if (hourlyRate <= LOW_RATE)
                Console.WriteLine("Error: You entered an amount lower than {0}", LOW_RATE.ToString("C"));
            else
                Console.WriteLine("You entered {0} as the hourly rate.", hourlyRate.ToString("C"));
        }
    }
}
