using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class ApprisalConfirmPrice
    {
        public long ApprisalConfirmPriceId { get; set; }
        public string Cifname { get; set; }
        public string ApplNo { get; set; }
        public string ApprComp { get; set; }
        public string Aano { get; set; }
        public DateTime DateSend { get; set; }
        public string CollTypeCode { get; set; }
        public bool DetailCollCompare { get; set; }
        public bool CollCompareSimilar { get; set; }
        public bool SuitableFactor { get; set; }
        public bool NotCheckFromTel { get; set; }
        public bool CannotContact { get; set; }
        public bool NoTelphoneNo { get; set; }
        public bool NoInfoSameChk { get; set; }
        public string NoInfoSameChkDetail { get; set; }
        public bool NoInfoDiffChek { get; set; }
        public string NoInfoDiffChekDetail { get; set; }
        public bool LandPriceSuitable { get; set; }
        public bool PricePerSqrM { get; set; }
        public bool DepreciationSuitable { get; set; }
        public bool HaveoldAppPrice { get; set; }
        public DateTime LastAppDate { get; set; }
        public double? LastAppPrice { get; set; }
        public bool ChkwithGis { get; set; }
        public bool CompWithGis { get; set; }
        public bool AppraisalResult { get; set; }
        public string AppraisalResultDetail { get; set; }
        public string ChkwithData { get; set; }
        public double? AcceptPrice { get; set; }
        public string ApprisalUser { get; set; }
        public string AppraisalUserLead { get; set; }
        public string HeadAppraisalLine { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
