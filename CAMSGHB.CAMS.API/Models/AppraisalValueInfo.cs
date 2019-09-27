using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class AppraisalValueInfo
    {
        public long AppraisalValueInfoId { get; set; }
        public long DetCollatId { get; set; }
        public long HostCollatId { get; set; }
        public string AppealCase { get; set; }
        public string AppealCaseRem { get; set; }
        public long? ApprId { get; set; }
        public double? ApprValue { get; set; }
        public double? AreaOfCollatAssess { get; set; }
        public string AssessBy { get; set; }
        public string AssessCompany { get; set; }
        public double? AvofBuildingLease { get; set; }
        public double? AvofLandLease { get; set; }
        public double? AvofOrigBuilding { get; set; }
        public string BankEmpId { get; set; }
        public string BankEmpName { get; set; }
        public double? CollatPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? DateAssess { get; set; }
        public DateTime? DateContact { get; set; }
        public DateTime? DateReceive { get; set; }
        public DateTime? DateRecord { get; set; }
        public DateTime? DateRequest { get; set; }
        public DateTime? DateRequestEdit { get; set; }
        public DateTime? DateSubmission { get; set; }
        public DateTime? DateSurvey { get; set; }
        public string DelayCause { get; set; }
        public double? LandPriceAssess { get; set; }
        public double? LivSpace { get; set; }
        public double? NetValue { get; set; }
        public string Other { get; set; }
        public double? PriceBuildingRevRepair { get; set; }
        public string ReviewAv3m { get; set; }
        public string ReviewAv3mrem { get; set; }
        public string ReviewAvlt3m { get; set; }
        public string ReviewAvlt3mrem { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string ReviewOther { get; set; }
        public string ReviewRem { get; set; }
        public string SamplingCase { get; set; }
        public string SamplingCaseRem { get; set; }
        public double? TotPriceCollat { get; set; }
        public double? TotValueLeaseBuilding { get; set; }
        public double? TotValueLeaseLand { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long? ValueD { get; set; }
        public DateTime? DatePostpone { get; set; }
        public DateTime? DateAppointments { get; set; }
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
        public long? ApprCompBranch { get; set; }
        public long CollateralListId { get; set; }

        public UserCompany AdminExNavigation { get; set; }
        public CompBranch ApprCompBranchNavigation { get; set; }
        public UserCompany AssessmentExNavigation { get; set; }
        public UserBank AssessmentInNavigation { get; set; }
        public CollateralList CollateralList { get; set; }
        public UserBank CommanderInNavigation { get; set; }
        public UserBank LeadInNavigation { get; set; }
        public UserBank SeniorInNavigation { get; set; }
        public UserCompany SignNameExNavigation { get; set; }
        public UserCompany SurveyExNavigation { get; set; }
    }
}
