using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.DTOs.GerneralDTOs
{
    public class TranslationText
    {
        private string _languageShort = "en";
        private string _text = "Default Text";

        /// <summary>
        /// ISO 936-1 language code
        /// </summary>
        public string LanguageShort { get => _languageShort; set => _languageShort = value; }
        /// <summary>
        /// The text in the corresponding language
        /// </summary>
        public string Text { get => _text; set => _text = value; }
    }
}
