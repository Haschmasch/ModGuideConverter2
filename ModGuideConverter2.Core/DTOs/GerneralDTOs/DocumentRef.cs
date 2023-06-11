using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.DTOs.GerneralDTOs
{
    public class DocumentRef
    {
        private Uri? _uri;
        private string _name;

        public Uri? Uri { get => _uri; set => _uri = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
