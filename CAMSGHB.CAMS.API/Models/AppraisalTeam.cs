using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppraisalTeam
    {
        public AppraisalTeam()
        {
            RoundRobinInternal = new HashSet<RoundRobinInternal>();
        }

        public int AppraisalTeamId { get; set; }
        public string AppraisalTeamName { get; set; }
        public int AppraisalTeamLead { get; set; }
        public int AppraisalTeamHead { get; set; }

        public ICollection<RoundRobinInternal> RoundRobinInternal { get; set; }
    }
}
