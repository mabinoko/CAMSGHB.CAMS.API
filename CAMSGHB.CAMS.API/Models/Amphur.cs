using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Amphur
    {
        public long AmphurId { get; set; }
        public string AmphurName { get; set; }
        public string AmphurCode { get; set; }
        public string ProvinceCode { get; set; }
        public bool Status { get; set; }
    }
}
