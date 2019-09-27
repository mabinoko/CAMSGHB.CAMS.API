using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppChkTodlbdetail
    {
        public long AppriId { get; set; }
        public string Aano { get; set; }
        public string Apno { get; set; }
        public string AccountNo { get; set; }
        public string Cifno { get; set; }
        public string Cifname { get; set; }
        public DateTime? DateAppointment { get; set; }
        public string SurveyUserId { get; set; }
        public DateTime? DateSurvey { get; set; }
        public string Remark { get; set; }
        public string BankUserApproveId { get; set; }
        public DateTime? BankChkReportDate { get; set; }
        public string ApproveUserId { get; set; }
        public DateTime? BankApproveDate { get; set; }
    }
}
