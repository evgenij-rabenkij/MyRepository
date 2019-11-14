using System;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOGarage
    {
        public int Square { get; set; }
        public int IDAddress { get; set; }
        public int IDMotorcade { get; set; }

        public DBOGarage()
        {

        }
        public DBOGarage(int square, int idAddess, int idMotorcade)
        {
            Square = square;
            IDAddress = idAddess;
            IDMotorcade = idMotorcade;
        }

        public override string ToString()
        {
            return Square + " " + IDAddress + " " + IDMotorcade;
        }
    }
}
