using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppChkTodlbbdetail
    {
        public long AppriLbdetailId { get; set; }
        public long? AppriId { get; set; }
        public string Aano { get; set; }
        public string BuildingPlan { get; set; }
        public long? BudildingResult { get; set; }
        public int? NumberBuilding { get; set; }
        public string BuildingRemark { get; set; }
    }
}
