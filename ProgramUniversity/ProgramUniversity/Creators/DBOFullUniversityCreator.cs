using System.Collections.Generic;
using System.Linq;

namespace ProgramUniversity
{
    class DBOFullUniversityCreator
    {
        public DBOFullUniversityCreator()
        { 
        }

        public DBOFullUniversity DBOFullUniversityCreate(University university)
        {
            int idUniversity = 1;
            
            List<Department> departments = university.Departments;//getting list of departments
            List<Address> addresses = new List<Address>();
            addresses =  departments.Select(n => n.Address).ToList();//taking addresses from departments
            addresses = addresses.Distinct(new AddressIEqualityComparer()).ToList(); //getting uniq addresses
            List<DBOAddress> dboAddresses = new List<DBOAddress>();
            int id = 1;
            dboAddresses  = addresses.Select(n => new DBOAddress ( id++, n.Street, n.City, n.Building )).ToList();//creating list of DBOAddresses

            DBORector dboRector = new DBORector(university.Rector.Firstname, university.Rector.Lastname, university.Rector.Age, university.Rector.YearOfJobStart, idUniversity);//getting rector from university

            List<Faculty> faculties = new List<Faculty>();
            faculties = departments.Where(d => d.GetType() == typeof(Faculty)).Select(d => (d as Faculty)).ToList();//getting faculties from list of departments
            List<DBOFaculty> dboFaculties = new List<DBOFaculty>();
            id = 1;
            dboFaculties = (from dboA in dboAddresses//creating list of DBOFaculties
                            join f in faculties on new Address(dboA.Street, dboA.City, dboA.Building) equals (f as Department).Address   
                            select new DBOFaculty((f as Department).Name, idUniversity, id++, dboA.ID)).Cast<DBOFaculty>().ToList();

            List<Institute> institutes = new List<Institute>();
            institutes = departments.Where(d => d.GetType() == typeof(Institute)).Select(d => (d as Institute)).ToList();//getting institutes from list of departments
            List<DBOInstitute> dboInstitutes = new List<DBOInstitute>();
            id = 1;
            dboInstitutes = (from dboA in dboAddresses//creating list of DBOInstitutes
                            join f in institutes on new Address(dboA.Street, dboA.City, dboA.Building) equals (f as Department).Address
                            select new DBOInstitute((f as Department).Name, idUniversity, id++, dboA.ID)).Cast<DBOInstitute>().ToList();

            List<Service> services = new List<Service>();
            services = departments.Where(d => d.GetType() == typeof(Service)).Select(d => (d as Service)).ToList();//getting services from list of departments
            List<DBOService> dboServices = new List<DBOService>();
            id = 1;
            dboServices = (from dboA in dboAddresses//creating list of DBOServises
                           join s in services on new Address(dboA.Street, dboA.City, dboA.Building) equals (s as Department).Address
                           select new DBOService((s as Department).Name, idUniversity, id++, dboA.ID)).Cast<DBOService>().ToList();

            var deans = faculties.Select(n => new { n.Dean, n.Name });//taking deans from faculties with name of their faculties
            List<DBODean> dboDeans = new List<DBODean>();
            dboDeans = (from d in deans//creating list of DBODeans
                        join dboF in dboFaculties on d.Name equals dboF.Name
                        select new DBODean(d.Dean.Firstname, d.Dean.Lastname, d.Dean.Degree, d.Dean.Age, dboF.ID)).Cast<DBODean>().ToList();

            List<DBOStudent> dboStudents = new List<DBOStudent>();
            var preDBOStudents = (from f in faculties//taking students from faculties with id of faculty
                                  join dboF in dboFaculties on f.Name equals dboF.Name
                                  select new { f.Students, dboF.ID}).ToList();
            preDBOStudents.ForEach(preStd => preStd.Students.ForEach(s => dboStudents.Add(new DBOStudent(s.Firstname, s.Lastname, s.Age, preStd.ID, s.AverageMark))));//creating the list of DBOStudents


            var managers = institutes.Select(n => new { n.Manager, n.Name });//taking managers from institutes with name of their institutes
            List<DBOManager> dboManagers = new List<DBOManager>();
            dboManagers = (from m in managers//creating list of DBOManagers
                           join dboI in dboInstitutes on m.Name equals dboI.Name
                           select new DBOManager(m.Manager.Firstname, m.Manager.Lastname, m.Manager.Roomnumber, m.Manager.Age, dboI.ID)).Cast<DBOManager>().ToList();
           
            List<DBOEmploye> dboEmployes = new List<DBOEmploye>();
            var preDBOEmployes = (from i in institutes//taking employes from institutes with id of theirs institutes
                                  join dboI in dboInstitutes on i.Name equals dboI.Name
                                  select new { i.Employes, dboI.ID }).ToList();
            preDBOEmployes.ForEach(preEmp => preEmp.Employes.ForEach(e => dboEmployes.Add(new DBOEmploye(e.Firstname, e.Lastname, e.Age, preEmp.ID, e.Wage))));//creating the list of DBOEmployes


            var heads = services.Select(n => new { n.Head, n.Name });//taking heads from services with name of their services
            List<DBOHead> dboHeads = new List<DBOHead>();
            dboHeads = (from h in heads//creating list of DBOHeads
                        join dboS in dboServices on h.Name equals dboS.Name
                        select new DBOHead(h.Head.Firstname, h.Head.Lastname, h.Head.Age,  h.Head.Experience ,dboS.ID)).Cast<DBOHead>().ToList();
            
            List<DBOBooker> dboBookers = new List<DBOBooker>();
            var preDBOBookers = (from s in services//taking bookers from services with id of theirs services
                                 join dboS in dboServices on s.Name equals dboS.Name
                                 select new { s.Bookers, dboS.ID }).ToList();
            preDBOBookers.ForEach(preBoo => preBoo.Bookers.ForEach(b => dboBookers.Add(new DBOBooker(b.Firstname, b.Lastname, b.Age, b.Post, preBoo.ID))));//creating the list of DBOBookers

            int idMotorcade = 1;
            DBOMotorcade dboMotorcade = new DBOMotorcade(university.Motorcade.Name, idUniversity, idMotorcade);//creating DBOMotorcade

            DBOAutoChief dboAutoChief = new DBOAutoChief(university.Motorcade.Chief.Firstname, university.Motorcade.Chief.Lastname, university.Motorcade.Chief.Age, idMotorcade);//creating DBOAutoChief of DBOMotorcade

            List<DBOVehicle> dboVehicles = new List<DBOVehicle>();
            university.Motorcade.Vehicles.ForEach(v => dboVehicles.Add(new DBOVehicle(v.Name, v.State, idMotorcade)));//creating list of DBOVehicles

            List<DBOGarage> dboGarages = new List<DBOGarage>();
            dboGarages = (from g in university.Motorcade.Garages//creating list of DBOGarages
                          join dboA in dboAddresses on g.Address equals new Address(dboA.Street, dboA.City, dboA.Building)
                          select new DBOGarage(g.Square, dboA.ID, idMotorcade)).Cast<DBOGarage>().ToList();

            DBOFullUniversity dboFullUniversity = new DBOFullUniversity( dboAddresses, dboRector, dboFaculties, dboInstitutes, dboServices, dboDeans, dboStudents, dboManagers,  dboEmployes,  dboHeads,  dboBookers, dboMotorcade, dboAutoChief, dboVehicles, dboGarages);//creating new full DBOUniversity
            
            return dboFullUniversity;
        }
    }
}
