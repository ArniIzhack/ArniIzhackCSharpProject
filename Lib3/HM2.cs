using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.cs
{
    public class HM2
    {
        public static void Run() {
            string[] stringArray = { "Arni", "is", "Izhack", "is", "doing", "homework" };
            Console.WriteLine("exersize 1:");
            Console.WriteLine(GetStringArrayAndReturnTheLongest(stringArray));
            Console.WriteLine();
            Console.WriteLine("exersize 2:");
            int[] intarray = { 1, 23, 12, 4, 5, 6, 7, 8, 22 };
            Console.WriteLine(GetNumbersArrayAndPrint(intarray));
            Console.WriteLine();
            Console.WriteLine("exersize 3:");
            Console.WriteLine($"the resoult is: {Calculate()}");
            Console.WriteLine();
            Console.WriteLine("exersize 4:");
            var a =DitanceFromAvg(intarray,3);
            for(int i = 0; i < a.Count; i++)
            {
                if(i==0)
                Console.WriteLine(a[i].ToString());
            }
            Console.WriteLine();
            Console.WriteLine("exersize 5:");
            ReciveStringsPutInArrayAndDisplayAsUppercase();
            Console.WriteLine();
            Console.WriteLine("exersize 6:");
            SortNumbers(intarray);
            Console.WriteLine();
            Console.WriteLine("exersize 7:");
            ReciveIntsAndPutInArray();
            Console.WriteLine();
            Console.WriteLine("exersize 8:");
            var stringList = new List<string>();
            for(int i = 0; i < stringArray.Length; i++)
            {
                stringList.Add(stringArray[i]);
            }
            RemoveFromList(stringList, "is");
            for(int i = 0;i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }
            Console.WriteLine("exersize 9:");
            var decimalList = new List<decimal>();
            for(int i = 0;i<intarray.Length; i++)
            {
                decimalList.Add(intarray[i]);
            }
            var belowAvg = RomoveAndPrintValuesAboveAvg(decimalList);
            for(int i = 0; i <= belowAvg.Count; i++)
            {
                Console.WriteLine($"{belowAvg[i]} is blow the avrage.");
            }
        }

        private static List<decimal> RomoveAndPrintValuesAboveAvg(List<decimal> decimalList)
        {
            decimal sum = 0;
            for(int i = 0; i < decimalList.Count; i++)
            {
                sum+= decimalList[i];
            }
            decimal avg = sum/(decimalList.Count);
            var aboveAvg = new List<decimal>();
            for(int i = 0; i < decimalList.Count; i++)
            {
                if (decimalList[i] > avg)
                {
                    aboveAvg.Add(decimalList[i]);
                    decimalList.Remove(decimalList[i]);
                    i--;
                }
            }
            for(int i = 0; i < aboveAvg.Count; i++)
            {
                Console.WriteLine($"{aboveAvg[i]} is above the avrage");
            }
            return decimalList;
        }

        public static List<string> RemoveFromList(List<string> strings, string valuetoremove)
        {
            bool isThereValueToRemove;

            do
            {
                isThereValueToRemove = strings.Remove(valuetoremove);
            }while (isThereValueToRemove);
            return strings;
        }

        private static void ReciveIntsAndPutInArray()
        {
            var inputsFromUser = new List<int>();
            string currentInput;
            int num;
            do
            {
                Console.Write("Input a number:");
                currentInput = Console.ReadLine();
                if (currentInput == "exit")
                {
                    for (int i = 0; i < inputsFromUser.Count; i++)
                    {
                        if (i == 0)
                        Console.Write($"{inputsFromUser[i]}, ");
                    }
                }
                else
                {
                    num = int.Parse(currentInput);
                    if (num >= 0 && num <= 100)
                        inputsFromUser.Add(num);
                    else
                    {
                        do
                        {
                            Console.Write("Number must be between 0 and 100, try again:");
                            currentInput = Console.ReadLine();

                            if (currentInput == "exit")
                            {
                                for (int i = 0; i < inputsFromUser.Count; i++)
                                {
                                    if (i == 0)
                                    Console.Write($"{inputsFromUser[i]}, ");
                                }
                            }
                            else
                            {
                                num = int.Parse(currentInput);
                                if (num >= 0 && num <= 100)
                                    inputsFromUser.Add(num);
                            }
                        } while ((num < 0 || num > 100)&& currentInput != "exit");
                    }
                }
            } while (currentInput != "exit");
        }

        private static void SortNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                Console.WriteLine(numbers[i]);
            }
        }

        private static void ReciveStringsPutInArrayAndDisplayAsUppercase()
        {
            List<string> inputsFromUser = new List<string>();
            string currentInput;
            do
            {
                Console.Write("Input a string:");
                currentInput = Console.ReadLine();
                if(currentInput !="exit")
                    inputsFromUser.Add(currentInput);
            }while(currentInput !="exit");
            for(int i = 0;i < inputsFromUser.Count; i++)
            {
                if(i==0)
                Console.WriteLine(inputsFromUser[i].ToUpper());
            }
        }

        private static List<string> DitanceFromAvg(int[] numbers,int distanceAvg)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int avg = sum / numbers.Length;
            List<string> DistanceFromAvg = new List<string>();
            int distance;
            for (int i = 0;i<numbers.Length;i++)
            {
                if (avg > numbers[i])
                    distance = avg - numbers[i];
                else
                    distance = numbers[i] - avg;
                if(distance < distanceAvg)
                    DistanceFromAvg.Add($"{numbers[i]} distance from {avg} is {distance}");
            }
            return DistanceFromAvg;
        }

        private static int Calculate()
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the operator: ");
            string oper = Console.ReadLine();

            if (oper== "+")
                return num1 + num2;
            else if(oper== "-")
                return num1 - num2;
            else if (oper=="*")
                return num1 * num2;
            else 
                return num1 / num2;
        }

        private static string GetNumbersArrayAndPrint(int[] intarray)
        {
            string msg = "";
            for (int i = 0; i < intarray.Length; i++)
            {
                if (i == intarray.Length-1)
                    msg += $"{intarray[i]}.";
                else
                    msg += $"{intarray[i]}_";
            }
            return msg;
        }

        private static string GetStringArrayAndReturnTheLongest(string[] strarr)
        {
            string longestString="";
            for (int i = 0; i < strarr.Length; i++)
            {
                if (longestString.Length < strarr[i].Length)
                {
                    longestString = strarr[i];
                }
            }
            return longestString;

        }
    }
}
