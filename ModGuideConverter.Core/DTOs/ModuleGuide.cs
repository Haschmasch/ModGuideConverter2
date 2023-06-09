using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs
{
    public class ModuleGuide
    {
        private string _primaryLanguage;
        private string _primaryLanguageShort;
        private List<TranslationText> _fieldOfStudy;
        private List<TranslationText> _programOfStudy;
        private List<TranslationText> _courseOfStudy;
        private string _academyName;

        public ModuleGuide()
        {
            _primaryLanguage = string.Empty;
            _primaryLanguageShort = string.Empty;
            _academyName = string.Empty;
        }
    }
}
