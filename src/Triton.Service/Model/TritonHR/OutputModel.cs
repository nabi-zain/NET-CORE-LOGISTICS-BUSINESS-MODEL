using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.TritonHR
{
    public class OutputModel 
     {
        [Dapper.Contrib.Extensions.Key]
        public  int Outputid { get; set; }
        [Required(ErrorMessage = "Output Name is required")]
        public  string Outputname { get; set; }
        [Required(ErrorMessage = "Aggregate is required")]
        public  int AggregateID { get; set; }
        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }

        //Additional Fields
        [DisplayName("Aggregate")]
        [Write(false)]
        public string AggregateName { get; set; }
    }

}
