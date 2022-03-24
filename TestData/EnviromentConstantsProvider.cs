using System.IO;
using System.Text.Json;

namespace ta_task_1.TestData
{
    public class EnviromentConstantsProvider
    {
        private const string _nameJsonFile = "userData.json";
        public void Provide(out Person enviromentConstantsObject)
        {
            string objectJsonFile = File.ReadAllText(_nameJsonFile);

            enviromentConstantsObject = JsonSerializer.Deserialize<Person>(objectJsonFile);
        }
    }
}
