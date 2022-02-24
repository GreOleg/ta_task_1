using System;
using System.Text;

namespace ta_task_1.TestData
{
    class TestUserData
    {
        //public static string domenForUserEmail { get; set; } = "@example.com";
        public static string FirstNameUser { get; set; } = "Ivan";
        public static string LastNameUser { get; set; } = "Ivanov";
        public static string PasswordUser { get; set; } = "11111";
        public static string DayBirthUser { get; set; } = "24";
        public static string MonthBirthUser { get; set; } = "9";
        public static string YearBirthUser { get; set; } = "1993";
        public static string AddressUser { get; set; } = "123 Main Street East";
        public static string CityUser { get; set; } = "Chicago";
        public static string StateUser { get; set; } = "13";
        public static string PostCodeUser { get; set; } = "20521";
        public static string MobilePhoneUser { get; set; } = "+375333333333";
        public static string SearchKeyword { get; set; } = "dress";

        public static string GenerateRandomString(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder =  new StringBuilder();
            Random random = new Random();

            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(ch);
            }

            if(lowerCase)
            {
                return stringBuilder.ToString().ToLower();
            }

            return stringBuilder.ToString();
        }

        public static string GenerateRandomEmail(string nameDomen, int size = 10)
        {
            string randomEmail = GenerateRandomString(size) + nameDomen;

            return randomEmail;
        }
    }
}
