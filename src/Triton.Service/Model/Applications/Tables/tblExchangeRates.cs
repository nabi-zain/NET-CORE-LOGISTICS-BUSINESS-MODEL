using System;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblExchangeRates")]
    public class tblExchangeRates
    {
      
        [System.ComponentModel.DataAnnotations.Key]
        public int ExchangeRateID { get; set; }

        public int CountryID { get; set; }
        [Required]
        public Decimal ExchangeRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]

        public DateTime ToDate { get; set; }

        [Required]

        public String ChangedBy { get; set; }
        [Required]

        public DateTime ChangedOn { get; set; }

    }

    }

