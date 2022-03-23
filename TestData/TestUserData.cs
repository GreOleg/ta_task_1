using Faker.Extensions;
using System.Collections.Generic;

namespace ta_task_1.TestData
{
    class TestUserData
    {
        //public static string domenForUserEmail { get; set; } = "@example.com";
        //public static string SearchKeyword { get; set; } = "dress";

        public static Dictionary<string, string> userData = new Dictionary<string, string>()
        {
            ["firstNameUser"] = Faker.Name.First(),
            ["lastNameUser"] = Faker.Name.Last(),
            ["passwordUser"] = StringExtensions.Numerify("######"),
            ["addressUser"] = Faker.Address.StreetAddress(),
            ["cityUser"] = Faker.Address.City(),
            ["stateUser"] = Faker.RandomNumber.Next(1, 50).ToString(),
            ["postCodeUser"] = StringExtensions.Numerify("#####"),
            ["mobilePhoneUser"] = StringExtensions.Numerify("############"),
        };
    }
}
