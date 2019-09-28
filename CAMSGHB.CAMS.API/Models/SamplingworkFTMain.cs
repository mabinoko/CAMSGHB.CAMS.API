using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAMSGHB.CAMS.API.Models
{
    [Table("SamplingworkFTMain")]
    public class SamplingworkFTMain
    {
       public long RAppraisalID { get; set;}
       public long AppraisalID {get; set;}
       [StringLength(80)]
       public string ProjectName {get; set;}
       [StringLength(10)]
       public string ProjectCode {get; set;}
       public int MonthCheck {get; set;}
       public int YearCheck {get; set;}
       public DateTime? BankDateCheck {get; set;}
       [StringLength(1)]
       public char RJobType {get; set;}
       [StringLength(10)]
       public string SubCategory {get; set;}
       public bool Landplot {get; set;}
       public bool RoomPlan {get; set;}
       public bool ProjPlan {get; set;}
       public bool House_Roomno {get; set;}
       public bool Pictures {get; set;}
       [StringLength(244)]
       public string OtherDocument {get; set;}
       [StringLength(25)]
       public string AppraisalBankid {get; set;}
       public DateTime? AppraisalDate {get; set;}
       [StringLength(25)]
       public string ChkReportBankid {get; set;}
       public DateTime? ChkReportdate {get; set;}
       [StringLength(25)]
       public string AssistantAppDirector {get; set;}
       public DateTime? AssistDate {get; set;}
    }
}
