namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_DeliveryVehicle_App_Select
    {
        public string FromSiteName { get; set; }
        public string FromSiteCustomerName { get; set; }
        public string FromAddress1 { get; set; }
        public string FromAddress2 { get; set; }
        public string FromAddress3 { get; set; }
        public string FromCity { get; set; }
        public string FromPhoneNumber { get; set; }
        public decimal? FromLatitude { get; set; }
        public decimal? FromLongitude { get; set; }
        public string ToSiteName { get; set; }
        public string ToSiteCustomerName { get; set; }
        public string ToAddress1 { get; set; }
        public string ToAddress2 { get; set; }
        public string ToAddress3 { get; set; }
        public string ToCity { get; set; }
        public string ToPhoneNumber { get; set; }
        public string ToLatitude { get; set; }
        public string ToLongitude { get; set; }
        public int HorseVehicleID { get; set; }
        public string HorseReg { get; set; }
        public int? Trailer1VehicleID { get; set; }
        public string Trailer1Reg { get; set; }
        public int? Trailer2VehicleID { get; set; }
        public string Trailer2Reg { get; set; }
    }
}
