

namespace ProgramUniversity
{
    class Head : Person
    {
        public int Experience { get; }

        public Head(string firstname, string lastname, int age, int experience) : base(firstname, lastname, age)
        {
            Experience = experience;
        }
    }
}
