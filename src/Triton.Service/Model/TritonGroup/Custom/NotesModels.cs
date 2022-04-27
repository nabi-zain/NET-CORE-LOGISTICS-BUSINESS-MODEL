using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonGroup.Custom
{
    public class NotesModels
    {
        public Triton.Model.TritonGroup.Tables.Notes Note { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes NoteType { get; set; }
        public Triton.Model.TritonGroup.Tables.Users User { get; set; }

    }
}
