using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppChkTodpaymentMain
    {
        public long AppChkTodpaymentMainId { get; set; }
        public string Aano { get; set; }
        public string Apno { get; set; }
        public string AccountNo { get; set; }
        public string AllocatorId { get; set; }
        public string Cifno { get; set; }
        public string Cifname { get; set; }
        public string AssessCompany { get; set; }
        public DateTime? LdateAppointment { get; set; }
        public DateTime? LdateSurvey { get; set; }
        public string Chktermtype { get; set; }
        public string Soi { get; set; }
        public string Road { get; set; }
        public string Provinceid { get; set; }
        public string Amphurid { get; set; }
        public string Tambonid { get; set; }
        public int? NumberPaymentTerm { get; set; }
        public string BankOrCompany { get; set; }
        public string Userjobsnow { get; set; }
    }
}
