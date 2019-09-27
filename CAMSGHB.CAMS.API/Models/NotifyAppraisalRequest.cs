using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{ 
    public partial class NotifyAppraisalRequest
    {
        public long Id { get; set; }
        public string Apno { get; set; }
        public string Apikey { get; set; }
        public string PkgType { get; set; }
        public string Cctype { get; set; }
        public string UserCode { get; set; }
        public string ApprMethod { get; set; }
        public string Mode { get; set; }
        public string TransId { get; set; }
        public int Status { get; set; }
    }
}
