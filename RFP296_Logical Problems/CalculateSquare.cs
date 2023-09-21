using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class CalculateSquare
    {
        public void SquareCalculator()
        {
            Console.WriteLine("Please enter First number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter Second Number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1- num2;

            double SquareOfSum = sum * sum;
            double SquareOfDifference = difference * difference;

            Console.WriteLine($"Square of the sum:{SquareOfSum}");
            Console.WriteLine($"Square of the difference:{SquareOfDifference}");
        }
    }
}
