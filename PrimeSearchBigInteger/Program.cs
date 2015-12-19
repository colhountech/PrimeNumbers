using System;
using System.Diagnostics;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {


 //       BigInteger startAt = 1024 * 1024 * 1024 + 3;
 //       BigInteger maxValue = startAt  * 2;

        BigInteger startAt = long.MaxValue - 24;
        BigInteger maxValue = startAt + 1000;
        Stopwatch watch = Stopwatch.StartNew();

        for (BigInteger candidate = startAt; candidate < maxValue; candidate++)
        {
            if (candidate.IsPrime())
            {
                Console.WriteLine("Found a new prime: {0:n0}. Time Taken = {1:n0} msec", candidate, watch.ElapsedMilliseconds);
                watch.Restart();
            }
        }
    }
}
