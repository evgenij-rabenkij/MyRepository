using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOMotorcade
    {
        public string Name { get; set; }
        public int  ID { get; set; }
        public int IDUniversity { get; set; }

        public DBOMotorcade()
        {
           
        }
        public DBOMotorcade(string name, int idUniversity, int id)
        {
            Name = name;
            IDUniversity = idUniversity;
            ID = id;
        }

        public override string ToString()
        {
            return Name + " " + IDUniversity + " " + ID + " ";
        }
    }
}
