using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Province
    {
        public long ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }
        public bool Status { get; set; }
    }
}
