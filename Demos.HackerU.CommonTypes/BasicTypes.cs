using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public class BasicTypes
    {
        public static void Run()
        {
            TestNumeric();
            Console.WriteLine();
            TestArray();
            Console.WriteLine();
            TestReadToArray();
            TestDynamicArray();
        }

        private static void TestDynamicArray()
        {
            var arrNumbers = new List<int>();
            arrNumbers.Add(10);
            arrNumbers.Add(100);
            arrNumbers.Add(454);
            arrNumbers.Remove(10);
            for (int i = 0; i < 100; i++)
            {
                arrNumbers.Add(i * 5 + 100);
            }
            for (int i = 0; i < arrNumbers.Count; i++)
            {
                Console.WriteLine($"{i}:{arrNumbers[i]}");
            }
            arrNumbers.RemoveAt(arrNumbers.Count - 1);
            Console.WriteLine(arrNumbers[^1]);
        }

        private static void TestReadToArray()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Input a number.");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                Console.WriteLine($"{i}:{arr[i]}");
            }
            int avg = sum / arr.Length;
            Console.WriteLine(avg);
        }

        private static void TestArray()
        {
            int[] numbers = new int[10];
            numbers[0] = -3;
            numbers[1] = 10;
            for (int i = 2; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i-1]+5;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}:{numbers[i]}");
            }
        }

        private static void TestNumeric()
        {
            int x = 10;
            int y = 100;
            int z = x + y;
            Console.WriteLine($"x={x},y={y},z={z} ");

            double d1 = 5.75;
            double d2 = 5.75;
            d1++;
            d1 += 6f;
            d1 += d2;
            Console.WriteLine($"d1={d1}");

            float f = 10.34f;
            Console.WriteLine($"f={f}");

            bool isEqual = (d1 == d2);
            Console.WriteLine($"isEqual d1=d2 ---> {isEqual}");

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            string dt2 = DateTime.Now.ToLongTimeString();
            Console.WriteLine(dt2);

            string dt3 = DateTime.Now.ToLongDateString();
            Console.WriteLine(dt3);

            DateTime dt4 = DateTime.Now.AddHours(48);
            Console.WriteLine(dt4);

            var y2 = 2;
            var x2 = true;
            Console.WriteLine($"y2 is int {y2}");


        }
    }
}
