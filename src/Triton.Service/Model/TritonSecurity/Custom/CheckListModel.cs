using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
   public class CheckListModel
    {
        public CheckLists CheckList { get; set; }
        public Frequency Frequency { get; set; }
        public Systems System { get; set; }
        public Departments Departments { get; set; }

    }
}
