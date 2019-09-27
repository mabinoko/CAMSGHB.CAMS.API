using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Amphur
    {
        [Key]
        public long AmphurId { get; set; }
        public string AmphurName { get; set; }
        public string AmphurCode { get; set; }
        public string ProvinceCode { get; set; }
        public bool? Status { get; set; }
    }
}
