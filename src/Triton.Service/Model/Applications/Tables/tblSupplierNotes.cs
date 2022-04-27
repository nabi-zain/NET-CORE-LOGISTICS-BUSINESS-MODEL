using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierNotes")]
    public class tblSupplierNotes
    {
        [Dapper.Contrib.Extensions.Key]
        public int NoteID { get; set; }
        [DisplayName("Supplier")]
        public int SupplierID{ get; set; }

        public string Comment { get; set; }

        [DisplayName("Created By")]
        public int CreatedByID { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime TimeStamp { get; set; }

        public Boolean IsMail{ get; set; }

        [DisplayName("Notifaction")]
        public int NotificationID { get; set; }


        public int NoteTypeID { get; set; }

    }
}