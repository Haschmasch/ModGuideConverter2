using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public class AwardingBody : Identity
    {
        private string _fullName;
        private string _altName;

        public string FullName { get => _fullName; set => _fullName = value; }
        public string AltName { get => _altName; set => _altName = value; }
    }
}
