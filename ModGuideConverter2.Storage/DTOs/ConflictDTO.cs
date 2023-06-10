using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.DTOs
{
    public class ConflictDTO
    {
        public Type ConflictObjectType { get; set; }

        public object Ancestor { get; set; }

        public object Ours { get; set; }

        public object Theirs { get; set; }

        public ConflictDTO(Type conflictObjectType, object ancestor, object ours, object theirs)
        {
            ConflictObjectType = conflictObjectType;
            Ancestor = ancestor;
            Ours = ours;
            Theirs = theirs;
        }
    }
}
