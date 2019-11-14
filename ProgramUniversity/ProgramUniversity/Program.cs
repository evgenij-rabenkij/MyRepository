using System;
using System.IO;

namespace ProgramUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBProvider provider = new XMLDBProvider();//initialization of Data Base Provider

            UniversityCreator creator = new UniversityCreator("BSU");//initialization of University Creator
            
            University university = creator.CreateUniversity(provider);//call of University Creator

            university.Output();//Output result for full university
            
            Student newExtraStudent = new Student("Inokentiy", "Gundeev", 20, 7.6);//creating a new student
            (university.Departments[1] as Faculty).studentAdded += DisplayNotification;//subscribing event with message about adding a new student on method for outputting messages
            (university.Departments[1] as Faculty).AddExtraStudent(newExtraStudent);//adding an extra student to faculty

            (provider as XMLDBProvider).completedSaving += DisplayNotification;//subscribing event with message about saving on method for outputting messages
            provider.XMLSave(university);//saving university to XML
            provider.JSONSave(university);//saving university to JSON

            (university.Departments[1] as Faculty).Students.Sort();//sorting students from faculty by average mark
            Console.WriteLine("Sorting students by averege mark:");
            (university.Departments[1] as Faculty).Students.ForEach(std => Console.WriteLine(std));
            
            (university.Departments[1] as Faculty).Students.Sort(new StudentComparer());//sorting students from faculty by lastname
            Console.WriteLine("Sorting students by lastname:");
            (university.Departments[1] as Faculty).Students.ForEach(std => Console.WriteLine(std));
        }
        private static void DisplayNotification(string message)
        {
            Console.WriteLine("Notification: " + message);
        }
    }
}
