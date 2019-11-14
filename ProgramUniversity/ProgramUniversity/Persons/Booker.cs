
namespace ProgramUniversity
{
    class Booker : Person
    {
        public string Post { get; }
        public Booker(string firstname, string lastname, int age, string post) : base(firstname, lastname, age)
        {
            Post = post;
        }
    }
}
