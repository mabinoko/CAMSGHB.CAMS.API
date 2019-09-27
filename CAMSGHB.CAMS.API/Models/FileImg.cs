using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class FileImg
    {
        public long Imgid { get; set; }
        public long AppraisalId { get; set; }
        public string Typefile { get; set; }
        public string FileUrl { get; set; }
        public string Hostdev { get; set; }
        public string Hostpublish { get; set; }
        public bool Status { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
