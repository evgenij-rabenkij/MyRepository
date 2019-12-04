using System.Collections.Generic;

namespace DEV_6
{
    class CarInfoDB//class which presents Car Information Data Base
    {
        public List<CarInformation> CarsInformation { get; } = new List<CarInformation>();
        public CarInfoDB()
        {
        }
    }
}
