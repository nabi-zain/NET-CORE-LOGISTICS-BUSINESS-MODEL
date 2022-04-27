using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
   public class CheckListUserModel
    {
        public CheckListUsers CheckListUsers { get; set; }
        public CheckLists CheckLists { get; set; }
        public Users Users { get; set; }


    }
}
