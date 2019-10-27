using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAMSGHB.CAMS.API.Models
{
    [Table("ViewProjectCode" , Schema = "dbo")]
    public class SamplingProjectView
    {
        [Key]
        public long AppraisalID { get; set; }

        public string AANo { get; set; }

        public string ProjectCode { get; set; }

        public int ProjectType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public string BranchCode { get; set; }

        [StringLength(10)]
        public string Expr1 { get; set; }

        public int L2VAL{ get; set; }

        [StringLength(50)]
        public string Project_GroupDetail { get; set; }

        [StringLength(50)]
        public string ProjectGroupDsb { get; set; }

        public int L2VALN { get; set; }
        //public int? percent { get; set; }


    }

    public class GetSamplingProjectViewModel
    {
        [Key]
        public long AppraisalID { get; set; }

        public string AANo { get; set; }

        public string ProjectCode { get; set; }

        public int ProjectType { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public string BranchCode { get; set; }

        [StringLength(10)]
        public string Expr1 { get; set; }

        public int L2VAL { get; set; }

        [StringLength(50)]
        public string Project_GroupDetail { get; set; }

        [StringLength(50)]
        public string ProjectGroupDsb { get; set; }

        public int L2VALN { get; set; }

        [Range(typeof(int), "0", "100")]
        public int percent { get; set; }


    }
}
