using System.Collections.Generic;

namespace ProgramUniversity
{
    interface IDBProvider//Interface for Data Base Providers
    {
        University GetUniversity(string name);
        List<Faculty> GetFaculties(string name);
        List<Institute> GetInstitutes(string name);
        List<Service> GetServices(string name);
        Motorcade GetMotorcade(string name);
        bool XMLSave(University university);
        bool JSONSave(University university);
    }
}
