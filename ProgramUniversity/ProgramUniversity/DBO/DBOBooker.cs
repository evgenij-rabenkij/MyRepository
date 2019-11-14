using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOBooker
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int IDService { get; set; }
        public string Post { get; set; }

        public DBOBooker()
        {
        }

        public DBOBooker(string firstname, string lastname, int age, string post, int idService)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            IDService = idService;
            Post = post;
        }

        public override string ToString()
        {
            return Firstname + "  " + Lastname + " " + Age + " " + Post;
        }
    }
}
