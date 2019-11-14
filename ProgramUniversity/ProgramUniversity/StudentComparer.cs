using System.Collections.Generic;

namespace ProgramUniversity
{
    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student p1, Student p2)//method for sorting students by lastname
        {
            return string.Compare(p1.Lastname, p2.Lastname);
        }
    }
}
