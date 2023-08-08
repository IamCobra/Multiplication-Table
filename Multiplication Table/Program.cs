using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiplication_Table
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table:");
            PrintMultiplicationTable(10);

            int[] biggestNumberList = { 190, 291, 145, 209, 280, 200 };
            Console.WriteLine(BiggestNumber(biggestNumberList));

            int[] threeIncreasingAdjacent = { 23, 48, 19, 20, 21, 45 };
            Console.WriteLine(ThreeIncreasingAdjacent(threeIncreasingAdjacent));

            List<int> primeNumbers = PrimeNumbers(30);
            Console.WriteLine("Prime numbers:");
            Console.WriteLine(string.Join(" ", primeNumbers));
        }

        public static void PrintMultiplicationTable(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    int product = i * j;
                    Console.Write($"{product,4}");
                }
                Console.WriteLine();
            }
        }

        static int BiggestNumber(int[] array)
        {
            return array.Max();
        }

        static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            if (numbers.Length < 3)
            {
                return false;
            }

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1 && numbers[i - 1] == numbers[i - 2] + 1)
                {
                    return true;
                }
            }

            return false;
        }

        static List<int> PrimeNumbers(int number)
        {
            List<int> primeNumbers = new List<int>();

            for (int n = 1; n <= number; n++)
            {
                int a = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    primeNumbers.Add(n);
                }
            }

            return primeNumbers;
        }
    }
}
