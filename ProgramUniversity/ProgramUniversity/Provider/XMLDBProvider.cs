using System.Xml;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace ProgramUniversity

{
    class XMLDBProvider  : IDBProvider
    {

        public delegate void CompleteSave(string message);
        public event CompleteSave completedSaving;//event for save message

        const string filename = "..\\..\\..\\university.xml";//path to a XML Data Base
        XmlDocument xmlDocument = new XmlDocument();

        List<DBOUniversity> dboUniversities = new List<DBOUniversity>();
        List<DBOAddress> dboAddresses = new List<DBOAddress>();
        List<DBOFaculty> dboFaculties = new List<DBOFaculty>();
        List<DBOInstitute> dboInstitutes = new List<DBOInstitute>();
        List<DBOService> dboServices = new List<DBOService>();
        List<DBORector> dboRectors = new List<DBORector>();
        List<DBODean> dboDeans = new List<DBODean>();
        List<DBOStudent> dboStudents = new List<DBOStudent>();
        List<DBOManager> dboManagers = new List<DBOManager>();
        List<DBOEmploye> dboEmployes = new List<DBOEmploye>();
        List<DBOHead> dboHeads = new List<DBOHead>();
        List<DBOBooker> dboBookers = new List<DBOBooker>();
        List<DBOMotorcade> dboMotorcades = new List<DBOMotorcade>();
        List<DBOVehicle> dboVehicles = new List<DBOVehicle>();
        List<DBOAutoChief> dboAutoChiefs = new List<DBOAutoChief>();
        List<DBOGarage> dboGarages = new List<DBOGarage>();

        public XMLDBProvider()
        {
            XDocument doc = XDocument.Load(filename);
            
            dboUniversities = (from xmlU in doc.Element("root").Elements("universities").Elements("university")//getting DBOUniversities from XML
                            select new DBOUniversity(xmlU.Element("name").Value, Convert.ToInt32(xmlU.Element("ID").Value))).Cast<DBOUniversity>().ToList();

            dboAddresses = (from xmlA in doc.Element("root").Elements("addresses").Elements("address")//getting DBOAddresses from XML
                            select new DBOAddress(Convert.ToInt32(xmlA.Element("ID").Value), xmlA.Element("street").Value, xmlA.Element("city").Value, xmlA.Element("building").Value)).Cast<DBOAddress>().ToList();

            dboFaculties = (from xmlF in doc.Element("root").Elements("faculties").Elements("faculty")//getting DBOFaculties from XML
                            select new DBOFaculty(xmlF.Element("name").Value, Convert.ToInt32(xmlF.Element("IDUniversity").Value), Convert.ToInt32(xmlF.Element("ID").Value), Convert.ToInt32(xmlF.Element("IDAddress").Value))).Cast<DBOFaculty>().ToList();

            dboInstitutes = (from xmlI in doc.Element("root").Elements("institutes").Elements("institute")//getting DBOInstitutes from XML
                             select new DBOInstitute(xmlI.Element("name").Value, Convert.ToInt32(xmlI.Element("IDUniversity").Value), Convert.ToInt32(xmlI.Element("ID").Value), Convert.ToInt32(xmlI.Element("IDAddress").Value))).Cast<DBOInstitute>().ToList();

            dboServices = (from xmlS in doc.Element("root").Elements("services").Elements("service")//getting DBOServices from XML
                           select new DBOService(xmlS.Element("name").Value, Convert.ToInt32(xmlS.Element("IDUniversity").Value), Convert.ToInt32(xmlS.Element("ID").Value), Convert.ToInt32(xmlS.Element("IDAddress").Value))).Cast<DBOService>().ToList();

            dboMotorcades = (from xmlS in doc.Element("root").Elements("motorcades").Elements("motorcade")//getting DBOMotorcades from XML
                             select new DBOMotorcade(xmlS.Element("name").Value, Convert.ToInt32(xmlS.Element("IDUniversity").Value), Convert.ToInt32(xmlS.Element("ID").Value))).Cast<DBOMotorcade>().ToList();

            dboDeans = (from xmlD in doc.Element("root").Elements("deans").Elements("dean")//getting DBODeans from XML
                        select new DBODean(xmlD.Element("firstname").Value, xmlD.Element("lastname").Value, xmlD.Element("degree").Value, Convert.ToInt32(xmlD.Element("age").Value), Convert.ToInt32(xmlD.Element("IDFaculty").Value))).Cast<DBODean>().ToList();

            dboManagers = (from xmlM in doc.Element("root").Elements("managers").Elements("manager")//getting DBOManager from XML
                           select new DBOManager(xmlM.Element("firstname").Value, xmlM.Element("lastname").Value, Convert.ToInt32(xmlM.Element("age").Value), Convert.ToInt32(xmlM.Element("roomnumber").Value), Convert.ToInt32(xmlM.Element("IDInstitute").Value))).Cast<DBOManager>().ToList();

            dboHeads = (from xmlH in doc.Element("root").Elements("heads").Elements("head")//getting DBOHeads from XML
                        select new DBOHead(xmlH.Element("firstname").Value, xmlH.Element("lastname").Value, Convert.ToInt32(xmlH.Element("age").Value), Convert.ToInt32(xmlH.Element("experience").Value), Convert.ToInt32(xmlH.Element("IDService").Value))).Cast<DBOHead>().ToList();

            dboRectors = (from xmlR in doc.Element("root").Elements("rectors").Elements("rector")//getting DBORectors from XML
                          select new DBORector(xmlR.Element("firstname").Value, xmlR.Element("lastname").Value, Convert.ToInt32(xmlR.Element("age").Value), Convert.ToInt32(xmlR.Element("year_of_job_start").Value), Convert.ToInt32(xmlR.Element("IDUniversity").Value))).Cast<DBORector>().ToList();

            dboStudents = (from xmlS in doc.Element("root").Elements("students").Elements("student")//getting DBOStudents from XML
                           select new DBOStudent(xmlS.Element("firstname").Value, xmlS.Element("lastname").Value, Convert.ToInt32(xmlS.Element("age").Value), Convert.ToInt32(xmlS.Element("IDFaculty").Value), Convert.ToDouble(xmlS.Element("average_mark").Value))).Cast<DBOStudent>().ToList();

            dboEmployes = (from xmlE in doc.Element("root").Elements("employes").Elements("employe")//getting DBOEmployes from XML
                           select new DBOEmploye(xmlE.Element("firstname").Value, xmlE.Element("lastname").Value, Convert.ToInt32(xmlE.Element("age").Value), Convert.ToInt32(xmlE.Element("IDInstitute").Value), Convert.ToInt32(xmlE.Element("wage").Value))).Cast<DBOEmploye>().ToList();

            dboBookers = (from xmlB in doc.Element("root").Elements("bookers").Elements("booker")//getting DBOBookers from XML
                          select new DBOBooker(xmlB.Element("firstname").Value, xmlB.Element("lastname").Value, Convert.ToInt32(xmlB.Element("age").Value), xmlB.Element("post").Value, Convert.ToInt32(xmlB.Element("IDService").Value))).Cast<DBOBooker>().ToList();

            dboAutoChiefs = (from xmlAC in doc.Element("root").Elements("autochiefs").Elements("autochief")//getting DBOAutochiefs from XML
                             select new DBOAutoChief(xmlAC.Element("firstname").Value, xmlAC.Element("lastname").Value, Convert.ToInt32(xmlAC.Element("age").Value),  Convert.ToInt32(xmlAC.Element("IDMotorcade").Value))).Cast<DBOAutoChief>().ToList();

            dboVehicles = (from xmlV in doc.Element("root").Elements("vehicles").Elements("vehicle")//getting DBOVehicles from XML
                          select new DBOVehicle(xmlV.Element("name").Value, Convert.ToBoolean(Convert.ToInt32(xmlV.Element("state").Value)), Convert.ToInt32(xmlV.Element("IDMotorcade").Value))).Cast<DBOVehicle>().ToList();

            dboGarages = (from xmlG in doc.Element("root").Elements("garages").Elements("garage")//getting DBOGarages from XML
                          select new DBOGarage(Convert.ToInt32(xmlG.Element("square").Value), Convert.ToInt32(xmlG.Element("IDAddress").Value), Convert.ToInt32(xmlG.Element("IDMotorcade").Value))).Cast<DBOGarage>().ToList();
        }

        public University GetUniversity(string nameOfUniversity)//method for providing university with appropriate name and rector
        {
           
            dboUniversities = dboUniversities.Where(u => u.Name == nameOfUniversity).Select(u => u).ToList();//selecting DBOUniversity with appropriate name
            List<University> universities = new List<University>();
           
            universities = (from dboU in dboUniversities// creating university with appropriate name and rector
                            join dboR in dboRectors on dboU.ID equals dboR.IDUniversity
                            select new University(dboU.Name, new Rector(dboR.Firstname, dboR.Lastname, Convert.ToInt32(dboR.Age), Convert.ToInt32(dboR.YearOfJobStart)))).Cast<University>().ToList();

            return universities[0];
        }

        public List<Faculty> GetFaculties(string nameOfUniversity)//metod of providing the list of Faculties
        {
            dboUniversities = dboUniversities.Where(u => u.Name == nameOfUniversity).Select(u => u).ToList();//selecting university with appropriate name

            List<Faculty> faculties = new List<Faculty>();

            faculties = (from dboF in dboFaculties//creating appropriate Faculties 
                         join dboU in dboUniversities on dboF.IDUniversity equals dboU.ID
                         join dboA in dboAddresses on dboF.IDAddress equals dboA.ID
                         select new Faculty(dboF.Name, new Address(dboA.Street, dboA.City, dboA.Building))).ToList();

            var postDBODeans = (from dboF in dboFaculties//creating buffer objects for deans 
                                join dboD in dboDeans on dboF.ID equals dboD.IDFaculty
                                select new
                                {
                                    firstname = dboD.Firstname,
                                    lastname = dboD.Lastname,
                                    age = dboD.Age,
                                    degree = dboD.Degree,
                                    nameOfFaculty = dboF.Name
                                }).ToList();

            var postDBOStudents = (from dboF in dboFaculties//creating buffer objects for students 
                                   join dboS in dboStudents on dboF.ID equals dboS.IDFaculty
                                   select new
                                   {
                                       firstname = dboS.Firstname,
                                       lastname = dboS.Lastname,
                                       age = dboS.Age,
                                       averageMark = dboS.AverageMark,
                                       nameOfFaculty = dboF.Name
                                   }).ToList();

            var deansAdder = (from f in faculties//adding deans to faculties from buffer
                              join postDBOD in postDBODeans on f.Name equals postDBOD.nameOfFaculty
                              select f.AddDean(new Dean(postDBOD.firstname, postDBOD.lastname, postDBOD.age, postDBOD.degree))).ToList();

            var studentsAdder = (from f in faculties//adding students to faculties from buffer
                                 join postDBOS in postDBOStudents on f.Name equals postDBOS.nameOfFaculty
                                 select f.AddStudent(new Student(postDBOS.firstname, postDBOS.lastname, postDBOS.age, postDBOS.averageMark))).ToList();
            return faculties;
        }

        public List<Institute> GetInstitutes(string nameOfUniversity)//metod of providing the list of Institutes
        {
            dboUniversities = dboUniversities.Where(u => u.Name == nameOfUniversity).Select(u => u).ToList();//selecting university with appropriate name

            List<Institute> institutes = new List<Institute>();

            institutes = (from dboI in dboInstitutes//creating appropriate Institutes 
                          join dboU in dboUniversities on dboI.IDUniversity equals dboU.ID
                          join dboA in dboAddresses on dboI.IDAddress equals dboA.ID
                          select new Institute(dboI.Name, new Address(dboA.Street, dboA.City, dboA.Building))).ToList();

            var postDBOManagers = (from dboI in dboInstitutes//creating buffer objects for managers
                                   join dboM in dboManagers on dboI.ID equals dboM.IDInstitute
                                   select new
                                   {
                                       firstname = dboM.Firstname,
                                       lastname = dboM.Lastname,
                                       age = dboM.Age,
                                       roomNumber = dboM.Roomnumber,
                                       nameOfInstitute = dboI.Name
                                   }).ToList();

            var postDBOEmployes = (from dboI in dboInstitutes//creating buffer objects for employes
                                   join dboE in dboEmployes on dboI.ID equals dboE.IDInstitute
                                   select new
                                   {
                                       firstname = dboE.Firstname,
                                       lastname = dboE.Lastname,
                                       age = dboE.Age,
                                       wage = dboE.Wage,
                                       nameOfInstitute = dboI.Name
                                   }).ToList();

            var managersAdder = (from i in institutes//adding managers to institutes from buffer
                                 join postDBOM in postDBOManagers on i.Name equals postDBOM.nameOfInstitute
                                 select i.AddManager(new Manager(postDBOM.firstname, postDBOM.lastname, postDBOM.age, postDBOM.roomNumber))).ToList();

            var employesAdder = (from i in institutes//adding employes to institutes from buffer
                                 join postDBOE in postDBOEmployes on i.Name equals postDBOE.nameOfInstitute
                                 select i.AddEmploye(new Employe(postDBOE.firstname, postDBOE.lastname, postDBOE.age, postDBOE.wage))).ToList();
            return institutes;
        }

        public List<Service> GetServices(string nameOfUniversity)//metod of providing the list of Services
        {
            dboUniversities = dboUniversities.Where(u => u.Name == nameOfUniversity).Select(u => u).ToList();//selecting university with appropriate name

            List<Service> services = new List<Service>();

            services = (from dboS in dboServices//creating appropriate Services 
                        join dboU in dboUniversities on dboS.IDUniversity equals dboU.ID
                        join dboA in dboAddresses on dboS.IDAddress equals dboA.ID
                        select new Service(dboS.Name, new Address(dboA.Street, dboA.City, dboA.Building))).ToList();

            var postDBOHeads = (from dboS in dboServices//creating buffer objects for heads
                                join dboH in dboHeads on dboS.ID equals dboH.IDService
                                select new
                                {
                                    firstname = dboH.Firstname,
                                    lastname = dboH.Lastname,
                                    age = dboH.Age,
                                    experience = dboH.Experience,
                                    nameOfService = dboS.Name
                                }).ToList();

            var postDBOBookers = (from dboS in dboServices//creating buffer objects for bookers
                                  join dboB in dboBookers on dboS.ID equals dboB.IDService
                                  select new
                                  {
                                      firstname = dboB.Firstname,
                                      lastname = dboB.Lastname,
                                      age = dboB.Age,
                                      post = dboB.Post,
                                      nameOfService = dboS.Name
                                  }).ToList();

            var headsAdder = (from s in services//adding heads to services from buffer
                              join postDBOH in postDBOHeads on s.Name equals postDBOH.nameOfService
                              select s.AddHead(new Head(postDBOH.firstname, postDBOH.lastname, postDBOH.age, postDBOH.experience))).ToList();

            var bookersAdder = (from s in services//adding bookers to services from buffer
                                join postDBOB in postDBOBookers on s.Name equals postDBOB.nameOfService
                                select s.AddBooker(new Booker(postDBOB.firstname, postDBOB.lastname, postDBOB.age, postDBOB.post))).ToList();
            return services;
        }

        public Motorcade GetMotorcade(string nameOfUniversity)//metod of providing the Motorcade
        {
            dboUniversities = dboUniversities.Where(u => u.Name == nameOfUniversity).Select(u => u).ToList();

            List<Motorcade> motorcades = new List<Motorcade>();

            motorcades = (from dboU in dboUniversities// creating Motorcade with appropriate name
                          join dboMot in dboMotorcades on dboU.ID equals dboMot.IDUniversity
                          select new Motorcade(dboMot.Name )).Cast<Motorcade>().ToList();

            var autoChifAdder = (from dboMot in dboMotorcades//adding AutoChief
                                 join dboAutoC in dboAutoChiefs on dboMot.ID equals dboAutoC.IDMotorcade
                                 select motorcades[0].AddAutoChief(new AutoChief(dboAutoC.Firstname, dboAutoC.Lastname, dboAutoC.Age))).ToList();

            List<Garage> garages = new List<Garage>();
            garages = (from dboMot in dboMotorcades//creating Garages
                       join dboG in dboGarages on dboMot.ID equals dboG.IDMotorcade
                       join dboA in dboAddresses on dboG.IDAddress equals dboA.ID
                       select new Garage(dboG.Square, new Address(dboA.Street, dboA.City, dboA.Building))).Cast<Garage>().ToList();

            garages.ForEach(g => motorcades[0].AddGarage(g));//adding garages to motorcade

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles = (from dboMot in dboMotorcades//creating Vehicles
                        join dboV in dboVehicles on dboMot.ID equals dboV.IDMotorcade
                        select new Vehicle(dboV.Name, Convert.ToBoolean(Convert.ToInt32(dboV.State)))).Cast<Vehicle>().ToList();

            vehicles.ForEach(v => motorcades[0].AddVehicle(v));//adding vehicles to motorcade

            return motorcades[0];
        }

        public bool XMLSave(University university)//method for saving university as lists of DBO to XML
        {
            DBOFullUniversityCreator dboFullUniversityCreator = new DBOFullUniversityCreator();//initialization of FullDBOUniversityCreator
            DBOFullUniversity dboFullUniversity = dboFullUniversityCreator.DBOFullUniversityCreate(university);//Creation of FullDBOUniversity
            XmlSerializer formatter = new XmlSerializer(typeof(DBOFullUniversity));

            using (FileStream file = new FileStream("..\\..\\..\\XML\\DBOUniversitySerialized.xml", FileMode.OpenOrCreate))//DBOFullUniversity to XML
            {
                formatter.Serialize(file, dboFullUniversity);
                completedSaving("DBOFullUniversity serialized to XML");//event with a message about serialization
                return true;
            }
        }

        public bool JSONSave(University university)//method for saving university as lists of DBO to JSON
        {
            DBOFullUniversityCreator dboFullUniversityCreator = new DBOFullUniversityCreator();//initialization of FullDBOUniversityCreaator
            DBOFullUniversity dboFullUniversity = dboFullUniversityCreator.DBOFullUniversityCreate(university);//Creation of FullDBOUniversity
            DataContractJsonSerializer jsFormatter = new DataContractJsonSerializer(typeof(DBOFullUniversity));

            using (FileStream file = new FileStream("..\\..\\..\\JSON\\FullDBOUniversitySerialized.json", FileMode.OpenOrCreate))//DBOFullUniversity to JSON
            {
                jsFormatter.WriteObject(file, dboFullUniversity);
                completedSaving("DBOFullUniversity serialized to JSON");//event with a message about serialization
                return true;
            }
        }
    }
}





