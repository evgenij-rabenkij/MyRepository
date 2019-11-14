using System;
using System.Collections.Generic;

namespace ProgramUniversity
{
    class Faculty : Department
    {
        public delegate void AddNewStudent(string message);
        public event AddNewStudent studentAdded;//event for adding an extra student

        public List<Student> Students { get; } = new List<Student>();
        public Dean Dean { get; set; }

        public Faculty(string name, Address address) : base(name, address)
        {
            
        }
        
        public bool AddStudent(Student newStudent)//method for adding a new student to a faculty
        {
            if (Students.Count > 9)
            {
                Console.WriteLine($"No more space in list of student for: {newStudent}.");
                return false;
            }
            
            foreach (Student std in Students)
            {
                if (std.Equals(newStudent))
                {
                    Console.WriteLine($"{newStudent} already exists among students.");
                    return false;
                }
            }

            Students.Add(newStudent);
            return true;
        }

        public bool AddExtraStudent(Student newStudent)//method for adding a new extra student to a faculty (after creating a University)
        {
            if (Students.Count > 9)
            {
                Console.WriteLine($"No more space in list of student for: {newStudent}.");
                return false;
            }

            foreach (Student std in Students)
            {
                if (std.Equals(newStudent))
                {
                    Console.WriteLine($"{newStudent} already exists among students.");
                    return false;
                }
            }

            Students.Add(newStudent);
            studentAdded($"new student {newStudent.Firstname} {newStudent.Lastname} was added to {Name}.");//event with a message
            return true;
        }

        public bool AddDean(Dean dean)//method for setting a new dean in faculty
        {
            Dean = dean;
            return true;
        }

        public override string ToString()
        {
            return "Faculty: " + base.ToString() + $"under the direction of Dean: {Dean}.";

        }
        public void Output()//method for outputting the list of students
        {
            Console.WriteLine("Students: ");
            Students.ForEach(student => Console.WriteLine(student));
            Console.WriteLine("\n");
        }
    }
}
