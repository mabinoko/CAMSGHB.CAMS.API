using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppChkTodlbldetail
    {
        public long AppriLbdetailId { get; set; }
        public long? AppriId { get; set; }
        public string Aano { get; set; }
        public string UtilityP { get; set; }
        public long? UtilityResult { get; set; }
        public string BuildingRemark { get; set; }
    }
}
