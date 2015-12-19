using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrimeSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            long candidate = long.MaxValue - 24;


            long startAt = 2;

            bool isPrime = true;

            Stopwatch watch = Stopwatch.StartNew();

            for (long i = startAt; i < Math.Sqrt(candidate); i++)
            {
                if (candidate % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.Write("Found a new prime: {0:n0}. Time Taken = {1:n0} msec", candidate, watch.ElapsedMilliseconds);
                watch.Restart();
            }
        }

    } // class



}
