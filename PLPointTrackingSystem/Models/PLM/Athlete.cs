using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PLPointTrackingSystem.Models.PLMController.LiftingCategories;

namespace PLPointTrackingSystem
{
    public class Athlete
    {
        public string Club { get; set; }
        public int MemberID { get; set; }
        public int WeightClass { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; } //MAY NOT NEED

        public int Wilks { get; set; }

        public int Total { get; set; }

        public List<Division> LifterDivisions { get; set; }


    }
}
