using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ta_task_1.Helper
{
    class Generaters
    {
        public static string GenerateRandomString(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(ch);
            }
            return lowerCase ? stringBuilder.ToString().ToLower() : stringBuilder.ToString();
        }
        public static string GenerateRandomEmail(string nameDomen, int size = 10)
        {
            return $"{GenerateRandomString(size)}{nameDomen}";
        }
    }
}
