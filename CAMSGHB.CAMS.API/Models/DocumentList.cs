using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class DocumentList
    {
        public long DocumentListId { get; set; }
        public int ReqDocId { get; set; }
        public int ReqId { get; set; }
        public string DocCat { get; set; }
        public string DocCode { get; set; }
        public string DocDesc { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public string ScanIndex { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public long AppraisalId { get; set; }

        public Appraisal Appraisal { get; set; }
    }
}
