using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppraisalJobType
    {
        public int AppraisalJobTypeId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleCode { get; set; }
        public string AppraisalJobType1 { get; set; }
        public string AppraisalJobTypeName { get; set; }
        public bool Status { get; set; }
    }
}
