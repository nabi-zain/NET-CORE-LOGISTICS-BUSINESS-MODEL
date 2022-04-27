using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("FWUsers")]
    public class FWUsers
    {
        [Key]
        [Column("Country Code ID")]
       public string Company_CodeID { get; set; }
        [Column("User ID")]
       
        public string User_ID { get; set; }
        [Column("Active Indicator")]
        public string Active_Indicator { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Column("Profile Code")]
        public string Profile_Code { get; set; }
        public string Position { get; set; }
        public string Branch { get; set; }
        [Column("Last Login Date")]
        public DateTime Last_Login_Date { get; set; }
        [Column("User Type")]
        public string User_Type { get; set; }
        [Column("Start up Program")]
        public string Startup_Program { get; set; }
        [Column("Password Expired")]
        public string Password_Expired { get; set; }
        [Column("Unix User ID Exists")]
        public string Unix_User_ID_Exists { get; set; }
        [Column("User Primary Funcation")]
        public string User_Primary_Funcation { get; set; }
        [Column("Web User ID")]
        public string Web_User_ID { get; set; }
        [Column("Group Account")]
        public string Group_Account { get; set; }
        [Column("Internal User")]
        public string Internal_user { get; set; }
        




    }


    
}
