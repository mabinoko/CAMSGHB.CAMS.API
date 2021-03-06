﻿using System;
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
        [Key]
        [Required]
        public long RAppraisalID { get; set;}
        public long AppraisalID {get; set;}
        [StringLength(80)]
        public string ProjectName {get; set;}
        [StringLength(10)]
        public string ProjectCode {get; set;}
        public int MonthCheck {get; set;}
        public int YearCheck {get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BankDateCheck {get; set;}

        [StringLength(1)]
        public string RJobType {get; set;}
        [StringLength(10)]
        public string SubCategory {get; set;}
        public bool? Landplot {get; set;}
        public bool? RoomPlan {get; set;}
        public bool? ProjPlan {get; set;}
        public bool? House_Roomno {get; set;}
        public bool? Pictures {get; set;}
        [StringLength(244)]
        public string OtherDocument {get; set;}
        [StringLength(25)]
        public string AppraisalBankid {get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppraisalDate {get; set;}
        [StringLength(25)]
        public string ChkReportBankid {get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ChkReportdate {get; set;}
        [StringLength(25)]
        public string AssistantAppDirector {get; set;}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AssistDate {get; set;}
    }

    public class SamplingworkFTMainGetModel
    {
        [Key]
        public long RAppraisalID { get; set; }
        public long AppraisalID { get; set; }
        [StringLength(80)]
        public string ProjectName { get; set; }
        [StringLength(10)]
        public string ProjectCode { get; set; }
        public int MonthCheck { get; set; }
        public int YearCheck { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BankDateCheck { get; set; }

        [StringLength(1)]
        public string RJobType { get; set; }
        [StringLength(10)]
        public string SubCategory { get; set; }
        public bool? Landplot { get; set; }
        public bool? RoomPlan { get; set; }
        public bool? ProjPlan { get; set; }
        public bool? House_Roomno { get; set; }
        public bool? Pictures { get; set; }
        [StringLength(244)]
        public string OtherDocument { get; set; }
        [StringLength(25)]
        public string AppraisalBankid { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppraisalDate { get; set; }
        [StringLength(25)]
        public string ChkReportBankid { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ChkReportdate { get; set; }
        [StringLength(25)]
        public string AssistantAppDirector { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AssistDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? StratAppraisalDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndAppraisalDate { get; set; }

        [Range(typeof(int), "0", "100")]
        public int percent { get; set; }
    }

    public class SamplingworkFTMainPOstModel
    {
        
        public long AppraisalID { get; set; }
        [StringLength(80)]
        public string ProjectName { get; set; }
        [StringLength(10)]
        public string ProjectCode { get; set; }
        public int MonthCheck { get; set; }
        public int YearCheck { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BankDateCheck { get; set; }

        [StringLength(1)]
        public string RJobType { get; set; }
        [StringLength(10)]
        public string SubCategory { get; set; }
        public bool? Landplot { get; set; }
        public bool? RoomPlan { get; set; }
        public bool? ProjPlan { get; set; }
        public bool? House_Roomno { get; set; }
        public bool? Pictures { get; set; }
        [StringLength(244)]
        public string OtherDocument { get; set; }
        [StringLength(25)]
        public string AppraisalBankid { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppraisalDate { get; set; }
        [StringLength(25)]
        public string ChkReportBankid { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ChkReportdate { get; set; }
        [StringLength(25)]
        public string AssistantAppDirector { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AssistDate { get; set; }
    }
}
