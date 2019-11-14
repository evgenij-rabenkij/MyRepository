
namespace ProgramUniversity
{ 
    class Dean : Person
    {
        public string Degree { get; set; }
        public Dean(string firstname, string lastname,int age, string degree) : base(firstname, lastname, age)
        {
            Degree = degree;
        }

        public override string ToString()
        {
            return Degree + " " + base.ToString();
        }
    }
}
