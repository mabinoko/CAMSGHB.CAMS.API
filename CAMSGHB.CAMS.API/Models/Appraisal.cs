using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Appraisal
    {
        public Appraisal()
        {
            Appointments = new HashSet<Appointments>();
            AppraisalOwner = new HashSet<AppraisalOwner>();
            AppraisalStatus = new HashSet<AppraisalStatus>();
            CollateralList = new HashSet<CollateralList>();
            CustomerList = new HashSet<CustomerList>();
            DocumentList = new HashSet<DocumentList>();
            FacilityList = new HashSet<FacilityList>();
            FileImg = new HashSet<FileImg>();
            SignName = new HashSet<SignName>();
        }

        public long AppraisalId { get; set; }
        public string Aano { get; set; }
        public string AccountNo { get; set; }
        public string ApplNo { get; set; }
        public long? ApplId { get; set; }
        public string AppraisalFlowGroup { get; set; }
        public string AppraisalJobType { get; set; }
        public double? ApprFee { get; set; }
        public long? ApprId { get; set; }
        public string ApprMethod { get; set; }
        public string ApprComp { get; set; }
        public string BrCode { get; set; }
        public long? ApprCompBranch { get; set; }
        public string BrContactNo { get; set; }
        public string BrOfficerCode { get; set; }
        public string BrOfficerName { get; set; }
        public string Cifname { get; set; }
        public string Cifno { get; set; }
        public string Dec { get; set; }
        public string DeccontactNo { get; set; }
        public string DecofficerCode { get; set; }
        public string DecofficerName { get; set; }
        public string LoanStatusCode { get; set; }
        public string PromotionName { get; set; }
        public string Province { get; set; }
        public string Source { get; set; }
        public string GhbStaffId { get; set; }
        public string UserCode { get; set; }
        public string SubPurpose { get; set; }
        public string CollTypeCode { get; set; }
        public string Status { get; set; }
        public string DeptType { get; set; }
        public double? SumTotalCollat { get; set; }
        public double? SumTotalCollatBefore { get; set; }
        public double? SumTotalCollatAfter { get; set; }
        public string ProgressStatus { get; set; }
        public int? AssessmentIn { get; set; }
        public int? SeniorIn { get; set; }
        public int? LeadIn { get; set; }
        public int? CommanderIn { get; set; }
        public int? BusinessIn { get; set; }
        public bool CommanderConfirm { get; set; }
        public int? SurveyEx { get; set; }
        public int? AssessmentEx { get; set; }
        public int? SignNameEx { get; set; }
        public int? AdminEx { get; set; }
        public DateTime? ReqDate { get; set; }
        public int? GuaranTee1 { get; set; }
        public bool GuaranTee1Confirm { get; set; }
        public int? GuaranTee2 { get; set; }
        public bool GuaranTee2Confirm { get; set; }
        public int? GuaranTee3 { get; set; }
        public bool GuaranTee3Confirm { get; set; }
        public int? OwnershipUserId { get; set; }

        public UserCompany AdminExNavigation { get; set; }
        public CompBranch ApprCompBranchNavigation { get; set; }
        public Company ApprCompNavigation { get; set; }
        public UserCompany AssessmentExNavigation { get; set; }
        public UserBank AssessmentInNavigation { get; set; }
        public UserBank CommanderInNavigation { get; set; }
        public UserBank LeadInNavigation { get; set; }
        public Progress ProgressStatusNavigation { get; set; }
        public UserBank SeniorInNavigation { get; set; }
        public UserCompany SignNameExNavigation { get; set; }
        public UserCompany SurveyExNavigation { get; set; }
        public ApprisalConfirmPrice ApprisalConfirmPrice { get; set; }
        public Eject Eject { get; set; }
        public ICollection<Appointments> Appointments { get; set; }
        public ICollection<AppraisalOwner> AppraisalOwner { get; set; }
        public ICollection<AppraisalStatus> AppraisalStatus { get; set; }
        public ICollection<CollateralList> CollateralList { get; set; }
        public ICollection<CustomerList> CustomerList { get; set; }
        public ICollection<DocumentList> DocumentList { get; set; }
        public ICollection<FacilityList> FacilityList { get; set; }
        public ICollection<FileImg> FileImg { get; set; }
        public ICollection<SignName> SignName { get; set; }
    }
}
