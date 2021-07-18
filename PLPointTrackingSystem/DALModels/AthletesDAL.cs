using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.DALModels
{
    public class AthletesDAL
    {
        //DATA UPLOADED VIA MEET DIRECTOR OR WHOMEVER
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AthleteDBID { get; set; }
        public string Club { get; set; }
        public string MemberID { get; set; }
        public string WeightClass { get; set; }
        public string Name { get; set; } 
        public string Gender { get; set; }
        public string Age { get; set; } 
        public string LifterDivisions { get; set; }

        public string Squat_Opener { get; set; }

        public string Bench_Opener { get; set; }

        public string Deadlift_Opener { get; set; }

        //OBTAINED WHILE SCORING
        public double Wilks { get; set; }
        public double Total { get; set; }
        public double Squat_Attempt1 { get; set; }
        public double Squat_Attempt2 { get; set; }
        public double Squat_Attempt3 { get; set; }
        public double Bench_Attempt1 { get; set; }
        public double Bench_Attempt2 { get; set; }
        public double Bench_Attempt3 { get; set; }
        public double Dead_Attempt1 { get; set; }
        public double Dead_Attempt2 { get; set; }
        public double Dead_Attempt3 { get; set; }

        public int CurrentMeetRanking { get; set; }

        public string WeighIn { get; set; }


        //WHICH MEET?? NEED TO ADD A MEET FIRST!!

        [ForeignKey("MeetID")]
        public int? MeetID { get; set; }

        public MeetDAL Meet { get; set; }
    }
}
