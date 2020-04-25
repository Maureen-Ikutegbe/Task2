using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Family
{

    public class FamilyGroup 
    {
        public List<Siblings> Unmarried { get; set; }
        public List<Siblings> Married { get; set; }
    }

    public class Siblings:Common
    {
        public bool CanBake { get; set; }
       
    }

    public class Parents:Common
    {

    }

    public class SiblingsChildren:Common
    {

    }

    public class Common
    {
       public string Name { get; set; }
       public string Location { get; set; }

        public string BirthMonth { get; set; }
    }

 
}
