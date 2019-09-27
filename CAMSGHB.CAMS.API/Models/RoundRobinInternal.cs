using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class RoundRobinInternal
    {
        public long RoundRobinInternalId { get; set; }
        public int AppraisalTeamId { get; set; }
        public int UserId { get; set; }
        public bool StateRr { get; set; }

        public AppraisalTeam AppraisalTeam { get; set; }
        public UserBank User { get; set; }
    }
}
