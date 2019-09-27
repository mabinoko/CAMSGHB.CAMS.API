using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppChkTodudetail
    {
        public long AppriId { get; set; }
        public string Aano { get; set; }
        public string Apno { get; set; }
        public string AccountNo { get; set; }
        public string Cifno { get; set; }
        public string Cifname { get; set; }
        public DateTime? DateAppointment { get; set; }
        public string SurveyUserId { get; set; }
        public string ApprCompany { get; set; }
        public string MonthCheck { get; set; }
        public DateTime? DateSurvey { get; set; }
        public DateTime? DateBsurvey { get; set; }
        public bool? CheckUnitDresult { get; set; }
        public bool? CheckUnitUresult { get; set; }
        public bool? CheckUnitBresult { get; set; }
        public bool? CheckUnitFresult { get; set; }
        public bool? CheckUnitLresult { get; set; }
        public bool? CheckUnitUlist { get; set; }
        public bool? CheckUnitOther { get; set; }
        public string Remark { get; set; }
        public string ApprisalUserId { get; set; }
        public bool? ApprisalApprove { get; set; }
        public DateTime? ApprisalDate { get; set; }
        public bool? ApproveError { get; set; }
        public bool? ApproveErrorDetail { get; set; }
        public bool? SendLetter { get; set; }
        public string SendLetterDetail { get; set; }
        public string BankUserApproveId { get; set; }
        public DateTime? BankChkReportDate { get; set; }
        public string ApproveHeadUserid { get; set; }
        public DateTime? ApproveHeadUseridDate { get; set; }
        public string HeadOfficeUserid { get; set; }
        public DateTime? HeadOfficeUserDate { get; set; }
    }
}
