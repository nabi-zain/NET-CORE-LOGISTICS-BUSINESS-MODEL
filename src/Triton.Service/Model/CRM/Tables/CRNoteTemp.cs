using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.CRM.Tables
{
    public class CRNoteTemp
    {
        public string Remarks { get; set;}
 
        [Column("Requested by")] 
        public string RequestedBy { get; set;}
 
        [Column("Authorised by / confirmed with")]
        public string AuthorisedByConfirmedWith { get; set;}
 
        [Column("R/code")]
        public string RCode { get; set;}
 
        public string Reason { get; set;}
 
        [Column("Debit note (if app)")]
        public string DebitNoteIfApp { get; set;}
 
        public DateTime Month { get; set;}
 
        public string Original { get; set;}

        [Column("New Amt")]
        public string NewAmt { get; set;}

        [Column("Cust Code")]
        public string CustCode { get; set;}

        [Column("Cus name")]
        public string CusName { get; set;}

        [Column("W/b No#")]
        public string WbNo { get; set;}

        [Column("Excl Amt")]
        public string ExclAmt { get; set;}

        [Column("Incl Amt")]
        public string InclAmt { get; set;}

        [Column("Branch From")]
        public string BranchFrom { get; set;}

        [Column("Branch To")]
        public string BranchTo { get; set;}

        [Column("Error Source")]
        public string ErrorSource { get; set;}

        [Column("Check By")]
        public string CheckBy { get; set;}

        [Column("C/N No#")]
        public string CNNo { get; set;}
    }
}
