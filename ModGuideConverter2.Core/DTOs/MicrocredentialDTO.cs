using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.MicrocredentialDTOs;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;
using Newtonsoft.Json;
using System.Data;

namespace ModGuideConverter2.Core.DTOs
{
    /// <summary>
    /// Contains all properites to from a EU-compliant microcredential.<br/>
    /// See Annex 1 of the following link:<br/>
    /// <see cref="https://eur-lex.europa.eu/legal-content/EN/TXT/HTML/?uri=CELEX:32022H0627(02)#ntc2-C_2022243EN.01001001-E0002"/>
    /// </summary>
    public class MicrocredentialDTO
    {
        private List<TranslationText> _name;
        private List<TranslationText> _description;
        private DateTime _dateOfIssue;
        private TimeSpan _attendanceTime;
        private TimeSpan _selfStudyTime;
        private string _primaryLanguageShort;
        private int _totalEctsCredits;
        private string? _grade;
        private List<string> _availableLanguages;
        private List<List<TranslationText>> _instructionalLanguages;
        private Identity _identification;
        private AwardingBody _awardingBody;
        private List<LearningOutcome> _learningOutcomes;
        private List<Assessment> _assessments;
        private List<LearningActivity> _learningActivities;
        private List<SubAchievement> _subAchievements;

        public List<TranslationText> Name { get => _name; set => _name = value; }
        public List<TranslationText> Description { get => _description; set => _description = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }
        public TimeSpan AttendanceTime { get => _attendanceTime; set => _attendanceTime = value; }
        public TimeSpan SelfStudyTime { get => _selfStudyTime; set => _selfStudyTime = value; }
        public TimeSpan TotalWorkloadTime
        {
            get
            {
                TimeSpan timeSpan = TimeSpan.Zero;
                timeSpan.Add(SelfStudyTime);
                timeSpan.Add(AttendanceTime);
                return timeSpan;
            }
        }
        public string PrimaryLanguageShort { get => _primaryLanguageShort; set => _primaryLanguageShort = value; }
        public int TotalEctsCredits { get => _totalEctsCredits; set => _totalEctsCredits = value; }
        public List<string> AvailableLanguages { get => _availableLanguages; set => _availableLanguages = value; }
        public Identity Identification { get => _identification; set => _identification = value; }
        public AwardingBody AwardingBody { get => _awardingBody; set => _awardingBody = value; }
        public List<LearningOutcome> LearningOutcomes { get => _learningOutcomes; set => _learningOutcomes = value; }
        public List<Assessment> Assessments { get => _assessments; set => _assessments = value; }
        public List<LearningActivity> LearningActivities { get => _learningActivities; set => _learningActivities = value; }
        public List<SubAchievement> SubAchievements { get => _subAchievements; set => _subAchievements = value; }
        public List<List<TranslationText>> InstructionalLanguages { get => _instructionalLanguages; set => _instructionalLanguages = value; }
        public string? Grade { get => _grade; set => _grade = value; }

        public MicrocredentialDTO()
        {
            _name = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Software Engineering" } };
            _description = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "passed the Software Engineering Lecture in 2 Semesters." } };
            _dateOfIssue = DateTime.Now;
            _attendanceTime = TimeSpan.Zero;
            _selfStudyTime = TimeSpan.Zero;
            _primaryLanguageShort = "en";
            _totalEctsCredits = 3;
            _availableLanguages = new List<string>() { "en" };
            _instructionalLanguages = new List<List<TranslationText>>() { new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "English" } } };
            _identification = new PersonalIdentity();
            _awardingBody = new AwardingBody();
            _learningOutcomes = new List<LearningOutcome>() { new LearningOutcome() };
            _assessments = new List<Assessment>() { new Assessment() };
            _learningActivities = new List<LearningActivity>() { new LearningActivity() };
            _subAchievements = new List<SubAchievement>() { new SubAchievement() };
        }
    }
}
