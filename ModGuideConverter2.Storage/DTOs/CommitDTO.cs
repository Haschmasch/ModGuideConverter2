using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.DTOs
{
    public class CommitDTO : SignatureDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
    }
}
