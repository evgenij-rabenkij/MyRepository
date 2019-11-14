
namespace ProgramUniversity
{
    class Employe : Person
    {
        public int Wage { get; }

        public Employe(string firstname, string lastname, int age, int wage) : base(firstname, lastname, age)
        {
            Wage = wage;
        }
    }
}
