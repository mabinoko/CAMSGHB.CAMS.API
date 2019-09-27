using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class UserBankRole
    {
        public int UserBankRoleGroup { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public RolePolicyBank Role { get; set; }
        public UserBank User { get; set; }
    }
}
