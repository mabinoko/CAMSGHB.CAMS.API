using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class User
    {
        public User()
        {
            Survey = new HashSet<Survey>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Depart { get; set; }
        public int UserStatus { get; set; }
        public long Branch { get; set; }
        public long Company { get; set; }
        public long UserLevel { get; set; }

        public ICollection<Survey> Survey { get; set; }
    }
}
