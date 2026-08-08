namespace Sah_Kit_Web
{
    public class Visit
    {
        public string Name_Client {get; set;}
        public DateTime Date {get; set;} = DateTime.Now;
        public Skill Category {get; set;}
        public bool Fixed {get; set;}
        public double DurationKwartier {get; set;}
        public string Notes {get; set;}

        public Visit(string name, Skill category, bool fixed_, double duration, string notes)
        {
            Name_Client = name;
            Category = category;
            Fixed = fixed_;
            DurationKwartier = duration;
            Notes = notes;
        }
        public Visit() {}
    }
}