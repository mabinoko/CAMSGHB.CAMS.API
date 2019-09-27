using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppChkTpayment
    {
        public long AppChkTfpaymentId { get; set; }
        public long? AppriId { get; set; }
        public string Aano { get; set; }
        public string Apno { get; set; }
        public string AccountNo { get; set; }
        public string Cifno { get; set; }
        public string Cifname { get; set; }
        public string AssessCompany { get; set; }
        public string DevCode { get; set; }
        public DateTime? DateAppointment { get; set; }
        public bool? Encroach { get; set; }
        public bool? DeedNs03 { get; set; }
        public string DeedNs03No { get; set; }
        public string BuildingType { get; set; }
        public long? NoOfFloor { get; set; }
        public bool? CBuildingplan { get; set; }
        public bool? ChangeIncDec { get; set; }
        public string ChangeOther { get; set; }
        public string DocPermitted { get; set; }
        public int? CheckNo { get; set; }
        public long? Wfoundation { get; set; }
        public long? Pfoundateion { get; set; }
        public long? Wconstruction { get; set; }
        public long? Pconstruction { get; set; }
        public long? Wsroof { get; set; }
        public long? Psroof { get; set; }
        public long? Wroof { get; set; }
        public long? Proof { get; set; }
        public long? Wframe { get; set; }
        public long? Pframe { get; set; }
        public long? Wwall { get; set; }
        public long? Pwall { get; set; }
        public long? Wfloor { get; set; }
        public long? Pfloor { get; set; }
        public long? Wdwc { get; set; }
        public long? Pdwc { get; set; }
        public long? Wutility { get; set; }
        public long? Putility { get; set; }
        public long? Wpaint { get; set; }
        public long? Ppaint { get; set; }
        public long? TotalCalculate { get; set; }
        public string Remark { get; set; }
        public string SurveyId { get; set; }
        public DateTime? DateSurvey { get; set; }
        public string AppraisalId { get; set; }
        public DateTime? DateAppraisal { get; set; }
        public string AuthorizeId { get; set; }
        public DateTime? DateAuthorize { get; set; }
        public string Memberof { get; set; }
        public string Membertype { get; set; }
        public string Memberno { get; set; }
        public string Appraisalmain { get; set; }
        public string Appraisaltype { get; set; }
        public string Appraisalno { get; set; }
        public string Authorizedocno { get; set; }
        public long? Creditlimit { get; set; }
        public long? Totalwithdraw { get; set; }
        public int? Approvepaymentno { get; set; }
        public string ResultConstruc { get; set; }
        public string BankUserApproveId { get; set; }
        public DateTime? BankChkReportDate { get; set; }
        public string ApproveColDetail { get; set; }
        public string ApproveUserId { get; set; }
        public DateTime? BankApproveDate { get; set; }
        public string Chktermtype { get; set; }
        public int? PaymentTerm { get; set; }
        public string BankSurvey { get; set; }
        public DateTime? BankSurveyDate { get; set; }
    }
}
