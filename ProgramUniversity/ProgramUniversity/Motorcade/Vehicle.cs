
namespace ProgramUniversity
{
    class Vehicle
    {
        public string Name { get; }
        public bool State { get; }

        public Vehicle(string name, bool state)
        {
            Name = name;
            State = state;
        }

        public override bool Equals(object obj)//override Equals method for comparison vehicles only by name
        {
            return Name == (obj as Vehicle).Name;
        }

        public override string ToString()
        {
            string a = "is not still going";
            if (State) { a = "is still going"; }
            return Name + " " + a;
        }
    }
}
