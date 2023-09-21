using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class AreaPerimeterCalculator
    {
        public void Calculate_Area_Peremiter()
        {
            Console.Write("Enter the diameter of the circle: ");
            double diameter = Convert.ToDouble(Console.ReadLine());

            double radius = diameter / 2;

            double perimeter = 2 * Math.PI * radius;

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Perimeter of the circle: {perimeter}");
            Console.WriteLine($"Area of the circle: {area}");
        }
    }
}
