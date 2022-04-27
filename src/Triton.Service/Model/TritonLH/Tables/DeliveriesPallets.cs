using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesPallets")]
    public class DeliveriesPallets
    {
        #region Properties

        [DisplayName("CHEP Return No")]
        public string CHEPNo { get; set; }

        public int? Collected { get; set; }

        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }

        public long DeliveryID { get; set; }

        [Key]
        public int DeliveryPalletID { get; set; }

        [DisplayName("To Collect")]
        public int? ToCollect { get; set; }

        [DisplayName("CHEP Ref No")]
        public string PalletRefNo { get; set; }

        [DisplayName("Pallets to Collect C1")]
        public int? CollectC1 { get; set; }

        [DisplayName("Pallets to Collect C4")]
        public int? CollectC4 { get; set; }

        [DisplayName("Pallets Returned C1")]
        public int? ReturnedC1 { get; set; }

        [DisplayName("Pallets Returned C4")]
        public int? ReturnedC4 { get; set; }

        [DisplayName("OP No")]
        public string OPNo { get; set; }

        [DisplayName("Transfer Hire No")]
        public string TransferHireNo { get; set; } // varchar(50), null


        #endregion Properties
    }
}
