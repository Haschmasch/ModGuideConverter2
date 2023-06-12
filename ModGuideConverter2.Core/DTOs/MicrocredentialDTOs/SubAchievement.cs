using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    /// <summary>
    /// Partial achivements of the microcredential.
    /// </summary>
    public class SubAchievement
    {
        private SubAchievement? _childAchievement;
        private List<TranslationText> _title;
        private List<TranslationText> _description;
        private string? _grade;
        private DateTime? _issueDate;
        private List<TranslationText>? _verificationMethod;
        private DocumentRef? _document;
        private LearningSpecification _learningSpecification;
        private QualifiedLerningSpecification? _qualifiedLerningSpecification;

        public SubAchievement? ChildAchievement { get => _childAchievement; set => _childAchievement = value; }
        public List<TranslationText> Title { get => _title; set => _title = value; }
        public List<TranslationText> Description { get => _description; set => _description = value; }
        public string? Grade { get => _grade; set => _grade = value; }
        public DateTime? IssueDate { get => _issueDate; set => _issueDate = value; }
        /// <summary>
        /// Type of assesment.<br/>
        /// References to the Europass Standard List of Methods Of Supervision And Verification.<br/>
        /// http://data.europa.eu/snb/supervision-verification/25831c2 <br/>
        /// http://data.europa.eu/snb/supervision-verification/44314532f9
        /// </summary>
        public List<TranslationText>? VerificationMethod { get => _verificationMethod; set => _verificationMethod = value; }
        public DocumentRef? Document { get => _document; set => _document = value; }
        public LearningSpecification LearningSpecification { get => _learningSpecification; set => _learningSpecification = value; }
        public QualifiedLerningSpecification? QualifiedLerningSpecification { get => _qualifiedLerningSpecification; set => _qualifiedLerningSpecification = value; }

        public SubAchievement()
        {
            _title = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Software Specification" } };
            _description = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Has attended the first part of Software Engineering for Requirements Specification" } };
            _learningSpecification = new LearningSpecification();
        }
    }
}
