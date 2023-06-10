using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public class LearningOutcome
    {
        private List<TranslationText> _title;
        private List<TranslationText> _escoTargetType;
        private List<TranslationText> _escoSkillPillarReusabilityLevel;
        private List<TranslationText> _relatedEscoSkill;
        private List<TranslationText> _escoSkillDescription;

        //Interpretation of "prefLabel" from exported xml. Origin (Esco) unclear.
        public List<TranslationText> Title { get => _title; set => _title = value; }

        /// <summary>
        /// References to the ESCO Skill Pillar concept (sub-) Types.<br/>
        /// http://data.europa.eu/snb/skill-type/25831c2 <br/>
        /// http://data.europa.eu/snb/skill-type/skill 
        /// </summary>
        public List<TranslationText> EscoTargetType { get => _escoTargetType; set => _escoTargetType = value; }

        /// <summary>
        /// References to the ESCO Skill Pillar concept reusability levels.<br/>
        /// http://data.europa.eu/snb/skill-reuse-level/25831c2 <br/>
        /// http://data.europa.eu/snb/skill-reuse-level/transversal 
        /// </summary>
        public List<TranslationText> EscoSkillPillarReusabilityLevel { get => _escoSkillPillarReusabilityLevel; set => _escoSkillPillarReusabilityLevel = value; }

        /// <summary>
        /// References to the ESCO Skill.<br/>
        /// http://data.europa.eu/esco/model#Skill <br/>
        /// http://data.europa.eu/esco/skill/5bfdc193-f234-44c3-be1a-c1c85deb1bb8 
        /// </summary>
        public List<TranslationText> RelatedEscoSkill { get => _relatedEscoSkill; set => _relatedEscoSkill = value; }

        //Not outlined in the credential.xml file but still found to be useful.
        public List<TranslationText> EscoSkillDescription { get => _escoSkillDescription; set => _escoSkillDescription = value; }
    }
}
