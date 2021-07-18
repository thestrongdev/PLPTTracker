using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Models.PLM
{
    public class MeetInfoFormViewModel
    {
        public string MeetName { get; set; }
        public string MeetType { get; set; } //local, state, regional, national, world

        public string MeetFed { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetDate { get { return this.dateCreated.HasValue ? this.dateCreated.Value : DateTime.Now; } set { } }

        private DateTime? dateCreated = null;

        public string MeetCity { get; set; }

        public string MeetState { get; set; }

        public string MeetVenue { get; set; }

        public int MeetZip { get; set; }


    }
}
