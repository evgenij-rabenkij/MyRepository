
namespace ProgramUniversity
{
    class DBOUniversity
    {
        public string Name { get; }
        public int ID { get; }
        public DBOUniversity(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return Name + " " + " " + ID + " ";
        }
    }
}
