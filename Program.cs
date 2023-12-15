using System;

namespace mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            numbers[5] = 20;
            numbers[6] = 45;
            numbers[7] = 88;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine(total.ToString());
        }
    }
}