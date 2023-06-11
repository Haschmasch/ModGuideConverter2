using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public class ScoringScheme
    {
        private List<TranslationText>? _identifier;

        private List<TranslationText> _measurement;

        private List<TranslationText> _description;

        /// <summary>
        /// Identifier of the scoring measurement. E.g. percentage or points.<br/>
        /// Can be null/undefined.
        /// </summary>
        public List<TranslationText>? Identifier { get => _identifier; set => _identifier = value; }
        /// <summary>
        /// The measurement of the scoring. E.g. 0-100 or a Pass/Fail
        /// </summary>
        public List<TranslationText> Measurement { get => _measurement; set => _measurement = value; }
        /// <summary>
        /// Further scoring description
        /// </summary>
        public List<TranslationText> Description { get => _description; set => _description = value; }

        public ScoringScheme()
        {
            _measurement = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Pass/Fail" } };
            _description = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Pass or fail description" } };
        }
    }
}
