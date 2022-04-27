using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
        [Table("Helpdesk")]
       public  class HelpdeskModel
       {

       

       
 

         
        public int ID { get; set; }
        [DisplayName("First Name")]
        [Write(false)]
        [Computed]
        public string FName { get; set; }
        [DisplayName("Last Name")]
        [Write(false)]
        [Computed]
        public string LName { get; set; }
        public string Email { get; set; }

        [DisplayName("Severity")]
        [Write(false)]
        [Computed]
        public int SeverityID { get; set; }
        [DisplayName("Ticket Status")]
        [Write(false)]
        [Computed]
        public int StatusID { get; set; }
        public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }
        public string Comments { get; set; }




    }
}
