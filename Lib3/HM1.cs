namespace HomeWork
{
    public class HM1
    {
        /// <summary>
        /// lesson 2 homework
        /// </summary>
        public static void Run()
        {
            Console.WriteLine(HM1.CheckLowerUpperEquals("AabB", "aAbb") ? "equal" : "not equal");
            Console.WriteLine(HM1.CheckLowerUpperEquals("AabBX", "aAbb") ? "equal" : "not equal");
            Console.WriteLine(HM1.CheckLowerUpperEquals("", "") ? "equal" : "not equal");
            Console.WriteLine(HM1.CheckLowerUpperEquals(null, "") ? "equal" : "not equal");


            Console.WriteLine("name:arni     email:gmail     res:" + HM1.ToEmail("arni", "gmail"));
            Console.WriteLine("name:     email:gmail     res:" + HM1.ToEmail("", "gmail"));
            Console.WriteLine("name:arni._     email:      res:" + HM1.ToEmail("arni._", ""));
            Console.WriteLine("name:arniizhack1     email:gmail      res:" + HM1.ToEmail("arniizhack1", "gmail"));
        }
        /// <summary>
        /// check if 2 strings equal, ignoring case sensetive
        /// </summary>
        /// <param name="txt1">1st string</param>
        /// <param name="txt2">2nd string</param>
        /// <returns></returns>
        public static bool CheckLowerUpperEquals(string txt1, string txt2)
        {
            if (txt1 == null && txt2 == null)
                return true;
            else if ((txt1 == null && txt2 != null) || (txt1 != null && txt2 == null))
                return false;
            else if (txt1.ToLower() == txt2.ToLower())
                return true;
            else
                return false;
        }
        public static string ToEmail(string name, string email)
        {
            string resOrError = "";
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
                resOrError += "*User name or email is empty";
            if (name.Length > 10)
                resOrError += "*user name can't have more then 10 letters";
            if (name.Contains('.') || name.Contains('_'))
                resOrError += "*user name can't contain '.' or '_'";
            if (resOrError == "")
                resOrError = $"{name}@{email}.com";

            return resOrError;
        }
    }
}