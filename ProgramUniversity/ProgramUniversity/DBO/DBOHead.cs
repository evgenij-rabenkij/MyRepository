using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOHead
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDService { get; set; }
        public int Experience { get; set; }

        public DBOHead()
        {
            
        }
        public DBOHead(string firstname, string lastname,  int age, int experience, int idService)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDService = idService;
            Experience = experience;
        }

        public override string ToString()
        {
            return " " + Firstname + "  " + Lastname + " "+ Age+" "+" "+Experience;
        }
    }
}
