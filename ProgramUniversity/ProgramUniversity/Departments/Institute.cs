using System;
using System.Collections.Generic;

namespace ProgramUniversity
{
    class Institute : Department
    {
        public List<Employe> Employes { get; } = new List<Employe>();
        public Manager Manager { get; set; }

        public Institute(string name, Address address) : base(name, address)
        {
        }

        public bool AddEmploye(Employe newEmploye)//method for adding a employe to institute
        {
            if (Employes.Count > 9)
            {
                Console.Write($"No more space in list of employes for: {newEmploye}.");
                return false;
            }

            foreach (Employe emp in Employes)
            {
                if (emp.Equals(newEmploye))
                {
                    Console.WriteLine($"{newEmploye} already exists among employes.");
                    return false;
                }
            }

            Employes.Add(newEmploye);
            return true;
        }

        public override string ToString()
        {
            return "Institute:" + base.ToString() + $"under the direction of Manager: {Manager}.";

        }
        public bool AddManager(Manager manager)//method for setting a new manager in institute
        {
            Manager = manager;
            return true;
        }
        public void Output()//method for outputting the list of employes
        {
            Console.WriteLine("Employes:");
            Employes.ForEach(employe => Console.WriteLine(employe));
            Console.WriteLine("\n");
        }
    }
}
