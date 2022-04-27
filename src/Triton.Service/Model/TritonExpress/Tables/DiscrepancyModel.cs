using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
     [Dapper.Contrib.Extensions.Table("Discrepancies")]
    public class DiscrepancyModel
    {
        [Dapper.Contrib.Extensions.Key]  // Discrepancies Table unique identifier
        public Int64 DiscrepancyID { get; set; }

        [Required(ErrorMessage = "Waybill ID. Value is required!")] // Field validation message
        public Int64 WaybillID { get; set; }

        [Write(false)]
        [Computed]
       public string WaybillNo { get; set; }

        [DisplayName("Quantity")]
        [Required(ErrorMessage = "Discrepancy Quantity Value is required!")] // Field validation message
        public int DiscrepancyQuantity { get; set; }

        [DisplayName("Parcels")]
        public string DiscrepancyParcels { get; set; }

        [DisplayName("Comments")]
        public string ActionComments { get; set; }

        [DisplayName("Source")]
        [Required(ErrorMessage = "Discrepancy SourceID Value is required!")] // Field validation message
        public int DiscrepancySourceID { get; set; }
        [DisplayName("Type")]
        [Required(ErrorMessage = "Discrepancy Type Value is required!")] // Field validation message
        public int DiscrepancyTypeID { get; set; }
        public string PersonResponsible { get; set; }

        [DisplayName("Branch")]
        [Required(ErrorMessage = "Branch Logged Value is required!")] // Field validation message
        public int BranchIDLiable { get; set; }

        [DisplayName("Image")]
        [Write(false)]
        [Computed]
        public byte[] DiscrepancyImage { get; set; }
        public string Description { get; set; }

        [DisplayName("Action")]
        public string ActionTaken { get; set; }

        [DisplayName("Action")]
        [Required(ErrorMessage = "Action Value is required!")] // Field validation message
        public int ActionID { get; set; }

         [DisplayName("Person Responsible")]
        [Required(ErrorMessage = "Person Responsible Value is required!")] // Field validation message
        public int EmployeeIDResponsible { get; set; }

        [Required(ErrorMessage = "Please Enter Active Value!")] // Field validation message
        public bool Active { get; set; }

        [Required(ErrorMessage = "Please Enter Resolved Value!")] // Field validation message
        public bool Resolved { get; set; }

        [Required(ErrorMessage = "UserID Value is required!")] // Field validation message
        public int UserID { get; set; }

         [DisplayName("Date")]
        [Required(ErrorMessage = "Discrepancy Date Captured Value is required!")] // Field validation message
        public DateTime DateCaptured { get; set; }

        //Additional Fields
        [DisplayName("Waybill Date")]
        [Write(false)]
        [Computed]
        public DateTime? WaybillDate { get; set; }

        //Additional Fields
        [DisplayName("Waybill Qty")]
        [Write(false)]
        [Computed]
        public int WaybillQuantity { get; set; }

        [DisplayName("Customer Code")]
        [Write(false)]
        [Computed]
        public string  AccountCode { get; set; }

        [DisplayName("Customer Code")]
        [Write(false)]
        [Computed]
        public int CustomerID { get; set; }

        [DisplayName("From")]
        [Write(false)]
        [Computed]
        public string FromBranch { get; set; }

        [DisplayName("To")]
        [Write(false)]
        [Computed]
        public string ToBranch { get; set; }

        [DisplayName("Discrepancy Source")]
        [Write(false)]
        [Computed]
        public string DiscrepancySource { get; set; }

        [DisplayName("Discrepancy Type")]
        [Write(false)]
        [Computed]
        public string DescrepancyType { get; set; }

        [DisplayName("Sender")]
        [Write(false)]
        [Computed]
        public string Sender { get; set; }

        [DisplayName("Receiver")]
        [Write(false)]
        [Computed]
        public string Receiver { get; set; }


        [DisplayName("Debrief Action")]
        [Write(false)]
        [Computed]
        public string ActionName { get; set; }

        [DisplayName("Branch Liable")]
        [Write(false)]
        [Computed]
        public string BranchLiable { get; set; }
        
         [Write(false)]
        [Computed]
        public string Name { get; set; }
    }
}
