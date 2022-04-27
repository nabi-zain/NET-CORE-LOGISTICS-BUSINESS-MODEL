namespace Triton.Service.Model.Applications.StoredProcs
{
    public class proc_Supplier_Category_Select
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string VendorID { get; set; }
        public string CategoryName { get; set; }
        public int WaybillCount { get; set; }
        public decimal Total { get; set; }
        public int Sequence { get; set; }
        public int LookupcodeID { get; set; }
        public int Paid { get; set; }
        public int Unpaid { get; set; }
        public int BMApproved { get; set; }
        public int Query { get; set; }
    }
}
