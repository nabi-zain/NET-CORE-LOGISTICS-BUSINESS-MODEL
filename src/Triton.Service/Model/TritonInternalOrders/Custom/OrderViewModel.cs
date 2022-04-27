using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Custom;
using Triton.Model.TritonInternalOrders.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonInternalOrders.Custom
{
    public class OrderViewModel
    {

        public long CategoryLookupID { get; set; }
        public long GenderTypeLookupID { get; set; }
        public long ItemTypeLookupID { get; set; }
        public long SizeLookupID { get; set; }
        public long PaymentOptionLookupID { get; set; }

        [Range(1, 500, ErrorMessage = "Quantity must be greater than 0")]
        public long Quantity { get; set; }
        public string Description { get; set; }
        public long CreatedByUserID { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool UniformPolicy { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> Categories { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> GenerTypes { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> ItemTypes { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> Sizes { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> PaymentOptions { get; set; }
        [DisplayName("Branch Name")]
        public int BranchID { get; set; }
        public List<Triton.Model.TritonSecurity.Tables.Branches> Branches { get; set; }

        public List<Triton.Model.TritonInternalOrders.Tables.OrderBasket> BasketItems { get; set; }
        public decimal BasketBusketTotal { get; set; }
        public decimal BranchAccount { get; set; }
        public decimal StaffAccount { get; set; }
        public List<WorkflowStageCountModel> WorkflowCounts { get; set; }
    }

    public class OrderModel
    {
        public Orders OrderHeader { get; set; }
        public Users User { get; set; }
        public Employees Employee { get; set; }

        public Branches Branch { get; set; }
        public Departments Department { get; set; }


    }
}
