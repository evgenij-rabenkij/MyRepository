using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOVehicle
    {
        public string Name { get; set; }
        public bool State { get; set; }
        public int IDMotorcade { get; set; }

        public DBOVehicle()
        {
            
        }

        public DBOVehicle(string name, bool state, int idMotorcade)
        {
            Name = name;
            State = state;
            IDMotorcade = idMotorcade;
        }

        public override string ToString()
        {
            string a = " not still going";
            if (State) { a = "still going"; }
            return Name + "  "  + IDMotorcade +" "+ a ;
        }
    }
}
