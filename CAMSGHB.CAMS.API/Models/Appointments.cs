using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Appointments
    {
        public long AppointmentsId { get; set; }
        public DateTime? DateAppoint { get; set; }
        public DateTime? DatePostpone { get; set; }
        public string CauseDelay { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateOn { get; set; }
        public int CreateByUserId { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
