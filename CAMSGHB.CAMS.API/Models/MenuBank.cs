using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class MenuBank
    {
        public int MenuId { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public string UserRoleActive { get; set; }
        public string MenuLink { get; set; }
        public string MenuIcon { get; set; }
        public string Child { get; set; }
        public bool MenuStatus { get; set; }
    }
}
