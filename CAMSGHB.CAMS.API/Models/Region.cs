using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Region
    {
        public Region()
        {
            Company = new HashSet<Company>();
        }

        public long RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public string RegionDesc { get; set; }
        public bool RegionStatus { get; set; }

        public ICollection<Company> Company { get; set; }
    }
}
