using System;

namespace ProgramUniversity
{
    [Serializable]
    public  class DBORector
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDUniversity { get; set; }
        public int YearOfJobStart { get; set; }

        public DBORector()
        {

        }
        public DBORector(string firstname, string lastname, int age, int yearOfJobStart, int idUniversity)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDUniversity = idUniversity;
            YearOfJobStart = yearOfJobStart;
        }

        public override string ToString()
        {
            return " " + Firstname + "  " + Lastname + " " + Age + " " + " " + YearOfJobStart;
        }
    }
}
