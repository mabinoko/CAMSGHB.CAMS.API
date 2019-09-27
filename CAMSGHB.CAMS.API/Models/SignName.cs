using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class SignName
    {
        public long SignNameId { get; set; }
        public DateTime? SignDate { get; set; }
        public long UserId { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
