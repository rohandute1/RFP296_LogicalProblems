using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP296_Logical_Problems
{
    internal class CountExecutionTime
    {
        public void ExecutionTimeCounter()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            stopwatch.Stop();

            long elapsedTimeMilliseconds = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Execution time: {elapsedTimeMilliseconds} milliseconds");
        }
    }
}
