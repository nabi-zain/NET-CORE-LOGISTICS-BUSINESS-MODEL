
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("AirFreights")]
    public class AirFreights
    {
        [Key]
        public int airFreightID { get; set; }
        public int TransportTypeID { get; set; }
        public string Conditions { get; set; }
        public string Minumum { get; set; }
        public string RandPerKG { get; set; }
        public byte Active { get; set; }
        public byte Increase { get; set; }

    }
}
