using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Branch
    {
        public long BranchId { get; set; }
        public string AddNo { get; set; }
        public string Road { get; set; }
        public string TambolCode { get; set; }
        public string AmphurCode { get; set; }
        public string ProvinceCode { get; set; }
        public string DeptId { get; set; }
        public string DeptName { get; set; }
        public string BranchId1 { get; set; }
        public string BranchName { get; set; }
        public string DivCode2014 { get; set; }
        public string DivisionId { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionName { get; set; }
        public string DecSolId { get; set; }
        public string DecCode { get; set; }
        public string DecName { get; set; }
        public bool Status { get; set; }
    }
}
