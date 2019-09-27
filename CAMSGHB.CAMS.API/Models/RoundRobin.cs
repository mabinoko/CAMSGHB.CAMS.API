using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class RoundRobin
    {
        public long RoundRobinId { get; set; }
        public long ApprTeamId { get; set; }
        public long UserId { get; set; }
        public int RoundType { get; set; }
    }
}
