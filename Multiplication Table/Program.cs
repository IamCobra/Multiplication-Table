using System;

namespace Multiplication_Table
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table:");
            PrintMultiplicationTable(10);


            int[] TheBiggestNumberList = new int[] { 190, 291, 145, 209, 280, 200 };
            Console.WriteLine(BiggestNumber(TheBiggestNumberList));


            int[] threeIncreasingAdjacent = new int[] { 23, 48, 19, 20, 21, 45 };
            Console.WriteLine(ThreeIncreasingAdjacent(threeIncreasingAdjacent));


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
            return array.Max(x => x);
        }



        static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            if (numbers.Length < 3)
            {
                return false; // Vil return false frundet at der ikke er nok tal
            }

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1] + 1 && numbers[i - 1] == numbers[i - 2] + 1)
                {
                    return true; // Vil return true hvis den finder de 3 tal
                }
            }

            return false; // Vil return false, hvis det ikke blev fundet
        }



    }
}