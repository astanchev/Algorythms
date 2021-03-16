﻿namespace _01_Fibonacci
{
    using System;    
    using System.Numerics;

    class Fibonacci
    {
        private static BigInteger[] results;

        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());

            results = new BigInteger[n + 1];

            FindFibbonacci(n);

            PrintFibonacci(n);
        }

        private static void PrintFibonacci(long n)
        {
            Console.WriteLine(results[n]);
        }

        private static BigInteger FindFibbonacci(long n)
        {
            if (results[n] != 0)
            {
                return results[n];
            }

            if (n == 0)
            {
                results[n] = 0;
                return 0;
            }

            if (n == 1)
            {
                results[n] = 1;
                return 1;
            }

            results[n] = FindFibbonacci(n - 1) + FindFibbonacci(n - 2);

            return results[n];
        }
    }
}
