using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.MTNSMS.Tables
{
    [Dapper.Contrib.Extensions.Table("MT")]
    public class MT
    {
        public string destinationAddr { get; set; }
        public string messageContent { get; set; }
        public string messageID { get; set; }
        public int processStatus { get; set; }
        public int? deliveryStatus { get; set; }
        public DateTime insertDateTime { get; set; }
        public DateTime? processDateTime { get; set; }
    }


}