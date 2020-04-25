using System;
using System.Collections.Generic;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            Siblings Sibliing1 = new Siblings()
            {
                Name = "James",
                Location = "Nigeria",
                BirthMonth = "January",
                CanBake = false
            };

            Siblings Sibliing2 = new Siblings()
            {
                Name = "Jane",
                Location = "Nigeria",
                BirthMonth = "June",
                CanBake = true
            };

            Siblings Sibliing3 = new Siblings()
            {
                Name = "John",
                Location = "Nigeria",
                BirthMonth = "April",
                CanBake = true
            };

            Siblings Sibliing4 = new Siblings()
            {
                Name = "Vera",
                Location = "Nigeria",
                BirthMonth = "February",
                CanBake = true
            };

            FamilyGroup RelationshipStatus = new FamilyGroup()
            {
                Unmarried = new List<Siblings>(),
                Married = new List<Siblings>()
            };

            RelationshipStatus.Unmarried.Add(Sibliing2);
            RelationshipStatus.Unmarried.Add(Sibliing3);
            RelationshipStatus.Married.Add(Sibliing1);
            RelationshipStatus.Married.Add(Sibliing4);

            Console.WriteLine("My unmarried siblings are:");
            foreach (var m in RelationshipStatus.Unmarried)
            {
                Console.WriteLine("{0}, currently living in {1}, born in the month of {2}.", m.Name, m.Location, m.BirthMonth);
            }
            Console.WriteLine("My married siblings are:");
            foreach (var m in RelationshipStatus.Married)
            {
                Console.WriteLine("{0}, currently living in {1}, born in the month of {2}.", m.Name, m.Location, m.BirthMonth);
            }
        }
    }
}
