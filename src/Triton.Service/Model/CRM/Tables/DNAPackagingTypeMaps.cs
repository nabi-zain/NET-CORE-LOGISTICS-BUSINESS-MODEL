using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNAPackagingTypeMaps")]
    public class DNAPackagingTypeMaps

    {
        public long DNAPackagingTypeMapID { get; set; }

        public long DNAID { get; set; }
        public int PackagingTypeID { get; set; }
    }
}
