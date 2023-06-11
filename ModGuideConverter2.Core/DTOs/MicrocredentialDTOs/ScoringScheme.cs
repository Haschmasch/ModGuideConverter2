using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public class ScoringScheme
    {
        private string? _identifier;

        private List<TranslationText> _measurement;

        private string _description;

        /// <summary>
        /// Identifier of the scoring measurement. E.g. percentage or points.
        /// </summary>
        public string? Identifier { get => _identifier; set => _identifier = value; }
        /// <summary>
        /// The measurement of the scoring. E.g. 0-100 or a Pass/Fail
        /// </summary>
        public List<TranslationText> Measurement { get => _measurement; set => _measurement = value; }
        /// <summary>
        /// Further scoring description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
    }
}
