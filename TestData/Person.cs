using Faker.Extensions;

namespace ta_task_1.TestData
{
    class Person
    {
        public string emailUser { get; set; }
        public string firstNameUser { get; set; }
        public string lastNameUser { get; set; }
        public string passwordUser { get; set; }
        public string addressUser { get; set; }
        public string cityUser { get; set; }
        public string stateUser { get; set; }
        public string postCodeUser { get; set; }
        public string mobilePhoneUser { get; set; }

        public Person()
        {
            this.emailUser = Faker.Internet.Email();
            this.firstNameUser = Faker.Name.First();
            this.lastNameUser = Faker.Name.Last();
            this.passwordUser = StringExtensions.Numerify("######");
            this.addressUser = Faker.Address.StreetAddress();
            this.cityUser = Faker.Address.City();
            this.stateUser = Faker.RandomNumber.Next(1, 50).ToString();
            this.postCodeUser = StringExtensions.Numerify("#####");
            this.mobilePhoneUser = StringExtensions.Numerify("############");
        }
    }
}