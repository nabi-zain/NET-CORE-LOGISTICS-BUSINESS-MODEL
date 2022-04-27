using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonGroup.Tables
{
        [Table("RateAreas")]
        public class RateAreas 
        {

            public RateAreas() { }
           
            [Key]
            public  int RateAreaID { get; set; }
            [DisplayName("Short Code")]
            public  String ShortCode { get; set; }
            public  String Description { get; set; }
            [DisplayName("Linked Main Rate Area")]
            public  Int32 MainRateAreaID { get; set; }
            [DisplayName("Linked Ring Rate Area")]
            public  Int32 RingRateAreaID { get; set; }
            [DisplayName("Created By")]
            public int CreatedByUserID { get; set; }
            [DisplayName("Created On")]
            public DateTime CreatedOn { get; set; }
            [DisplayName("Deleted By")]
            public int? DeletedByUserID { get; set; }
            [DisplayName("Deleted On")]
            public DateTime? DeletedOn { get; set; }
            [Computed]
            public String DropDownString 
            { 
                get
                {
                    return ShortCode + " - " + Description;
                } 
                
             }
          
        }
    }


