
namespace ProgramUniversity
{
    class Person
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public int Age { get; }

        public Person(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public override bool Equals(object obj)//override bool for comparison persons by firstname, lastname and age
        {
            return Firstname == (obj as Person).Firstname && Lastname == (obj as Person).Lastname && Age == (obj as Person).Age;
        }
        public override string ToString()
        {
            return ($"{Firstname}  {Lastname}, age: {Age}"); ;
        }
    }
}
