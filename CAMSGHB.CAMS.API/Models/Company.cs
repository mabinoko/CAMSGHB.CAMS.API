using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class Company
    {
        public Company()
        {
            Appraisal = new HashSet<Appraisal>();
        }

        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string AddNo { get; set; }
        public string ViilageNo { get; set; }
        public string Alley { get; set; }
        public string Road { get; set; }
        public string TambolCode { get; set; }
        public string AmphurCode { get; set; }
        public string ProvinceCode { get; set; }
        public string Telephone { get; set; }
        public string FaxNo { get; set; }
        public bool CompanyStatus { get; set; }
        public long CifNo { get; set; }
        public string Remark { get; set; }
        public long? RegionId { get; set; }

        public Region Region { get; set; }
        public ICollection<Appraisal> Appraisal { get; set; }
    }
}
