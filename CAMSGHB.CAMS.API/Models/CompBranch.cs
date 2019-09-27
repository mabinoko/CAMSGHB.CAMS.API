using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class CompBranch
    {
        public CompBranch()
        {
            Appraisal = new HashSet<Appraisal>();
            AppraisalValueInfo = new HashSet<AppraisalValueInfo>();
        }

        public long CompBranchId { get; set; }
        public string BranchName { get; set; }
        public string AddNo { get; set; }
        public string ViilageNo { get; set; }
        public string Alley { get; set; }
        public string Road { get; set; }
        public string TambolCode { get; set; }
        public string AmphurCode { get; set; }
        public string ProvinceCode { get; set; }
        public string Telephone { get; set; }
        public string FaxNo { get; set; }
        public bool CompBranchStatus { get; set; }
        public string CompanyId { get; set; }
        public string Remark { get; set; }

        public ICollection<Appraisal> Appraisal { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfo { get; set; }
    }
}
