using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueExecution = true;

            while (continueExecution)
            {
                Console.WriteLine("Welcome to Logical Problems");
                Console.WriteLine("Please choose any one program.");
                Console.WriteLine("1.FriendList\n2.Square Calculator\n3.Favorite place Name\n"+
                    "4.Multiply number by 10 in string only\n5.Number analyzer\n6.Calculate Average of 5 Random Numbers\n"+
                    "7.Calculate Area & Perimeter of circle\n8.Next day calculator\n"+
                    "9.Calculate execution time\n" +
                    "10.Find Numbers between 2000-3200 which are divisible by 7 and not multiple of 5");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        FriendList friendList = new FriendList();
                        friendList.DisplayFriends();
                        break;

                    case 2:
                        CalculateSquare calculateSquare = new CalculateSquare();
                        calculateSquare.SquareCalculator();
                        break;

                    case 3:
                        PrintPlaceName placeName = new PrintPlaceName();
                        placeName.PlaceNamePrinter();
                        break;

                    case 4:
                        NumberMultiplier numberMultiplier = new NumberMultiplier();
                        numberMultiplier.Multiply_10_Times();
                        break;

                    case 5:
                        Console.WriteLine("Full Name Analyzer");
                        NamePrinter namePrinter = new NamePrinter();
                        namePrinter.PrintFullName(args);
                        break;

                    case 6:
                        Console.WriteLine("Generating 5 random numbers between 10 and 50 and calculating the average:");
                        NumberGenerator numberGenerator = new NumberGenerator();
                        numberGenerator.GenerateAndCalculateAverage();
                        break;

                    case 7:
                        Console.WriteLine("Calculate the perimeter and area of a circle:");
                        AreaPerimeterCalculator circleCalculator = new AreaPerimeterCalculator();
                        circleCalculator.Calculate_Area_Peremiter();
                        break;

                    case 8:
                        Console.WriteLine("Get the next day of a given date:");
                        NextDayCalculator nextDayCalculator = new NextDayCalculator();
                        nextDayCalculator.CalculateNextDay();
                        break;

                    case 9:
                        Console.WriteLine("Measuring execution time of a code block:");
                        CountExecutionTime calculator = new CountExecutionTime();
                        calculator.ExecutionTimeCounter();
                        break;

                    case 10:
                        Console.WriteLine("Finding numbers between 2000 and 3200 that are divisible by 7 but not multiples of 5:");
                        NumberFinder finder = new NumberFinder();
                        finder.FindNumbers();
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid program.");
                        break;
                }

                Console.Write("Do you want to continue (yes/no)? ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }
        }
    }
}