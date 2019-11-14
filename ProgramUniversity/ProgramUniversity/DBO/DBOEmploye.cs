using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOEmploye
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDInstitute { get; set; }
        public int Wage { get; set; }

        public DBOEmploye()
        {
        }

        public DBOEmploye(string firstname, string lastname, int age, int idInstitute, int wage)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDInstitute = idInstitute;
            Wage = wage;
        }
        public override string ToString()
        {
            return Firstname + "  " + Lastname + " " + Age + " " + Wage;
        }
    }
}
