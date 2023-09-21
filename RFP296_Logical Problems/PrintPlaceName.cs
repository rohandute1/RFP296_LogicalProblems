using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class PrintPlaceName
    {
        public void PlaceNamePrinter() 
        {
            Console.WriteLine("Enter the place you would like to visit most: ");
            string placeName = Console.ReadLine();

            string upperCaseName = placeName.ToUpper();
            string lowerCaseName = placeName.ToLower();

            Console.WriteLine($"Place name in Uppercase: {upperCaseName}");
            Console.WriteLine($"Place name in Lowercase: {lowerCaseName}");
        }
    }
}
