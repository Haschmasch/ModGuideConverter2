using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.DTOs
{
    public class TagDTO : CommitDTO
    {
        public string TagName { get; set; } = string.Empty;
    }
}
