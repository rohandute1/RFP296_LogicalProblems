using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class NumberGenerator
    {
        private Random random = new Random();

        public void GenerateAndCalculateAverage()
        {
            int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = random.Next(10, 51); 
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Generated Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Average: " + average);
        }
    }
}
