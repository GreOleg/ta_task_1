using System;
using System.Collections.Generic;

namespace ta_task_1.TestData
{
    class TestUserData
    {
        public static string domenForUserEmail { get; set; } = "@example.com";
        //public static string FirstNameUser { get; set; } = "Ivan";
        //public static string LastNameUser { get; set; } = "Ivanov";
        //public static string PasswordUser { get; set; } = "11111";
        //public static string DayBirthUser { get; set; } = "24";
        //public static string MonthBirthUser { get; set; } = "9";
        //public static string YearBirthUser { get; set; } = "1993";
        //public static string AddressUser { get; set; } = "123 Main Street East";
        //public static string CityUser { get; set; } = "Chicago";
        //public static string StateUser { get; set; } = "13";
        //public static string PostCodeUser { get; set; } = "20521";
        //public static string MobilePhoneUser { get; set; } = "+375333333333";
        public static string SearchKeyword { get; set; } = "dress";

        public static Dictionary<string, string> userData = new Dictionary<string, string>()
        {
            ["firstNameUser"] = "Ivan",
            ["lastNameUser"] = "Ivanov",
            ["passwordUser"] = "11111",
            ["dayBirthUser"] = "24",
            ["monthBirthUser"] = "9",
            ["yearBirthUser"] = "1993",
            ["addressUser"] = "123 Main Street East",
            ["cityUser"] = "Chicago",
            ["stateUser"] = "13",
            ["postCodeUser"] = "20521",
            ["mobilePhoneUser"] = "+375333333333",
        };
    }
}
