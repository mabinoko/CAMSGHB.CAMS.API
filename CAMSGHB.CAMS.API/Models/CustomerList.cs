using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class CustomerList
    {
        public long CustomerListId { get; set; }
        public string Cifno { get; set; }
        public string Cifname { get; set; }
        public string ContactNo { get; set; }
        public bool Status { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
