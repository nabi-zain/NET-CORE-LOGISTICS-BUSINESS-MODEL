namespace Triton.Service.Model.Applications.StoredProcs
{
    public class proc_GetWayBillList_Select
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string VendorID { get; set; }
        public bool VATVendor { get; set; }
        public int WaybillCount { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Vat { get; set; }
        public decimal Mass { get; set; }
        public decimal Volumetric { get; set; }
        public decimal Surcharge { get; set; }
        public string FilterDate { get; set; }
        public int UserID { get; set; }
    }
}
