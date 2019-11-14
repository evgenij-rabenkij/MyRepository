
namespace ProgramUniversity
{
    class Manager : Person
    {
        public int Roomnumber { get;  }
       
        public Manager(string firstname, string lastname, int age, int roomnumber) : base(firstname, lastname, age)
        {
            Roomnumber = roomnumber;
        }
    }
}
