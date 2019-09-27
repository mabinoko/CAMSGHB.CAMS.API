using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class FacilityList
    {
        public long FacilityListId { get; set; }
        public string LoanPurp { get; set; }
        public string CampaignCode { get; set; }
        public bool Status { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
