using System;
using System.Collections.Generic;

namespace ProgramUniversity
{
    [Serializable]
    public class DBOFullUniversity
    {
        public DBORector DBORector { get; set; }
        public List<DBOAddress> DBOAddresses { get; set; } = new List<DBOAddress>();
        public List<DBOFaculty> DBOFaculties { get; set; } = new List<DBOFaculty>();
        public List<DBOInstitute> DBOInstitutes { get; set; } = new List<DBOInstitute>();
        public List<DBOService> DBOServices { get; set; } = new List<DBOService>();
        public List<DBODean> DBODeans { get; set; } = new List<DBODean>();
        public List<DBOStudent> DBOStudents { get; set; } = new List<DBOStudent>();
        public List<DBOManager> DBOManager { get; set; } = new List<DBOManager>();
        public List<DBOEmploye> DBOEmployes { get; set; } = new List<DBOEmploye>();
        public List<DBOHead> DBOHeads { get; set; } = new List<DBOHead>();
        public List<DBOBooker> DBOBookers { get; set; } = new List<DBOBooker>();
        public DBOMotorcade DBOMotorcade { get; set; }
        public DBOAutoChief DBOAutoChief { get; set; }
        public List<DBOVehicle> DBOVehicles { get; set; }
        public List<DBOGarage> DBOGarages { get; set; }
        public DBOFullUniversity()
        { 
        }

        public DBOFullUniversity(List<DBOAddress> aboAddresses, DBORector dboRector, List<DBOFaculty> dboFaculties, List<DBOInstitute> dboInstitutes, List<DBOService> dboServices, List<DBODean> dboDeans, List<DBOStudent> dboStudents, List<DBOManager> dboManager, List<DBOEmploye> dboEmployes, List<DBOHead> dboHeads, List<DBOBooker> dboBookers, DBOMotorcade dboMotorcade, DBOAutoChief dboAutoChief, List<DBOVehicle> dboVehicles, List<DBOGarage> dboGarages)
        {
            DBOAddresses = aboAddresses;
            DBORector = dboRector;
            DBOFaculties = dboFaculties;
            DBOInstitutes = dboInstitutes;
            DBOServices = dboServices;
            DBODeans = dboDeans;
            DBOStudents = dboStudents;
            DBOManager = dboManager;
            DBOEmployes = dboEmployes;
            DBOHeads = dboHeads;
            DBOBookers = dboBookers;
            DBOMotorcade = dboMotorcade;
            DBOAutoChief = dboAutoChief;
            DBOVehicles = dboVehicles;
            DBOGarages = dboGarages;
        }
    }
}
