using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n) {
            if (n < 0)
                throw new ArgumentException("Factorial is undefined for negative numbers.");
            if (n == 0)
                return 1;
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items.Length == 0)
                return string.Empty;
            if (items.Length == 1)
                return items[0];
            if (items.Length == 2)
                return $"{items[0]} and {items[1]}";

            string result = string.Join(", ", items.Take(items.Length - 1));
            result += $" and {items.Last()}";
            return result;
        }

    }
}