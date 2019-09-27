using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class UserCompany
    {
        public UserCompany()
        {
            AppraisalAdminExNavigation = new HashSet<Appraisal>();
            AppraisalAssessmentExNavigation = new HashSet<Appraisal>();
            AppraisalSignNameExNavigation = new HashSet<Appraisal>();
            AppraisalSurveyExNavigation = new HashSet<Appraisal>();
            AppraisalValueInfoAdminExNavigation = new HashSet<AppraisalValueInfo>();
            AppraisalValueInfoAssessmentExNavigation = new HashSet<AppraisalValueInfo>();
            AppraisalValueInfoSignNameExNavigation = new HashSet<AppraisalValueInfo>();
            AppraisalValueInfoSurveyExNavigation = new HashSet<AppraisalValueInfo>();
        }

        public int UserId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string DepartId { get; set; }
        public string CompanyId { get; set; }
        public string BranchComp { get; set; }
        public string BranchArea { get; set; }

        public UserCompRole UserCompRole { get; set; }
        public ICollection<Appraisal> AppraisalAdminExNavigation { get; set; }
        public ICollection<Appraisal> AppraisalAssessmentExNavigation { get; set; }
        public ICollection<Appraisal> AppraisalSignNameExNavigation { get; set; }
        public ICollection<Appraisal> AppraisalSurveyExNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoAdminExNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoAssessmentExNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoSignNameExNavigation { get; set; }
        public ICollection<AppraisalValueInfo> AppraisalValueInfoSurveyExNavigation { get; set; }
    }
}
