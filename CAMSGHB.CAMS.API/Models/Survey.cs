using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Survey
    {
        public long SurveyId { get; set; }
        public bool Status { get; set; }
        public DateTime? DateSurvey { get; set; }
        public DateTime? DateAssess { get; set; }
        public DateTime? DateRecord { get; set; }
        public DateTime? DateReceive { get; set; }
        public int SurStatus { get; set; }
        public long UserSurvayId { get; set; }

        public User UserSurvay { get; set; }
    }
}
