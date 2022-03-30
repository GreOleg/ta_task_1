using System;
using System.Data.OleDb;
using System.Linq;
using Dapper;

namespace ta_task_1.TestDataAccess
{
    class ExcelDataAccess
    {
        public static string TestDataFileConnection()
        {
            //var fileName = @"C:\Users\ahresik\Documents\mentoring-tasks-project\ta_task_1\TestDataAccess\TestData.xlsx";
            var fileName = Environment.GetEnvironmentVariable("PATH");
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return con;
        }
        
        public static UserData GetTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("SELECT * FROM [Sheet1$] WHERE key='{0}'", keyName);
                var value = connection.Query<UserData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
