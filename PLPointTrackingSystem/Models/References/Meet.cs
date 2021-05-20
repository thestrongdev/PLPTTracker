using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem
{
    public class Meet
    {
        public string MeetID { get; set; }
        public string MeetName { get; set; }
        public string MeetType { get; set; } //local, state, regional, national, world

        public string MeetFed { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetDate { get; set; }

        public string MeetCity { get; set; }

        public string MeetState { get; set; }

        public string MeetVenue { get; set; }

        public bool ScoringComplete { get; set; }
    }
}
