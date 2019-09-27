using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class UserCompRole
    {
        public int UserCompRoleGroup { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public RolePolicyCom Role { get; set; }
        public UserCompany User { get; set; }
    }
}
