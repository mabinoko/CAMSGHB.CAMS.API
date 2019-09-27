using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Progress
    {
        public Progress()
        {
            Appraisal = new HashSet<Appraisal>();
        }

        public string ProgressCode { get; set; }
        public string ProgressDesc { get; set; }

        public ICollection<Appraisal> Appraisal { get; set; }
    }
}
