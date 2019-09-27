using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppChkTfpaymentMain
    {
        public long AppChkTfpaymentMainId { get; set; }
        public string Aano { get; set; }
        public string Apno { get; set; }
        public string AccountNo { get; set; }
        public string Cifno { get; set; }
        public string Cifname { get; set; }
        public string AssessCompany { get; set; }
        public string DevCode { get; set; }
        public DateTime? LdateAppointment { get; set; }
        public DateTime? LdateSurvey { get; set; }
        public int? NoOfFloorFlat { get; set; }
        public string LandNo { get; set; }
        public string Provinceid { get; set; }
        public string Amphurid { get; set; }
        public string Tambonid { get; set; }
        public int? Landarearai { get; set; }
        public int? Ngan { get; set; }
        public long? Wa { get; set; }
        public bool? Encroach { get; set; }
        public bool? CBuildingplan { get; set; }
        public long? Creditlimit { get; set; }
        public long? Totalwithdraw { get; set; }
        public string Chktermtype { get; set; }
        public int? NumberPaymentTerm { get; set; }
        public string BankOrCompany { get; set; }
        public string Userjobsnow { get; set; }
    }
}
