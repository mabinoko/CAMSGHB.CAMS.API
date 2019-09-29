using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CAMSGHB.CAMS.API.Models
{
    [Table("SamplingworkLTF")]
    [DataContract]
    public class SamplingworkLTF
    {
        [Key]
        [Required]
        public long RAppraisalID { get; set; }
        public long AppraisalID { get; set; }
        
        public char RJobType { get; set; }
        [StringLength(80)]
        public string ProjectName { get; set; }
        [StringLength(10)]
        public string ProjectCode { get; set; }
        [StringLength(120)]
        public string CIFName { get; set; }
        [StringLength(19)]
        public string AANo { get; set; }
        [StringLength(100)]
        public string APNO { get; set; }
        [StringLength(40)]
        public string ConstDeedNo { get; set; }
        [StringLength(25)]
        public string LandNo { get; set; }
        [StringLength(10)]
        public string SubCategory { get; set; }
        [StringLength(80)]
        public string SplitEntry { get; set; }
        [StringLength(80)]
        public string Street { get; set; }
        [StringLength(10)]
        public string SubDistrict { get; set; }
        [StringLength(10)]
        public string District { get; set; }
        [StringLength(40)]
        public string Province { get; set; }
        [StringLength(50)]
        public string AssessCompany { get; set; }
        public int? MonthCheck { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? LastDateSurvey { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BankDateCheck { get; set; }
        public bool? checkdevland { get; set; }
        public bool? chkpublicutility { get; set; }
        public bool? chkconstruction { get; set; }
        public bool? chkfacility { get; set; }
        public bool? chklandlocation { get; set; }
        public bool? surveybanklist { get; set; }
        public bool? appraisalbanklist { get; set; }
        public bool? Ownerbanklist { get; set; }
        public bool? Otherdetail { get; set; }
        public string Remark { get; set; }
        [StringLength(200)]
        public string Buildingplan { get; set; }
        [StringLength(200)]
        public string Other { get; set; }

        public bool? Appraisalchk { get; set; }
        [StringLength(200)]
        public string CommentDetail { get; set; }
        [StringLength(25)]
        public string AppraisalBankid { get; set; }

        [DataType(DataType.Date)]
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
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? datecheck { get; set; }
        [StringLength(25)]
        public string AssistantAppDirector { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AssistDate { get; set; }
        [StringLength(25)]
        public string AppDirector { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppDireDate { get; set; }

        [StringLength(255)]
        public string reportdetail { get; set; }
    }

    [DataContract]
    public class SamplingworkLTFGetModel
    {
        [Key]
        public long RAppraisalID { get; set; }
        public long AppraisalID { get; set; }

        public char RJobType { get; set; }
        [StringLength(80)]
        public string ProjectName { get; set; }
        [StringLength(10)]
        public string ProjectCode { get; set; }
        [StringLength(120)]
        public string CIFName { get; set; }
        [StringLength(19)]
        public string AANo { get; set; }
        [StringLength(100)]
        public string APNO { get; set; }
        [StringLength(40)]
        public string ConstDeedNo { get; set; }
        [StringLength(25)]
        public string LandNo { get; set; }
        [StringLength(10)]
        public string SubCategory { get; set; }
        [StringLength(80)]
        public string SplitEntry { get; set; }
        [StringLength(80)]
        public string Street { get; set; }
        [StringLength(10)]
        public string SubDistrict { get; set; }
        [StringLength(10)]
        public string District { get; set; }
        [StringLength(40)]
        public string Province { get; set; }
        [StringLength(50)]
        public string AssessCompany { get; set; }
        public int? MonthCheck { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? LastDateSurvey { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BankDateCheck { get; set; }
        public bool? checkdevland { get; set; }
        public bool? chkpublicutility { get; set; }
        public bool? chkconstruction { get; set; }
        public bool? chkfacility { get; set; }
        public bool? chklandlocation { get; set; }
        public bool? surveybanklist { get; set; }
        public bool? appraisalbanklist { get; set; }
        public bool? Ownerbanklist { get; set; }
        public bool? Otherdetail { get; set; }
        public string Remark { get; set; }
        [StringLength(200)]
        public string Buildingplan { get; set; }
        [StringLength(200)]
        public string Other { get; set; }

        public bool? Appraisalchk { get; set; }
        [StringLength(200)]
        public string CommentDetail { get; set; }
        [StringLength(25)]
        public string AppraisalBankid { get; set; }
        [DataType(DataType.Date)]
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
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? datecheck { get; set; }
        [StringLength(25)]
        public string AssistantAppDirector { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AssistDate { get; set; }
        [StringLength(25)]
        public string AppDirector { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppDireDate { get; set; }

        [StringLength(255)]
        public string reportdetail { get; set; }
    }
}
