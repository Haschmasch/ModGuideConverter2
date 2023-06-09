using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter.Core.DTOs.MicrocredentialDTOs;

namespace ModGuideConverter.Core.DTOs
{
    public class Microcredential
    {
        private List<TranslationText> _name;
        private List<TranslationText> _description;
        private DateTime _dateOfIssue;
        private string _primaryLanguageShort;
        private List<string> _availableLanguages;
        private Identity _identification;
        private AwardingBody _awardingBody;
        private List<LearningOutcome> _learningOutcomes;
        private List<Assessment> _assessments;
        private List<LearningActivity> _learningActivities;
        private List<SubAchievement> _subAchievements;
        private List<TranslationText> _requirements;
    }
}
