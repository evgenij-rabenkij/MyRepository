using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOAutoChief
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDMotorcade { get; set; }

        public DBOAutoChief()
        {
            
        }

        public DBOAutoChief(string firstname, string lastname, int age, int idMotorcade)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDMotorcade = idMotorcade;
        }
        public override string ToString()
        {
            return " " + Firstname + "  " + Lastname + " " + Age + " " + " " + IDMotorcade;
        }
    }
}
