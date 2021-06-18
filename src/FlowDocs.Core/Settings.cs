using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FlowDocs.Core
{
    public class Settings
    {
        public string CosmosURI { get; set; }
            = "https://localhost:8081";
        public string CosmosKey { get; set; }
            = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        public string CosmosDbName { get; set; }
            = "FlowDocs";

        public async Task SaveAsync()
        {
            var file = appSettingsFile();
            var json = JsonConvert.SerializeObject(this);
            await File.WriteAllTextAsync(file, json);
        }
        public void Save()
        {
            var file = appSettingsFile();
            var json = JsonConvert.SerializeObject(this);
            File.WriteAllText(file, json);
        }

        static string appSettingsFolder()
        {
            var appSettings = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appSettings, "FlowDocs");
        }
        static string appSettingsFile()
        {
            var appsettingsFolder = appSettingsFolder();

            if(Directory.Exists(appsettingsFolder) == false)
                Directory.CreateDirectory(appsettingsFolder);

            return Path.Combine(appsettingsFolder, "appsettings.json");
        }
        public static Settings Get()
        {
            var file = appSettingsFile();

            if (File.Exists(file) == false)
            {
                return null;
            }
            else
            {
                var json = File.ReadAllText(file);
                return JsonConvert.DeserializeObject<Settings>(json);
            }
        }
    }
}
