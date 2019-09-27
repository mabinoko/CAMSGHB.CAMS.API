using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class CollateralList
    {
        public CollateralList()
        {
            AppraisalValueInfo = new HashSet<AppraisalValueInfo>();
        }

        public long CollateralListId { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public string CollatType { get; set; }
        public string DevCode { get; set; }
        public string DocChecklistImpact { get; set; }
        public long HostCollatId { get; set; }
        public string LimitImpact { get; set; }
        public string NonLimitImpact { get; set; }
        public string ProjectCode { get; set; }
        public string SubCategory { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
        public Appraisalnfo Appraisalnfo { get; set; }
        public CollatReinfo CollatReinfo { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfo { get; set; }
    }
}
