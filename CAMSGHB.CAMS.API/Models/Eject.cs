using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Eject
    {
        public long EjectId { get; set; }
        public long AppraisalId { get; set; }
        public string Remark { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
