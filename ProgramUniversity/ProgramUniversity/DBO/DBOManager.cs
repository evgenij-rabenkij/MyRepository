using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOManager
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDInstitute { get; set; }
        public int Roomnumber { get; set; }

        public DBOManager()
        {
            
        }

        public DBOManager(string firstname, string lastname, int age, int roomnumber, int idInstitute)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDInstitute = idInstitute;
            Roomnumber = roomnumber;
        }

        public override string ToString()
        {
            return " " + Firstname + "  " + Lastname + " "+Age+" "+Roomnumber;
        }
    }
}
