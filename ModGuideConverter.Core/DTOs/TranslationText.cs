using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs
{
    public class TranslationText
    {
        private string _languageShort;
        private string _text;

        public string LanguageShort { get => _languageShort; set => _languageShort = value; }
        public string Text { get => _text; set => _text = value; }

        public TranslationText()
        {
            _languageShort = String.Empty;
            _text = String.Empty;
        }
    }
}
