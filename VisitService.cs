using System.Text.Json;

namespace Sah_Kit_Web
{
    public class VisitService
    {
        private readonly string _path = Path.Combine
        (Environment.GetFolderPath
        (Environment.SpecialFolder.ApplicationData), "sah_visits.json");

        public List<Visit> visits {get; set;} = new();

        public void SaveVisits()
        {
            string json = JsonSerializer.Serialize(visits);
            File.WriteAllText(_path, json);
        }

        public void LoadVisits()
        {
            try
            {
                if (File.Exists(_path))
                {
                    string json = File.ReadAllText(_path);
                    visits = JsonSerializer.Deserialize<List<Visit>>(json) ?? new();
                }
            }
            catch { throw new FileLoadException(); }
        }
    }
}