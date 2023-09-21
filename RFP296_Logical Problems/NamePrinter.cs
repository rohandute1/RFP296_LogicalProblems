using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class NamePrinter
    {
        public void PrintFullName(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a full name as a command-line argument.");
                return;
            }

            string fullName = string.Join(" ", args);
            string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int numberOfParts = nameParts.Length;

            Console.WriteLine($"The full name contains {numberOfParts} part(s).");

            Console.WriteLine("Parts of the name:");
            foreach (string part in nameParts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
