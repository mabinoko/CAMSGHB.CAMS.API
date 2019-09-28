using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAMSGHB.CAMS.API.Models
{
    [Table("SamplingLBFTDetail")]
    public class SamplingLBFTDetail
    {
        [Key]
        public long RSubAppraisalID { get; set; }
        public long RAppraisalID { get; set; }
        [StringLength(120)]
        public string CIFName { get; set; }
        [StringLength(19)]
        public string AANo { get; set; }
        [StringLength(40)]
        public string ConstDeedNo { get; set; }
        [StringLength(40)]
        public string Houseno { get; set; }
        [StringLength(10)]
        public string BuildingModel { get; set; }
        [Range(0, 99999.99)]
        public string NoOfFloor { get; set; }
        [StringLength(40)]
        public string PositionLatitude { get; set; }
        [StringLength(40)]
        public string PositionLongtitude { get; set; }
        public bool chkconstruction { get; set; }
    } 
}
