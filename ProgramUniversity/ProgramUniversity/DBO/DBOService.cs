using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOService
    {
        public string Name { get; set; }
        public int IDUniversity { get; set; }
        public int ID { get; set; }
        public int IDAddress { get; set; }

        public DBOService()
        {
            
        }
        public DBOService(string name, int idUniversity, int id, int idAddress)
        {
            Name = name;
            IDUniversity = idUniversity;
            ID = id;
            IDAddress = idAddress;
        }

        public override string ToString()
        {
            return Name + " " + IDUniversity + " " + ID + " " + IDAddress;
        }
    }
}
