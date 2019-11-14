using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOAddress
    {
        public int ID{ get;  set; }
        public string Street { get;  set; }
        public string City { get;  set; }
        public string Building { get;  set; }
        public DBOAddress()
        {
        
        }
        public DBOAddress(int id, string street, string city, string building)
        {
            ID = id;
            Street = street;
            City = city;
            Building = building;
        }

        public override string ToString()
        {
            return ID + " " + Street + " " + City + " " + Building;
        }
    }
}
