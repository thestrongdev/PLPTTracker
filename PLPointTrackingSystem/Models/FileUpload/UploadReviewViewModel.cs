using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Models.PLM
{
    public class UploadReviewViewModel
    {
        public List<Athlete> FileData { get; set; }

        public bool FileUploaded { get; set; }

        public bool FileDataDeleted { get; set; }
    }
}
