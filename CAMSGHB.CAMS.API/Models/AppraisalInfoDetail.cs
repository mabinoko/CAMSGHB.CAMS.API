using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppraisalInfoDetail
    {
        public long AppraisalInfoDetailId { get; set; }
        public int? NoList { get; set; }
        public int? List { get; set; }
        public double? Area { get; set; }
        public double? Price { get; set; }
        public double? Amount { get; set; }
        public bool Status { get; set; }
        public long AppraisalnfoId { get; set; }

        public Appraisalnfo Appraisalnfo { get; set; }
    }
}
