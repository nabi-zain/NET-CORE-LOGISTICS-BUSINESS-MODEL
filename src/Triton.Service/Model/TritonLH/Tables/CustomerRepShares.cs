using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Triton.Model.TritonLH.Tables
{
    [Table("CustomerRepShares")]
    public class CustomerRepShares 
    {

        public CustomerRepShares() { }
        [Key]
        public  Int32 CustomerRepShareID { get; set; }
        public  Int32 CustomerID { get; set; }
        [DisplayName("Rep")]
        public  Int32 RepCodeID { get; set; }
        [DisplayName("Allocation")]
        public  Int32 AllocationPerc { get; set; }
        [DisplayName("Allocation Targer")]
        public  Int32 AllocationPercTargetOnly { get; set; }
        public  String Reason { get; set; }
        [DisplayName("Effective Until")]
        public  DateTime? DateEffectiveTo { get; set; }
        [DisplayName("Effective From")]
        public  DateTime? DateEffectiveFrom { get; set; }
        public  Int32 CustomerCommisionTypeID { get; set; }
        [DisplayName("Has Fixed %")]
        public  Boolean hasFixedPerc { get; set; }
        [DisplayName("Fixed %")]
        public  Decimal FixedPerc { get; set; }
        [DisplayName("Set Comm Level")]
        public  Boolean SpecCommLevel { get; set; }
        [DisplayName("Comm Level")]
        public  Int32 CommLevel { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public int? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        //public static bool UserHasShares(long UserID,int customerID)
        //{
        //    RepCodes code = PersistentObjectHelper.RetrieveByCriteria<RepCodes>(new ICriterion[] { Expression.Eq("UserID", UserID) });
        //    if (code != null)
        //    {
        //        List<CustomerRepShares> shares = CollectionHelper.LoadList<CustomerRepShares>(new ICriterion[] { Expression.Eq("RepCodeID", code.RepCodeID), Expression.Eq("CustomerID", customerID) }) as List<CustomerRepShares>;
        //        if (shares.Count > 0)
        //            return true;
        //        else return false;
        //    }
        //    else return false;
        //}

        //public virtual String CommType
        //{
        //    get
        //    {
        //       if (CustomerCommisionTypeID == null || CustomerCommisionTypeID == 0)
        //            return "N/A";
        //       else return PersistentObjectHelper.Get<CustomerCommisionTypes>(CustomerCommisionTypeID).ShortDescription;

        //    }
        //}
        [Computed]
        public String hasFixedPercString
        {
            get { if (hasFixedPerc) return "Yes"; else return "No"; }
        }

    }
}

