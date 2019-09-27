using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppraisalOwner
    {
        public int AppOwnId { get; set; }
        public long AppraisalId { get; set; }
        public int UserId { get; set; }
        public DateTime DateRecord { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
