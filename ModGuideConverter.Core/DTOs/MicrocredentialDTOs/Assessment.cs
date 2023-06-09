using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public class Assessment
    {

        private List<TranslationText> _type;

        private List<TranslationText> _mode;

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
    }
}
