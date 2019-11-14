namespace ProgramUniversity
{
    class Address 
    {
        public string Street { get; }
        public string City { get; }
        public string Building { get; }

        public Address(string street, string city, string building)
        {
            Street = street;
            City = city;
            Building = building;
        }

        public override string ToString()//override ToString method for outputting full address in console
        {
            return $"address: {Street}, {City}, {Building} ";  
        }

        public override bool Equals(object obj)//override Equals method for proper comparison of addresses
        {
            return (Street == (obj as Address).Street) && (City == (obj as Address).City) && (Building == (obj as Address).Building);
        }

        public override int GetHashCode()//override GetHashCode method for using IEqualityComparer for Address
        {
            return 0;
        }
    }
}
