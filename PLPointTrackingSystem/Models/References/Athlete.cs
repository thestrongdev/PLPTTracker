using PLPointTrackingSystem.Models.PLMController;
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
        public string MemberID { get; set; }
        public string WeightClass { get; set; } 
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; } //MAY NOT NEED
        public int Wilks { get; set; }
        public int Total { get; set; }

        public double WeighIn { get; set; }

        public string DivisionString { get; set; }
        public List<Division> LifterDivisions { get; set; } //MAP TO THIS AFTER GATHERING DATA FROM UPLOAD???

        public string Squat_Opener { get; set; }

        public string Bench_Opener { get; set; }

        public string Deadlift_Opener { get; set; }

        public Squat SquatAttempts { get; set; }
        public Bench BenchAttempts { get; set; }

        public Deadlift DeadliftAttempts { get; set; }
        
        public int CurrentMeetRanking { get; set; }

        public int MeetID { get; set; }

        public string MeetName { get; set; }
    }
}
