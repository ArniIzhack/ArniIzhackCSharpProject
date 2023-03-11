using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork.cs
{
    public class HM3
    {
        public static void Run()
        {
            //Exersize1();
           // Exersize2();
            Exersize3();
        }

        private static void Exersize3()
        {
            Console.Clear();
            Console.WriteLine("exersize 3:");
            CountriesNamesManager();
            Console.ReadLine();
        }

        private static void CountriesNamesManager()
        {
            bool endProgram = false;
            var CountriesList = new List<string>();
            do {
                Menu();
                string task = Console.ReadLine();
                switch (task)
                {
                    case "a": case "A":
                        Console.Write("Type in the country name you wish to add: ");
                        string country = Console.ReadLine();
                        string editedCountry = country[0].ToString().ToUpper() + country.Substring(1).ToLower();
                        Console.WriteLine();
                        if (CountriesList.Contains(editedCountry))
                            Console.WriteLine($"Error! {editedCountry} is already in the list.");
                        else
                        {
                            CountriesList.Add(editedCountry);
                            Console.WriteLine($"{editedCountry} was succesfully added to the list.");
                        }
                        break;
                    case "b": case "B":
                        Console.Write("Type in the country name you wish to remove: ");
                        country = Console.ReadLine();
                        editedCountry = country[0].ToString().ToUpper() + country.Substring(1).ToLower();
                        Console.WriteLine();
                        if (CountriesList.Contains(editedCountry))
                        { 
                            CountriesList.Remove(editedCountry);
                            Console.WriteLine($"{editedCountry} was succesfully removed to the list.");
                        }
                        else
                            Console.WriteLine($"Error! {editedCountry} is not in the list.");
                        break;
                    case "c": case "C":
                        Console.WriteLine("Type in the first letter of the country name you wish to find: ");
                        char firstLetter = char.ToUpper(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                        var matchingCountries = CountriesList.FindAll(i => i.StartsWith(firstLetter));
                        string countriesToPrint = "";
                        foreach(string i in matchingCountries) { countriesToPrint += i+", "; }
                        if (countriesToPrint.Length > 0)
                        {
                            countriesToPrint = countriesToPrint.TrimEnd();
                            Console.WriteLine(countriesToPrint);
                        }else
                        { Console.WriteLine($"There are no countries that start with the letter {firstLetter}"); }
                        break;
                    case "d": case "D":
                        Console.WriteLine();
                        for(int i = 0; i < CountriesList.Count; i++)
                        {
                            Console.WriteLine($"{1}. {CountriesList[i]}.");
                        }
                        break;
                    case "e": case "E":
                        Console.WriteLine();
                        Console.WriteLine("The program is over.");
                        endProgram = true;
                        break;
                    default: 
                        Console.WriteLine("You typed on a wrong key.");
                        break;
                }
            } while (!endProgram);
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("A. Add a new country. (type in A/a)");
            Console.WriteLine("b. Remove a country. (type in B/b)");
            Console.WriteLine("C. Search for a country. (type in C/c)");
            Console.WriteLine("D. Print list of all the countries. (type in D/d)");
            Console.WriteLine("E. End program. (type in E/e)");
        }

        private static void Exersize2()
        {
            Console.Clear();
            Console.WriteLine("exersize 2:");
            CreateList();
            Console.ReadLine();

        }
        private static void CreateList()
        {
            var studentsgrades = new List<object>();
            var grades = new List<int>();
            bool addMore = true;
            do
            {
                string name = "";
                do
                {
                    Console.Write("Enter student name: ");
                    name = Console.ReadLine();

                } while (name.Length == 0);
                studentsgrades.Add(name);
                int grade;
                do
                {
                    grade = GetGrade();
                } while (grade == -1);
                studentsgrades.Add(grade);
                grades.Add(Convert.ToInt32(grade));
                Console.Write("If you wish to countinue click on ENTER button, If you wish to finish type in end and then click on ENTER button.");
                string command = Console.ReadLine();
                if(command=="end")
                    addMore = false;
            } while (addMore);
            for(int i = 0; i < studentsgrades.Count; i++)
            {
                if(i%2==0)
                    Console.Write($"{studentsgrades[i]}: ");
                else
                    Console.WriteLine(studentsgrades[i]);
            }
            int sum = 0;
            grades.ForEach(x => sum += x);
            Console.WriteLine(sum/grades.Count);
            int bestScore = grades.Max();
            int indexOfBestScore = grades.IndexOf(bestScore);
            Console.WriteLine($"The studenst with the best score is: {studentsgrades[indexOfBestScore*2]}.");
        }
        private static int GetGrade()
        {
            Console.Write("Enter student grade: ");
            string gradeStr = Console.ReadLine();
            if (int.TryParse(gradeStr, out int grade))
            {
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("ERROR! grade must be a number between 0 and 100.");
                    grade = -1;
                }
            }
            else
            {
                Console.WriteLine("ERROR! grade must be a number between 0 and 100.");
                grade = -1;
            }
            return grade;
        }
        private static void Exersize1()
        {
            Console.WriteLine("exesize 1:");
            Console.WriteLine("example 1.1:");
            DrawRectangleBorder(3, 10, '*', false);
            Console.WriteLine("example 1.2:");
            DrawRectangleBorder(3, 10, '*', true);
            Console.WriteLine("example 1.3:");
            DrawRectangleBorder(3, 2, '*', true);
            Console.ReadLine();
        }
        private static void DrawRectangleBorder(int heigth, int width, char tav, bool isFull)
        {
            if (heigth <= 2 || width <= 2)
            {
                Console.WriteLine("Heigth and width must be larger then 2, enter new heigth and width.");
                Console.Write("Heigth: ");
                string heigthstr = Console.ReadLine();
                int.TryParse(heigthstr, out heigth);
                Console.Write("width: ");
                string widthstr = Console.ReadLine();
                int.TryParse(widthstr, out width);
                DrawRectangleBorder(heigth, width, tav, isFull);
            }
            else
            {
                for (int i = 0; i < heigth; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (isFull || (j == 0 || i == 0 || i == heigth - 1 || j == width - 1))
                            Console.Write(tav);
                        else
                            Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}