using System.ComponentModel;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonLH.Tables
{
    [Table("Customers")]
    public class Customers : TritonGroup.Tables.Customers
    {
        public int? CustomerStatusLCID { get; set; }

        public string Country { get; set; }

        public int CustomerAccountTypeLCID { get; set; }

        public string AnvDate { get; set; }

        public string BillingKey { get; set; }

        public int CountryID { get; set; }

        [DisplayName("Tarriff Code")]
        public int TarrifCodeLCID { get; set; }

        public int RepCodeID { get; set; }
        public int AccountLevel { get; set; }

        public int CutOffDay { get; set; }
    }
}
