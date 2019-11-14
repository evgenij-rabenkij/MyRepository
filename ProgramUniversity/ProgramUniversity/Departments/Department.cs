
namespace ProgramUniversity
{
    class Department
    {
        public string Name { get;  }
        public Address Address { get; }

        public Department(string name, Address address)
        {
            Address = address;
            Name = name;
        }

        public override bool Equals(object obj)//override Equals method for proper comparison of departments
        {
            return (Name == (obj as Department).Name) && Address.Equals((obj as Department).Address);
        }

        public override string ToString()
        {
            return ($"{Name}, {Address}");
        }
    }
}
