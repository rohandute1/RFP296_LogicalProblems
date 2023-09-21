using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class NextDayCalculator
    {
        public void CalculateNextDay()
        {
            Console.Write("Input a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a month [1-12]: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a day [1-31]: ");
            int day = Convert.ToInt32(Console.ReadLine());

            if (year < 1 || month < 1 || month > 12 || day < 1 || day > 31)
            {
                Console.WriteLine("Invalid input. Please enter a valid date.");
                return;
            }

            DateTime inputDate = new DateTime(year, month, day);
            DateTime nextDate = inputDate.AddDays(1);

            Console.WriteLine($"The next date is [yyyy-MM-dd] {nextDate.ToString("yyyy-MM-dd")}");
        }
    }
}
