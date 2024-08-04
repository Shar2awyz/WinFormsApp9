namespace Namespace9
{
    static class sharkawyz
    {
        static internal string[] nam;
        static internal string[] id;
        static internal string[] con;
        static internal string[] dep;




    }

    internal class dataa
    {
        internal string name;
        internal string id;
        internal string condition;
        internal string department;

        internal dataa(string n, string idd, string co, string dep)
        {

            name = n;
            id = idd;
            condition = co;
            department = dep;

        }

    }

    public class Patient
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Condition { get; set; }
        public string Department { get; set; }

        public Patient(string name, int id, string condition, string department)
        {
            Name = name;
            Id = id;
            Condition = condition;
            Department = department;

        }

    }
}


 

