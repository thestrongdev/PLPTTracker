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

        //OBTAINED WHILE SCORING
        public int Wilks { get; set; }
        public int Total { get; set; }
        public int Squat_Attempt1 { get; set; }
        public int Squat_Attempt2 { get; set; }
        public int Squat_Attempt3 { get; set; }
        public int Bench_Attempt1 { get; set; }
        public int Bench_Attempt2 { get; set; }
        public int Bench_Attempt3 { get; set; }
        public int Dead_Attempt1 { get; set; }
        public int Dead_Attempt2 { get; set; }
        public int Dead_Attempt3 { get; set; }
    }
}
