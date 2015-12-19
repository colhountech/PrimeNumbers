using System;
using System.Collections.Generic;
using System.Numerics;

public static class PrimeHelpers
{ 
    public static bool IsPrime(this BigInteger candidate)
    {
        BigInteger sqrt = candidate.Sqrt();
        Console.Write("sqrt = {0:n0}\r", sqrt);

        for (BigInteger i = 2; i < sqrt; i++)
        {
            if (candidate % i == 0)
            {
                return false;
            }

        }
        return true;
    }
    /*
    http://stackoverflow.com/questions/3432412/calculate-square-root-of-a-biginteger-system-numerics-biginteger
    from 
    http://stackoverflow.com/questions/2685524/check-if-biginteger-is-not-a-perfect-square
    baseon Heron's method
    https://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Babylonian_method
    */
    public static BigInteger Sqrt(this BigInteger n)
    {
        if (n == 0) return 0;

        

        if (n > 0)
        {
            if (n < long.MaxValue)
            {
                return (BigInteger)Math.Sqrt((long)n);
            }

            int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
            BigInteger root = BigInteger.One << (bitLength >> 1);
            while (!isSqrt(n, root))
            {
                root += n / root;
                root >>= 1;
            }
            return root;
        }
        throw new ArithmeticException("NaN");
    }

    private static Boolean isSqrt(BigInteger n, BigInteger root)
    {
        BigInteger lowerBound = root * root;
        BigInteger upperBound = (root + 1) * (root + 1);

        return (n >= lowerBound && n < upperBound);
    }
}
