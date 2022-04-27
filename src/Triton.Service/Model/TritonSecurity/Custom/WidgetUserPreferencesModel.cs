using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
  public  class WidgetUserPreferencesModel
    {
        public WidgetUserPreferences WidgetUserPreferences { get; set; }
        public Widgets Widgets { get; set; }
    }
}
