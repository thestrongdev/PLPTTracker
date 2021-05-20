using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.DALModels
{
    public class MemberDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberID { get; set; }
        public string Role { get; set; }

        [ForeignKey("AspNetUsers")]
        public string Id { get; set; }

        public IdentityUser User { get; set; }
    }
}
