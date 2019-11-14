
namespace ProgramUniversity
{
    class Rector : Person
    {
        public int YearOfJobStart { get; }

        public Rector(string firstname, string lastname, int age, int yearOfJobStart) : base(firstname, lastname, age)
        {
            YearOfJobStart = yearOfJobStart;
        }

        public override string ToString()
        {
            return base.ToString() + "   " + YearOfJobStart;
        }

    }
}
