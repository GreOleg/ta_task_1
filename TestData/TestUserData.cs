using System;
using System.Collections.Generic;

namespace ta_task_1.TestData
{
    class TestUserData
    {
        public static string domenForUserEmail { get; set; } = "@example.com";
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
