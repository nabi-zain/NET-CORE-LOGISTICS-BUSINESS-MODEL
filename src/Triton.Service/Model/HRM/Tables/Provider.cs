using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.HRM.Tables
{
    [Table("Provider")]
    public  class Provider
    {
        [Key]
        public int ProviderID { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string AccreditationNo { get; set; }
        public string CompanyRegistration { get; set; }
        public int ? SetaLCID { get; set; }
        public string SDLNo { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ? DeletedByUserID { get; set; }
        public DateTime ? DeletedOn { get; set; }
    }
}
