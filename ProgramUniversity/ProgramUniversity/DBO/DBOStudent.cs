using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOStudent
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDFaculty { get; set; }
        public double AverageMark { get; set; }

        public DBOStudent()
        {
            
        }
        public DBOStudent(string firstname, string lastname, int age, int idFaculty, double averageMark)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDFaculty = idFaculty;
            AverageMark = averageMark;
        }

        public override string ToString()
        {
            return Firstname + "  " + Lastname + " " + Age + " " + AverageMark + " "+ IDFaculty;
        }
    }
}
