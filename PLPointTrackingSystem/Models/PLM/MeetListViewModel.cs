using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Models.PLM
{
    public class MeetListViewModel
    {
        public List<Meet> MembersMeets { get; set; }
        public bool MemberRoleUpdated { get; set; }
    }
}
