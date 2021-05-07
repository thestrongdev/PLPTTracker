using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.DALModels
{
    public class MemberDAL
    {
        public string Role { get; set; }

        [ForeignKey("Meet")]
        public int MeetID { get; set; }

        public MeetDAL Meet { get; set; }
    }
}
