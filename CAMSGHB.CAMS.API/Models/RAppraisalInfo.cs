using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static CAMSGHB.CAMS.API.Enum.EnumMessage;

namespace CAMSGHB.CAMS.API.Models
{
    [Table("RAppraisalInfo")]
    public class RAppraisalInfo
    {
        [Key]
        [Required]
        public long RAppraisalID { get; set; }

        public long AppraisalID { get; set; }
        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompCheck { get; set; }
        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BankDateCheck { get; set; }
        [StringLength(120)]
        public string CIFName { get; set; }
        public int MonthCheck { get; set; }
        public int YearCheck { get; set; }
        public long APPNO { get; set; }
        [StringLength(80)]
        public string ProjectName { get; set; }
        [StringLength(40)]
        public string Houseno { get; set; }
        [StringLength(120)]
        public string Street { get; set; }
        [StringLength(10)]
        public string SubDistrict { get; set; }
        [StringLength(10)]
        public string District { get; set; }
        [StringLength(40)]
        public string Province { get; set; }

        public string LandLocationDetail { get; set; }
        public string Publicutility { get; set; }
        public string Otherdetail { get; set; }


        [StringLength(1)]
        public string DocumentType { get; set; }
        [StringLength(40)]
        public string DocumentNo { get; set; }
        public int AreaNgan { get; set; }
        public int AreaRai { get; set; }
        [Range(0, 9999999999999999999.99)]
        public double AreaWa { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LCAppraisalUPrice { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LCAppraisalPrice { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LBAppraisalUPrice { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LBAppraisalPrice { get; set; }

        public bool? LBPriceSuitable { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LDAppraisalPrice { get; set; }

        public bool? LHigh_lower { get; set; }
        [Range(0, 9999999999.99)]
        public decimal LDiffAppraisalPercent { get; set; }
        [Range(0, 9999999999.99)]
        public decimal LAcceptPrice { get; set; }

        [StringLength(40)]
        public string BuildingModel { get; set; }
        public int NoOfFloor { get; set; }
        public bool?  DocuementAttach { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BCAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BBAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BDAppraisalPrice { get; set; }

        public bool? BHigh_lower { get; set; }
        [Range(0, 9999999999.99)]
        public decimal BDiffAppraisalPercent { get; set; }
        public bool?  BPriceSuitable { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BAcceptPrice { get; set; }


        public bool? TPriceSuitable { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal TCAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal TBAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal TDAppraisalPrice { get; set; }

        public bool? THigh_lower { get; set; }
        [Range(0, 9999999999.99)]
        public decimal TDiffAppraisalPercent { get; set; }
        [StringLength(200)]
        public string AppraisalSummary { get; set; }


        public bool? AppraisalList { get; set; }
        [StringLength(25)]
        public string AppraisalBankid { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppraisalDate { get; set; }


        public bool? chkmistake { get; set; }
        [StringLength(200)]
        public string mistakedetail { get; set; }
        public bool? warningletter { get; set; }
        [StringLength(200)]
        public string warningdetail { get; set; }
        [StringLength(25)]
        public string Headteam { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? datecheck { get; set; }

        [StringLength(25)]
        public string AssistantAppDirector { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AssistDate { get; set; }

        [StringLength(25)]
        public string AppDirector { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppDireDate { get; set; }

}

    public class RAppraisalInfoGetModel
    {

        public long RAppraisalID { get; set; }

        public long AppraisalID { get; set; }
        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompCheck { get; set; }
        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BankDateCheck { get; set; }
        [StringLength(120)]
        public string CIFName { get; set; }
        public int MonthCheck { get; set; }
        public int YearCheck { get; set; }
        public long APPNO { get; set; }
        [StringLength(80)]
        public string ProjectName { get; set; }
        [StringLength(40)]
        public string Houseno { get; set; }
        [StringLength(120)]
        public string Street { get; set; }
        [StringLength(10)]
        public string SubDistrict { get; set; }
        [StringLength(10)]
        public string District { get; set; }
        [StringLength(40)]
        public string Province { get; set; }

        public string LandLocationDetail { get; set; }
        public string Publicutility { get; set; }
        public string Otherdetail { get; set; }


        [StringLength(1)]
        public string DocumentType { get; set; }
        [StringLength(40)]
        public string DocumentNo { get; set; }
        public int AreaNgan { get; set; }
        public int AreaRai { get; set; }
        [Range(0, 9999999999999999999.99)]
        public double AreaWa { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LCAppraisalUPrice { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LCAppraisalPrice { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LBAppraisalUPrice { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LBAppraisalPrice { get; set; }

        public bool? LBPriceSuitable { get; set; }
        [Range(0, 9999999999999999999.99)]
        public decimal LDAppraisalPrice { get; set; }

        public bool? LHigh_lower { get; set; }
        [Range(0, 9999999999.99)]
        public decimal LDiffAppraisalPercent { get; set; }
        [Range(0, 9999999999.99)]
        public decimal LAcceptPrice { get; set; }

        [StringLength(40)]
        public string BuildingModel { get; set; }
        public int NoOfFloor { get; set; }
        public bool? DocuementAttach { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BCAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BBAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BDAppraisalPrice { get; set; }

        public bool? BHigh_lower { get; set; }
        [Range(0, 9999999999.99)]
        public decimal BDiffAppraisalPercent { get; set; }
        public bool? BPriceSuitable { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal BAcceptPrice { get; set; }


        public bool? TPriceSuitable { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal TCAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal TBAppraisalPrice { get; set; }
        [Range(0, 999999999999999999.99)]
        public decimal TDAppraisalPrice { get; set; }

        public bool? THigh_lower { get; set; }
        [Range(0, 9999999999.99)]
        public decimal TDiffAppraisalPercent { get; set; }
        [StringLength(200)]
        public string AppraisalSummary { get; set; }


        public bool? AppraisalList { get; set; }
        [StringLength(25)]
        public string AppraisalBankid { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppraisalDate { get; set; }


        public bool? chkmistake { get; set; }
        [StringLength(200)]
        public string mistakedetail { get; set; }
        public bool? warningletter { get; set; }
        [StringLength(200)]
        public string warningdetail { get; set; }
        [StringLength(25)]
        public string Headteam { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? datecheck { get; set; }

        [StringLength(25)]
        public string AssistantAppDirector { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AssistDate { get; set; }

        [StringLength(25)]
        public string AppDirector { get; set; }

        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateFormatConverter), "dd/MM/yyyy")]
          [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppDireDate { get; set; }

    }
}
