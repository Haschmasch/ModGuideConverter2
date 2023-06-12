using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public class LearningActivity
    {

        private List<TranslationText> _teachingMethod;

        private List<TranslationText> _teachingInstruments;

        /// <summary>
        /// Method of teaching.<br/>
        /// References to the Europass Standard List Of Learning Activity Types.<br/>
        /// http://data.europa.eu/snb/learning-activity/25831c2 <br/>
        /// http://data.europa.eu/snb/learning-activity/ff436ea7c9
        /// </summary>
        public List<TranslationText> TeachingMethod { get => _teachingMethod; set => _teachingMethod = value; }
        /// <summary>
        /// Type of Teaching instrument.
        /// References to the Europass Standard List of Modes Of Learning and Assessment.<br/>
        /// http://data.europa.eu/snb/learning-assessment/25831c2 <br/>
        /// http://data.europa.eu/snb/learning-assessment/7813801c77 
        /// </summary>
        public List<TranslationText> TeachingInstruments { get => _teachingInstruments; set => _teachingInstruments = value; }

        public LearningActivity()
        {
            _teachingMethod = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "classroom coursework" } };
            _teachingInstruments = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Blended" } };
        }
    }
}
