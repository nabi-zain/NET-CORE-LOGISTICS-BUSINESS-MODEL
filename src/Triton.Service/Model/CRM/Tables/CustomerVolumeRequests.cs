using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerVolumeRequests")]
    public class CustomerVolumeRequests
    {
        [Key]
        public int CustomerVolumeRequestID { get; set; }
        public string CustomerID { get; set; }
        public string OldVolume { get; set; }
        public string NewVolume { get; set; }
        public int RequestedByID { get; set; }
        public DateTime DateRequested { get; set; }
        public byte Approved { get; set; }
        public byte Processed { get; set; }
        public string Motivation { get; set; }
        public string SDComment { get; set; }
    }
}
