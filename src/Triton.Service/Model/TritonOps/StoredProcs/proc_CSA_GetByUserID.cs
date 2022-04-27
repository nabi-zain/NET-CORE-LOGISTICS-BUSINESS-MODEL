namespace Triton.Service.Model.TritonOps.StoredProcs
{
    public  class proc_CSA_GetByUserID
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public int WayBillsTotalCount { get; set; }
        public int EmailSentTotalCount { get; set; }
        public int PODTotalCount { get; set; }
    }
}
