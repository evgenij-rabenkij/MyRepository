using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBODean
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDFaculty { get; set; }
        public string Degree { get; set; }

        public DBODean()
        {
          
        }

        public DBODean(string firstname, string lastname, string degree, int age, int idFaculty)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDFaculty = idFaculty;
            Degree = degree;
        }

        public override string ToString()
        {
            return Degree +" "+ Firstname + "  " + Lastname + " " + Age + ".";
        }
    }
}
