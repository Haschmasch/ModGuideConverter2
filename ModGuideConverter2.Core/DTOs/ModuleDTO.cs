using ModGuideConverter2.Core.DTOs.MicrocredentialDTOs;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.DTOs
{
    /// <summary>
    /// Contains DHBW specific information that is not neccesarily needed to form a eu-microcredential.<br/>
    /// </summary>
    public class ModuleDTO : MicrocredentialDTO
    {
        private string _moduleId;
        private List<TranslationText> _yearOfStudy;
        private List<TranslationText> _moduleDuration;
        private PersonalIdentity _responsiblePerson;
        private List<TranslationText> _remarks;
        private List<DocumentRef> _documents;


        public string ModuleId { get => _moduleId; set => _moduleId = value; }
        public List<TranslationText> YearOfStudy { get => _yearOfStudy; set => _yearOfStudy = value; }
        public List<TranslationText> ModuleDuration { get => _moduleDuration; set => _moduleDuration = value; }
        public PersonalIdentity ResponsiblePerson { get => _responsiblePerson; set => _responsiblePerson = value; }
        public List<TranslationText> Remarks { get => _remarks; set => _remarks = value; }
        public List<DocumentRef> Documents { get => _documents; set => _documents = value; }

        public ModuleDTO()
        {
            _moduleId = "T3INF2003";
            _yearOfStudy = new List<TranslationText>() { new TranslationText() { LanguageShort = "en", Text = "Second year" } };
            _moduleDuration = new List<TranslationText>() { new TranslationText() { LanguageShort = "en", Text = "2 semesters" } };
            _responsiblePerson = new PersonalIdentity();
            _remarks = new List<TranslationText>() { new TranslationText() { LanguageShort = "en", Text = "None" } };
            _documents = new List<DocumentRef> { new DocumentRef() { Name = "Rational Unified Process", Uri = new Uri("https://de.wikipedia.org/wiki/Rational_Unified_Process") } };
        }
    }
}
