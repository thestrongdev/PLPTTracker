using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.DALModels
{
    public class AthletesDAL
    {
        public string Club { get; set; }
        public int MemberID { get; set; }
        public int WeightClass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; } 
        public int Wilks { get; set; }
        public int Total { get; set; }
        public List<String> LifterDivisions { get; set; }
    }
}
