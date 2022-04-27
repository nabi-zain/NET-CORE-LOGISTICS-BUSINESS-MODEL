using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Customers_Select
    {
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int StatusID { get; set; }
        public string ShortDescription { get; set; }
        public string Colour { get; set; }
    }
}
