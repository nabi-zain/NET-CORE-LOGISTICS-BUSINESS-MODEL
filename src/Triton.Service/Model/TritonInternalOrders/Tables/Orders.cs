using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Custom;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("Orders")]
    public class Orders
    {
        [Dapper.Contrib.Extensions.Key]
        public long OrderID { get; set; }
        public long CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public int PaymentOptionLookupID { get; set; }

        [DisplayName("Payment Option")]
        [Write(false)]
        [Computed]
        public string PaymentOption { get; set; }

        [DisplayName("Branch")]
        [Write(false)]
        [Computed]
        public string BranchFullName { get; set; }

        [DisplayName("BranchName")]
        [Write(false)]
        [Computed]
        public string BranchName { get; set; }

        [DisplayName("Category")]
        [Write(false)]
        [Computed]
        public string Category { get; set; }

        [DisplayName("Gender")]
        [Write(false)]
        [Computed]
        public string Gender { get; set; }

        [DisplayName("Item")]
        [Write(false)]
        [Computed]
        public string Item { get; set; }

        [DisplayName("Total Price")]
        [Write(false)]
        [Computed]
        public decimal TotalPrice { get; set; }
        [Write(false)]
        [Computed]
        public int WorkFlowStageID { get; set; }
        [DisplayName("WorkFlow Stage")]
        [Write(false)]
        [Computed]
        public string WorkFlowStage { get; set; }

        [DisplayName("Size")]
        [Write(false)]
        [Computed]
        public string Size { get; set; }

        [DisplayName("Name")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }

        [Required(ErrorMessage = "Check to accept Uniform Policy!")]
        public bool UniformPolicy { get; set; }

        [DisplayName("Employee Code")]
        [Write(false)]
        [Computed]
        public string CurrentEmployeeCode { get; set; }

        [DisplayName("Department")]
        [Write(false)]
        [Computed]
        public string Department { get; set; }

        [DisplayName("OrderLines")]
        [Write(false)]
        [Computed]
        public List<OrderLineItems> OrderLines { get; set; }

        [Write(false)]
        [Computed]
        public List<WorkflowStageCountModel> WorkflowStageCounts { get; set; }
        [DisplayName("Staff Account")]
        public decimal? StaffAccount { get; set; }

        [DisplayName("Branch Account")]
        public decimal? BranchAccount { get; set; }
        [DisplayName("Dispatched")]
        public bool Dispatched { get; set; }
    }
}
