using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramUniversity
{
    class AddressIEqualityComparer : IEqualityComparer<Address>
    {
        public bool Equals(Address x, Address y)//override Equals method for using equals in LINQ for Address
        {
            return x.Street == y.Street && x.City == y.City && x.Building == y.Building;
        }

        public int GetHashCode(Address add)//override GetHashCode method for using equals in LINQ for Address
        {
            return add.Street.GetHashCode() ^
                   add.City.GetHashCode() ^
                   add.Building.GetHashCode();
        }
    }
}
