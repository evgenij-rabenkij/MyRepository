using System.Collections.Generic;

namespace ProgramUniversity
{
    class UniversityCreator
    {
        string nameOfUniversity;
        public UniversityCreator(string nameOfUniversity)
        {
            this.nameOfUniversity = nameOfUniversity;
        }

        public University CreateUniversity(IDBProvider provider)//method of creation of new university
        {

            University university = provider.GetUniversity(nameOfUniversity);//getting new University with name and rector

            List<Faculty> faculties = provider.GetFaculties(nameOfUniversity);//getting list of faculties
            faculties.ForEach(f => university.AddDepartment(f));//adding faculties to department list

            List<Institute> institutes = provider.GetInstitutes(nameOfUniversity);//getting list of institutes
            institutes.ForEach(i => university.AddDepartment(i));//adding institutes to department list

            List<Service> services = provider.GetServices(nameOfUniversity);//getting list of services
            services.ForEach(s => university.AddDepartment(s));//adding services to department list

            Motorcade motorcade = provider.GetMotorcade(nameOfUniversity);//getting motorcade
            university.SetMotorcade(motorcade);//setting motorcade in university
            
            return university;
        }
    }
}
