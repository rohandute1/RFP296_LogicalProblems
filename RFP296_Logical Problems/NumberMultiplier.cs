using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class NumberMultiplier
    {
        public void Multiply_10_Times()
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number)) 
            {
                int result = number * 10;
                Console.WriteLine($"10 times the number: {result.ToString()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number as a string.");
            }
        }
    }
}
