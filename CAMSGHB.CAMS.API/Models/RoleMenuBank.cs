using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class RoleMenuBank
    {
        public int RoleMenuId { get; set; }
        public int RoleId { get; set; }
        public string MenuCode { get; set; }
        public bool RoleMenuStatus { get; set; }
    }
}
