using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem
{
    public class Athlete
    {
        public string Club { get; set; }
        public int MemberID { get; set; }
        public int WeightClass { get; set; } //MAKE THIS AN ENUM
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Division { get; set; } //MAKE THIS AN INTERFACE???
        public int NumberOfDivisions { get; set; }


    }
}
