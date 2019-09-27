using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Notification
    {
        public long Id { get; set; }
        public long ApplId { get; set; }
        public string Apno { get; set; }
        public string Apikey { get; set; }
        public string UserCode { get; set; }
        public string Message { get; set; }
        public long TransId { get; set; }
        public DateTime? Date { get; set; }
        public int Status { get; set; }
    }
}
