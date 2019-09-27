using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class RoundRobinComp
    {
        public int RoundRobinAreaId { get; set; }
        public int CompanyId { get; set; }
        public string ProvinceId { get; set; }
        public bool StateRr { get; set; }
    }
}
