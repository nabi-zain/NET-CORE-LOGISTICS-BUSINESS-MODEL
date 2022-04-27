using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("")]
    public class EmployeeContactInfo
    {
        public  int ID { get; set; }
        public string Employees { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalAddress3 { get; set; }
        public string PhysicalAddress4 { get; set; }
        public string PhysicalPostCode { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalAddress3 { get; set; }
        public string PostalAddress4 { get; set; }
        public string PostalPostCode { get; set; }
        public string TelHome { get; set; }
        public string TelWork { get; set; }
        public string TelCell { get; set; }
        public string TelFax { get; set; }
        public string Email { get; set; }
    }
}
