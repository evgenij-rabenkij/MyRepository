using System;

namespace ProgramUniversity 
{
    class Student : Person, IComparable
    {
        public double AverageMark { get; }

        public Student(string firstname, string lastname, int age, double averageMark) : base(firstname, lastname, age)
        {
            AverageMark = averageMark;
        }

        public int CompareTo(object obj)//method for sorting students by an average mark
        {
            Student p = obj as Student;
            return AverageMark.CompareTo(p.AverageMark);
        }
        public override string ToString()
        {
            return base.ToString() + "   " + AverageMark;
        }
    }
}
