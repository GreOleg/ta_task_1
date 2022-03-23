using System;

namespace ta_task_1.PageObjects
{
    class Pages
    {
        public static string MainPage = Environment.GetEnvironmentVariable("BASE_URL");
        public static string MyAccountPage = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        public static string SummerDressesPage = "http://automationpractice.com/index.php?id_category=11&controller=category";
        public static string CartPage = "http://automationpractice.com/index.php?controller=order";
    }
}
