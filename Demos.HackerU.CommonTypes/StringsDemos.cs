namespace Demos.HackerU.CommonTypes
{
    public class StringsDemos
    {
        /// <summary>
        /// lesson 2
        /// </summary>
        public static void Run()
        {
            TestString();
            Lab1();
            Lab2("abc", "def");
            string res = Lab3("abc", "DEF");
            Console.WriteLine(res);
            Lab4("user123", "pa$$word");
            Lab5("user123", "pa$$word");
        }
        public static void TestString()
        {
            string s1 = "string.";
            s1 += " i can add to string";
            Console.WriteLine(s1);

            string s2 = "11111";
            string s3 = "22222";
            string s4 = s2 + s3;
            Console.WriteLine(s4);

            string s5 = "aBcD";
            string s6 = s5.ToLower();
            Console.WriteLine(s6);
            Console.WriteLine(s6.ToUpper());

            bool isEmpty = string.IsNullOrEmpty(s6);
            if (!isEmpty)
            {
                Console.WriteLine("s6 is not empty");
            }

            string s7 = "";
            if (string.IsNullOrEmpty(s7))
            {
                Console.WriteLine("s7 is empty");
            }

            string s8 = "123";
            string s9 = "456";
            string txt = $"s8 is {s8} and s9 is {s9}";

        }
        /// <summary>
        /// string concat practice
        /// </summary>
        public static void Lab1()
        {
            string s1 = "abc";
            string s2 = "ABC";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s1 + s2);
            string s3 = s1 + s2;
            Console.WriteLine(s3.ToLower());
            Console.WriteLine(s3.ToUpper());
        }

        public static void Lab2(string txt1, string txt2)
        {
            Console.WriteLine((txt1 + txt2).ToUpper());
        }

        public static string Lab3(string txt1, string txt2)
        {
            return (txt1 + txt2).ToLower();
        }

        public static bool Lab4(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                Console.WriteLine("Empty user name or password.");
                return false;
            }
            else if (user == "user123")
            {
                if (pass == "pa$$word")
                {
                    Console.WriteLine("currect data.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong password");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Wrong username");
                return false;
            }
        }
        public static bool Lab5(string currectUser, string currectPass)
        {
            Console.Write("Enter user name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Empty user name or password.");
                return false;
            }
            else if (userName == currectUser)
            {
                if (password == currectPass)
                {
                    Console.WriteLine("currect data.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong password");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Wrong username");
                return false;
            }
        }

    }
}