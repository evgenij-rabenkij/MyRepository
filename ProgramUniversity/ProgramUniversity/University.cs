using System;
using System.Collections.Generic;

namespace ProgramUniversity
{
    class University
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public Rector Rector { get; }
        public Motorcade Motorcade { get; set; }
        
        public University()
        {
        }
        
        public University(string name, Rector rector)//method for setting university name and rextor
        {
            Name = name;
            Rector = rector;
        }

        public bool AddDepartment(Department newDepartment)//method for adding departments to list of departments in university
        {
            if (Departments.Count > 9)
            {
                Console.WriteLine($"No more space for: {newDepartment} ");
                return false;
            }

            foreach (Department dpt in Departments)
            {
                if (dpt.Equals(newDepartment))
                {
                    Console.WriteLine($"{newDepartment} already exists.");
                    return false;
                }
            }

            Departments.Add(newDepartment);
            return true;
        }

        public void SetMotorcade(Motorcade motorcade)//metod for setting a new motorcade
        {
            Motorcade = motorcade;
        }
               
        public void Output()//method for outputting content of university
        {
            Console.WriteLine("UNIVERSITY");
            Console.WriteLine(Name);
            foreach (Department dpt in Departments)
            {
                Console.WriteLine(dpt);
                if (dpt.GetType() == typeof(Faculty))
                {
                    (dpt as Faculty).Output();
                }
                if (dpt.GetType() == typeof(Institute))
                {
                    (dpt as Institute).Output();
                }
                if (dpt.GetType() == typeof(Service))
                {
                    (dpt as Service).Output();
                }
            }
            Motorcade.Output();
            Console.WriteLine("\n\n");
        }
    }
}
