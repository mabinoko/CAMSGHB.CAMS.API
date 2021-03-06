﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAMSGHB.CAMS.API.Models
{
    [Table("SamplingUFTDetail")]
    public class SamplingUFTDetail
    {
       
        public long RSubAppraisalID { get; set;}
        [Key]
        public long RAppraisalID { get; set;}
        [StringLength(120)]
        public string CIFName { get; set;}
        [StringLength(19)]
        public string AANo { get; set;}
        [StringLength(40)]
        public string RoomNo { get; set;}
        [StringLength(20)]
        public string BuildingNo { get; set;}
        [StringLength(15)]
        public string RegisterNumber { get; set;}
        [StringLength(5)]
        public string FloorNoCondo { get; set;}
        [StringLength(40)]
        public string PositionLatitude { get; set;}
        [StringLength(40)]
        public string PositionLongtitude { get; set;}
        public bool? chkconstruction { get; set;}
    }

    public class SamplingUFTDetailPostModel
    {

        public long RSubAppraisalID { get; set; }
        [StringLength(120)]
        public string CIFName { get; set; }
        [StringLength(19)]
        public string AANo { get; set; }
        [StringLength(40)]
        public string RoomNo { get; set; }
        [StringLength(20)]
        public string BuildingNo { get; set; }
        [StringLength(15)]
        public string RegisterNumber { get; set; }
        [StringLength(5)]
        public string FloorNoCondo { get; set; }
        [StringLength(40)]
        public string PositionLatitude { get; set; }
        [StringLength(40)]
        public string PositionLongtitude { get; set; }
        public bool? chkconstruction { get; set; }
    }
}
