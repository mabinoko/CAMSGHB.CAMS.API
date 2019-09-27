using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class RolePolicyCom
    {
        public RolePolicyCom()
        {
            UserCompRole = new HashSet<UserCompRole>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool AllOwn { get; set; }
        public bool View { get; set; }
        public bool OrderEdit { get; set; }
        public bool Edit { get; set; }
        public bool Approve { get; set; }
        public bool Survey { get; set; }
        public bool Appraisal { get; set; }
        public bool PriceGurr { get; set; }
        public bool SendToBank { get; set; }

        public ICollection<UserCompRole> UserCompRole { get; set; }
    }
}
