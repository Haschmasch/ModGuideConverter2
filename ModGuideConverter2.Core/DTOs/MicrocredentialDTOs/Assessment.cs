using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public class Assessment
    {

        private List<TranslationText> _type;

        private List<TranslationText> _mode;

        private TimeSpan _assesmentDuration;

        private ScoringScheme? _scoringScheme;

        /// <summary>
        /// Type of assesment.<br/>
        /// References to the Europass Standard List Of Assessment Types.<br/>
        /// http://data.europa.eu/snb/assessment/25831c2 <br/>
        /// http://data.europa.eu/snb/assessment/3484bd7e51
        /// </summary>
        public List<TranslationText> Type { get => _type; set => _type = value; }
        /// <summary>
        /// Assessment mode.<br/>
        /// References to the Europass Standard List of Modes Of Learning and Assessment.<br/>
        /// http://data.europa.eu/snb/learning-assessment/25831c2 <br/>
        /// http://data.europa.eu/snb/learning-assessment/7813801c77
        /// </summary>
        public List<TranslationText> Mode { get => _mode; set => _mode = value; }

        public ScoringScheme? ScoringScheme { get => _scoringScheme; set => _scoringScheme = value; }
        public TimeSpan AssesmentDuration { get => _assesmentDuration; set => _assesmentDuration = value; }

        /// <summary>
        /// This gives field inital sample values.
        /// </summary>
        public Assessment()
        {
            _type = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "continuous evaluation" } };
            _mode = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Project based" } };
            _assesmentDuration = new TimeSpan(2, 0, 0);
        }
    }
}
