using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public static class ArrayUtils
    {
        public static List<int> GetSquares()
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            var squares = new List<int>();
            foreach (var n in numbers)
                squares.Add(n * n);
            return squares;
        }

        public static List<int> GetDoubled()
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            var doubled = new List<int>();
            foreach (var n in numbers)
                doubled.Add(n * 2);
            return doubled;
        }

        public static int CountDivisibleByThree()
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12 };
            int count = 0;
            foreach (var n in numbers)
                if (n % 3 == 0)
                    count++;
            return count;
        }

        public static void CountPositiveNegativeZero()
        {
            int[] nums = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            int pos = 0, neg = 0, zero = 0;
            foreach (var n in nums)
            {
                if (n > 0) pos++;
                else if (n < 0) neg++;
                else zero++;
            }
            Console.WriteLine($"Positiivseid: {pos}");
            Console.WriteLine($"Negatiivseid: {neg}");
            Console.WriteLine($"Nulle: {zero}");
        }

        public static void PrintAboveAverageAndDoWhile()
        {
            Random rnd = new Random();
            int[] numbers = new int[15];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(1, 101);

            double avg = numbers.Average();
            Console.WriteLine($"Keskmine: {avg:F2}");

            Console.WriteLine("Suuremad kui keskmine:");
            foreach (var n in numbers)
                if (n > avg) Console.Write(n + " ");

            Console.WriteLine("\n\nDo-while kuni < 10:");
            int j = 0;
            do
            {
                Console.Write(numbers[j] + " ");
                j++;
            } while (j < numbers.Length && numbers[j - 1] >= 10);
        }

        public static void FindLargestWithIndex()
        {
            int[] nums = { 12, 56, 78, 2, 90, 43, 88, 67 };
            int max = nums[0], index = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }
            Console.WriteLine($"Suurim arv: {max}");
            Console.WriteLine($"Selle indeks: {index}");
        }

        public static void CountEvenOdd()
        {
            Random rnd = new Random();
            var nums = new List<int>();
            for (int i = 0; i < 20; i++)
                nums.Add(rnd.Next(1, 51));

            int even = 0, odd = 0;
            foreach (var n in nums)
                if (n % 2 == 0) even++; else odd++;

            Console.WriteLine("Genereeritud arvud:");
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine($"\nPaarisarvud: {even}, Paaritud: {odd}");
        }
    }
}
