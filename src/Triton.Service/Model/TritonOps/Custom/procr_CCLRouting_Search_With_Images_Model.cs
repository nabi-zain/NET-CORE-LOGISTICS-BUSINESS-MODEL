using System;
using System.Collections.Generic;
using Triton.Model.TritonOps.StoredProcs;

namespace Triton.Model.TritonOps.Custom
{
    public class procr_CCLRouting_Search_With_Images_Model
    {
        public List<procr_CCLRouting_Search_With_Images> TLHRoutes { get; set; }

        public List<CCLImagesInfo> CCLImagesInfo { get; set; }

        //public List<CCLImageRepository> CCLImageRepository { get; set; }

        //public List<LookUpCodes> LookUpCodes { get; set; }
    }

    public class procr_TLHRouting_Search_With_Images_Model
    {
        public List<procr_TLHRouting_Search_With_Images> TLHRoutes { get; set; }

        public List<TLHImagesInfo> TLHImagesInfo { get; set; }

    }

    public class CCLImagesInfo
    {
        public long CCLImageRepositoryID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public long ImgLength { get; set; }
        public long? CCLID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserID { get; set; }
        public long? CategoryLookUpCodeID { get; set; }

        public long LookUpCodeID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public string Groups { get; set; }
        public int Sequence { get; set; }
        public int CostCentreID { get; set; }
        public int? BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BranchFullName { get; set; }
        public string BranchAdd1 { get; set; }
        public string BranchAdd2 { get; set; }
        public string BranchAdd3 { get; set; }
        public string BranchAdd4 { get; set; }
        public string BranchTel { get; set; }
        public string BranchFax { get; set; }
        public int? BranchDailySalesOrder { get; set; }
        public string VipCode { get; set; }
        public bool CostCentreActive { get; set; }
        public int? BranchCategoryID { get; set; }
        public int? RegionID { get; set; }
        public int? LocationID { get; set; }
        public string DbitCostCentreCode { get; set; }
        public bool IsTritonCompany { get; set; }
        public int? CompanyID { get; set; }
        public bool? IsSouthAfrican { get; set; }

        public int BadCCLRouteID { get; set; }
    }

    public class TLHImagesInfo
    {
        public int TripDeliveryID { get; set; }
        public long DocumentRepositoryID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public long ImgLength { get; set; }
        public long LookUpCodeID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public long? LookUpCodeCategoryID { get; set; }

        public int Sequence { get; set; }
        public int CostCentreID { get; set; }
        public int? BranchCode { get; set; }
        public string BranchName { get; set; }
        public string BranchFullName { get; set; }
        public string BranchAdd1 { get; set; }
        public string BranchAdd2 { get; set; }
        public string BranchAdd3 { get; set; }
        public string BranchAdd4 { get; set; }
        public string BranchTel { get; set; }
        public string BranchFax { get; set; }
        public int? BranchDailySalesOrder { get; set; }
        public string VipCode { get; set; }
        public bool CostCentreActive { get; set; }
        public int? BranchCategoryID { get; set; }
        public int? RegionID { get; set; }
        public int? LocationID { get; set; }
        public string DbitCostCentreCode { get; set; }
        public bool IsTritonCompany { get; set; }
        public int? CompanyID { get; set; }
        public bool? IsSouthAfrican { get; set; }
    }

}
