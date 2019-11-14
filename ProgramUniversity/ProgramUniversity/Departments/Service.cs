using System;
using System.Collections.Generic;

namespace ProgramUniversity
{
    class Service : Department
    {
        public Head Head { get; set; }
        public List<Booker> Bookers { get; } = new List<Booker>();
        
         public Service(string name, Address address) : base(name, address)
         {
         }

        public bool AddBooker(Booker newBooker)//method for adding a new booker to a service
        {
            if (Bookers.Count > 9)
            {
                Console.WriteLine($"No more space in listof bookers for: {newBooker}.");
                return false;
            }

            foreach (Booker booker in Bookers)
            {
                if (booker.Equals(newBooker))
                {
                    Console.WriteLine($"{newBooker} already exists among bookers.");
                    return false;
                }
            }

            Bookers.Add(newBooker);
            return true;
        }

        public bool AddHead(Head head)//method for a setting a new head in service
        {
            Head = head;
            return true;
        }

        public override string ToString()
        {
            return "Service:" + base.ToString() + $"under the direction of Head: {Head}.";

        }

        public void Output()//method for outputting the list of bookers
        {
            Console.WriteLine("Bookers:");
            Bookers.ForEach(booker => Console.WriteLine(booker));
            Console.WriteLine("\n\n");
        }
    }
}
