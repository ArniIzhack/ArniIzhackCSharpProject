using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.CommonTypes
{
    public class ArraysAndLoops
    {
        public static void Run()
        {
            List();
            PrintRectangle(3, 4, 'g');
            PrintRectangleErea(9,5, 'g');
            ShowMenu();



            Console.ReadLine();
        }
        private static void List () {
            List<int?> l = new List<int?>();
            l.Add(1);
            l.Add(10);
            l.Add(20);
            l.Insert(1, 1000);
            l.RemoveAt(2);
            l.Remove(1000);
            
            var l2 = new List<int>() { 10, 20, 30 };
            var foundItem = l2.Find(n => n > 10);
            var foundIndex = l2.FindIndex(n => n > 90);
            if (foundIndex != -1) { Console.WriteLine(foundIndex); }
            foreach (int numItem in l2)
            {
                Console.WriteLine(numItem);
            }
            l2.ForEach(n => { Console.WriteLine(n); });
            List<int> subList = l2.FindAll(n => n > 10);
        }
        private static void PrintRectangle (int width, int height, char tav)
        {
            for (int i = 0; i < height; i++) { 
                for (int j = 0; j < width; j++)
                {
                    Console.Write(tav);
                }
                Console.WriteLine();
            }
        }
        private static void PrintRectangleErea(int width, int height, char tav)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0||j==0||i==height-1||j==width-1)
                        Console.Write(tav);
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        private static bool MainMenu()
        {
            //Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) operation 1");
            Console.WriteLine("2) operation 2");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    operation1();
                    return true;
                case "2":
                    operation2();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static void operation2()
        {
            Console.WriteLine("execute operation 2");
        }

        private static void operation1()
        {
            Console.WriteLine("execute operation 1");
        }

        public static void ShowMenu()
        {
            bool isContinue = true;
            while (isContinue)
            {
                isContinue = MainMenu();
            }
        }
    }
}
