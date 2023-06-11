using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;

namespace ModGuideConverter2.Core.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    public class ModuleGuide
    {
        private string _primaryLanguage;
        private string _primaryLanguageShort;
        private List<TranslationText> _fieldOfStudy;
        private List<TranslationText> _programOfStudy;
        private List<TranslationText> _courseOfStudy;
        private string _academyName;
        private List<Module> _modules;

        public string PrimaryLanguage { get => _primaryLanguage; set => _primaryLanguage = value; }
        public string PrimaryLanguageShort { get => _primaryLanguageShort; set => _primaryLanguageShort = value; }
        public List<TranslationText> FieldOfStudy { get => _fieldOfStudy; set => _fieldOfStudy = value; }
        public List<TranslationText> ProgramOfStudy { get => _programOfStudy; set => _programOfStudy = value; }
        public List<TranslationText> CourseOfStudy { get => _courseOfStudy; set => _courseOfStudy = value; }
        public string AcademyName { get => _academyName; set => _academyName = value; }
        public List<Module> Modules { get => _modules; set => _modules = value; }


        public ModuleGuide()
        {
            PrimaryLanguage = string.Empty;
            PrimaryLanguageShort = string.Empty;
            AcademyName = string.Empty;
        }
    }
}
