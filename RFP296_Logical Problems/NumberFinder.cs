using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class NumberFinder
    {
        public void FindNumbers()
        {
            bool isFirst = true;
            for (int num = 2000; num <= 3200; num++)
            {
                if (num % 7 == 0 && num % 5 != 0)
                {
                    if (!isFirst)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(num);
                    isFirst = false;
                }
                Console.WriteLine();
            }
        }
    }
}
