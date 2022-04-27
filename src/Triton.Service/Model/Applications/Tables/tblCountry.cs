using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblCountry")]
    public class tblCountry
    {
  
        [Dapper.Contrib.Extensions.Key]
        [DisplayName("Country")]
        public int CountryID { get; set; }
        
        [DisplayName("Country Name")]
        public string CountryName { get; set; }
       
        public string CurrencyDescription { get; set; }

        [DisplayName("Currency Code")]
        [Required]
        public string CurrencyCode { get; set; }
        

        public string CurrencySign { get; set; }


        public decimal VATRate { get; set; }
    }
}
