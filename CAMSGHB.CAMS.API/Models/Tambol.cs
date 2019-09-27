using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Tambol
    {
        public long TambolId { get; set; }
        public string TambolName { get; set; }
        public string TambolCode { get; set; }
        public string AmphurCode { get; set; }
        public string ProvinceCode { get; set; }
        public bool Status { get; set; }
    }
}
