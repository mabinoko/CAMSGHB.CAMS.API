using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class CondAssetOutdoor
    {
        public string CondAssetOutdoorId { get; set; }
        public string AssetOutdoorDetail { get; set; }
        public double? AssetOutdoorSpace { get; set; }
        public string Status { get; set; }
        public long AppraisalInfoId { get; set; }

        public Appraisalnfo AppraisalInfo { get; set; }
    }
}
