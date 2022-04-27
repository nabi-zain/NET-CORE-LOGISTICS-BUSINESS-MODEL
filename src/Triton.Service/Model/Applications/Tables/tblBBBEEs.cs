using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblBBBEEs")]
    public class tblBBBEEs
    {
        public object bbbeeID;

        [Dapper.Contrib.Extensions.Key]
        [DisplayName("Type")]
        public int BBBEEID { get; set; }
        
        [DisplayName("Supplier")]
        public int SupplierID { get; set; }

        public String BBBEEStatus { get; set; }

        [DisplayName("BBBEE Expiry Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? CertExpiryDate { get; set; }

        [Required]
        [DisplayName("Empowering Supplier?")]
        public Boolean isEmpoweringSupplier { get; set; }

        [DisplayName("EME")]

        public Boolean isEME { get; set; }

        [DisplayName("QSE")]

        public Boolean isQSE { get; set; }
        [Required]
        [DisplayName("Black Owned EME/QSE")]

        public Boolean isBlackOwnedEMEQSE { get; set; }
        [Required]
        [DisplayName("Black Owned %")]

        public Decimal? BlackOwnedPerc { get; set; }
        [Required]
        [DisplayName("Black Women Owned %")]

        public Decimal? BlackWomenOwnedPerc { get; set; }

        public static implicit operator tblBBBEEs(int v)
        {
            throw new NotImplementedException();
        }
    }
}

