using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.CRM.Custom
{
    public class proc_CustomerNotificationMapSearch
    {
        public int CustomerID { get; set; }
        public int FWeventCodeID { get; set; }
        public string Wording { get; set; }
        public string Name { get; set; }
        public string AccountCode { get; set; }
        public string ShortDesc { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerNotificationMapID { get; set; }

    }
}
