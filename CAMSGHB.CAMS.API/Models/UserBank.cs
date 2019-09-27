using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class UserBank
    {
        public UserBank()
        {
            AppraisalAssessmentInNavigation = new HashSet<Appraisal>();
            AppraisalCommanderInNavigation = new HashSet<Appraisal>();
            AppraisalLeadInNavigation = new HashSet<Appraisal>();
            AppraisalSeniorInNavigation = new HashSet<Appraisal>();
            AppraisalValueInfoAssessmentInNavigation = new HashSet<AppraisalValueInfo>();
            AppraisalValueInfoCommanderInNavigation = new HashSet<AppraisalValueInfo>();
            AppraisalValueInfoLeadInNavigation = new HashSet<AppraisalValueInfo>();
            AppraisalValueInfoSeniorInNavigation = new HashSet<AppraisalValueInfo>();
            RoundRobinInternal = new HashSet<RoundRobinInternal>();
            UserBankRole = new HashSet<UserBankRole>();
        }

        public int UserId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string DepartId { get; set; }
        public string Brcode { get; set; }
        public string BrofficeCode { get; set; }
        public bool AppraisalGroup { get; set; }
        public int AppraisalTeamId { get; set; }
        public string ParentUserId { get; set; }

        public ICollection<Appraisal> AppraisalAssessmentInNavigation { get; set; }
        public ICollection<Appraisal> AppraisalCommanderInNavigation { get; set; }
        public ICollection<Appraisal> AppraisalLeadInNavigation { get; set; }
        public ICollection<Appraisal> AppraisalSeniorInNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoAssessmentInNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoCommanderInNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoLeadInNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoSeniorInNavigation { get; set; }
        public ICollection<RoundRobinInternal> RoundRobinInternal { get; set; }
        public ICollection<UserBankRole> UserBankRole { get; set; }
    }
}
