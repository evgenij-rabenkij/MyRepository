using System;
using System.Collections.Generic;

namespace ProgramUniversity
{
    class Motorcade
    {
        public string Name { get; }
        public List<Vehicle> Vehicles { get; } = new List<Vehicle>();
        public List<Garage> Garages { get; } = new List<Garage>();
        public AutoChief Chief { get; set; }
        public Motorcade(string name)
        {
            Name = name;
        }

        public bool AddVehicle(Vehicle newVehicle)//method for adding a new vehicle to a motorcade
        {
            if (Vehicles.Count > 9)
            {
                Console.WriteLine($"No more space in list of vehicle for: {newVehicle}.");
                return false;
            }

            foreach (Vehicle veh in Vehicles)
            {
                if (veh.Equals(newVehicle))
                {
                    Console.WriteLine($"{newVehicle} already exists among vehicles.");
                    return false;
                }
            }

            Vehicles.Add(newVehicle);
            return true;
        }

        public bool AddGarage(Garage newGarage)//method for adding a new garage to a motorcade
        {
            if (Garages.Count > 9)
            {
                Console.WriteLine($"No more space in list of garages for: {newGarage}.");
                return false;
            }

            foreach (Garage gar in Garages)
            {
                if (gar.Equals(newGarage))
                {
                    Console.WriteLine($"{newGarage} already exists among garages.");
                    return false;
                }
            }

            Garages.Add(newGarage);
            return true;
        }

        public bool AddAutoChief(AutoChief chief)//method for setting a new autochief in motorcade
        {
            Chief = chief;
            return true;
        }
        public void Output()//method of outputting content of motorcade
        {
            Console.WriteLine($"Motorcade under the direction of Chief: {Chief}");
            Console.WriteLine("Garages:");
            Garages.ForEach(garage => Console.WriteLine(garage));
            Console.WriteLine("Vehicles:");
            Vehicles.ForEach(vehicle => Console.WriteLine(vehicle));
        }
    }
}
