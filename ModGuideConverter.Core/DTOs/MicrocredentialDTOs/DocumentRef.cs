using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public class DocumentRef
    {
        private Uri? _uri;
        private List<TranslationText> _translations;

        public Uri? Uri { get => _uri; set => _uri = value; }
        public List<TranslationText> Translations { get => _translations; set => _translations = value; }
    }
}
