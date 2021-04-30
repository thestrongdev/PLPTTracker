using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.DALModels
{
    public class UploadTestDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public string Age { get; set; }

        public string Food { get; set; }
    }
}
