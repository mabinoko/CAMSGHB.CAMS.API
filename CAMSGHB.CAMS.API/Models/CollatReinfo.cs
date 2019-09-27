using System;
using System.Collections.Generic;

namespace CAMSGHB.CAMS.API.Models
{
    public partial class CollatReinfo
    {
        public long CollatReInfoId { get; set; }
        public string TitleNo { get; set; }
        public string DocumentNo { get; set; }
        public string LandNo { get; set; }
        public string BuildingNo { get; set; }
        public string HouseNo { get; set; }
        public string Rawang { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Ownership { get; set; }
        public int? AreaNgan { get; set; }
        public int? AreaRai { get; set; }
        public double? AreaWa { get; set; }
        public string Obligation { get; set; }
        public string CheckDocument { get; set; }
        public string CheckDocumentRemark { get; set; }
        public string CondoName { get; set; }
        public string RoomNo { get; set; }
        public string FloorNoContract { get; set; }
        public string FloorNoInsurance { get; set; }
        public double? RoomArea { get; set; }
        public double? Area { get; set; }
        public string UnitPosition { get; set; }
        public double? FireInsuranceAreaPerSqM { get; set; }
        public string AdditionalDeedNo { get; set; }
        public double? RegisterNumber { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTypeOther { get; set; }
        public long CollateralListId { get; set; }

        public CollateralList CollateralList { get; set; }
    }
}
