using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppraisalStatus
    {
        public long AppraisalStatusId { get; set; }
        public string AppraisalName { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
