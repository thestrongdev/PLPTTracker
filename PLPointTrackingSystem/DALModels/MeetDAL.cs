using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.DALModels
{
    public class MeetDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MeetID { get; set; }
        public string MeetName { get; set; }
        public string MeetType { get; set; } //local, state, regional, national, world

        public string MeetFed { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetDate { get; set; }

        public string MeetCity { get; set; }

        public string MeetState { get; set; }

        public string MeetVenue { get; set; }

        public bool ScoringComplete { get; set; }

        [ForeignKey("AspNetUsers")]
        public string Id { get; set; }

        public IdentityUser User { get; set; }
    }
}
