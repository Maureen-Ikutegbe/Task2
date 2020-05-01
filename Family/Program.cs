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
                Gender = "Male",
                CanBake = false       
            };

            Siblings Sibliing2 = new Siblings()
            {
                Name = "Jane",
                Location = "Nigeria",
                BirthMonth = "June",
                Gender = "Female",
                CanBake = true
            };

            Siblings Sibliing3 = new Siblings()
            {
                Name = "John",
                Location = "Nigeria",
                BirthMonth = "April",
                Gender = "Male",
                CanBake = true
            };

            Siblings Sibliing4 = new Siblings()
            {
                Name = "Vera",
                Location = "Nigeria",
                BirthMonth = "February",
                Gender = "Female",
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
                Siblings y = ConvertGender(m); 
                Console.WriteLine("{0}, {1} currently lives in {2}, and was born in the month of {3}.", y.Name, y.DisplayGender, y.Location, y.BirthMonth);
            }
            Console.WriteLine("");
            Console.WriteLine("My married siblings are:");
            foreach (var m in RelationshipStatus.Married)
            {
                Siblings y = ConvertGender(m);
                Console.WriteLine("{0}, {1} currently lives in {2}, and was born in the month of {3}.", y.Name, y.DisplayGender, y.Location, y.BirthMonth);
            }
        }

        private static Siblings ConvertGender (Siblings m)
        {
            if(m.Gender == "Female")
            {
                m.DisplayGender = "she";
            }
            else
            {
                m.DisplayGender = "he";
            }
            return m;
        }
    }
}
