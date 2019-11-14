
namespace ProgramUniversity
{
    class Garage
    {
        public int Square { get; }
        public Address Address { get;  } 

        public Garage(int square, Address address)
        {
            Square = square;
            Address = address;
        }

        public override bool Equals(object obj)//override Equals method for proper comparison of garages
        {
            return (Square == (obj as Garage).Square) && Address.Equals((obj as Garage).Address);
        }

        public override string ToString()
        {
            return ($"Square: {Square}, {Address} ");
        }
    }
}
