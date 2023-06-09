using ModGuideConverter.Core.DTOs.MicrocredentialDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs
{
    public class Module : Microcredential
    {
        private string _moduleId;
        private List<TranslationText> _yearOfStudy;
        private List<TranslationText> _moduleDuration;
        private PersonalIdentity _responsiblePerson;
        private List<TranslationText> _remarks;
        private List<DocumentRef> _documents;
    }
}
