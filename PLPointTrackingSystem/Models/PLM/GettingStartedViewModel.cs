﻿using PLPointTrackingSystem.Models.References;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Models.PLM
{
    public class GettingStartedViewModel
    {
        public Meet MeetData { get; set; }
       

        //[Required(ErrorMessage = "Please select file")]
        ////[FileExt(Allow = ".xls,.xlsx", ErrorMessage = "Only excel file")]
        //public HttpPostedFileBase file { get; set; }

    }
}
