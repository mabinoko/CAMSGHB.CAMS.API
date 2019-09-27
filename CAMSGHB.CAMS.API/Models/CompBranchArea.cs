using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class CompBranchArea
    {
        public long CompBranchAreaId { get; set; }
        public long CompBranchId { get; set; }
        public string CompanyId { get; set; }
        public string ProvinceCode { get; set; }
    }
}
