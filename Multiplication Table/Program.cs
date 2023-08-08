using System;

namespace Multiplication_Table
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Tabe:");
            PrintMultiplicationTable(10);


            int[] TheBiggestNumberList = new int[] { 190, 291, 145, 209, 280, 200 };
            Console.WriteLine(BiggestNumber(TheBiggestNumberList));
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





    }
}