using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblNameAndShamecomments")]
   public class NameAndShameComments
    {
        [Dapper.Contrib.Extensions.Key]
        public  int ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        public  DateTime Date { get; set; }
        public  string Comment { get; set; }

    }
}
