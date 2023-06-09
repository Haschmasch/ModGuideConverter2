using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public class LearningOutcome
    {
        //Interpretation of "prefLabel" from exported xml. Origin unclear.
        private List<TranslationText> _title;
        private List<TranslationText> _escoTargetType;
        private List<TranslationText> _escoSkillPillarReusabilityLevel;
        private List<TranslationText> _relatedEscoSkill;
        //Not outlined in the credential.xml file but still found to be useful.
        private List<TranslationText> _escoSkillDescription;

        public List<TranslationText> Title { get => _title; set => _title = value; }
        public List<TranslationText> EscoTargetType { get => _escoTargetType; set => _escoTargetType = value; }
        public List<TranslationText> EscoSkillPillarReusabilityLevel { get => _escoSkillPillarReusabilityLevel; set => _escoSkillPillarReusabilityLevel = value; }
        public List<TranslationText> RelatedEscoSkill { get => _relatedEscoSkill; set => _relatedEscoSkill = value; }
        public List<TranslationText> EscoSkillDescription { get => _escoSkillDescription; set => _escoSkillDescription = value; }
    }
}
