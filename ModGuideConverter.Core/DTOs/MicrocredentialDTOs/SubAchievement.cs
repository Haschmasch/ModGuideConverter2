using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    /// <summary>
    /// Partial achivements of the microcredential.
    /// </summary>
    public class SubAchievement
    {
        private SubAchievement? _childAchievement;
        private string _name;
        private string _description;
        private string? _grade;
        private TimeSpan? _duration;
        private DateTime? _issueDate;
        private string _verificationMethod;
        private DocumentRef? _document;

        public SubAchievement? ChildAchievement { get => _childAchievement; set => _childAchievement = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string? Grade { get => _grade; set => _grade = value; }
        public TimeSpan? Duration { get => _duration; set => _duration = value; }
        public DateTime? IssueDate { get => _issueDate; set => _issueDate = value; }
        /// <summary>
        /// Type of assesment.<br/>
        /// References to the Europass Standard List of Methods Of Supervision And Verification.<br/>
        /// http://data.europa.eu/snb/supervision-verification/25831c2 <br/>
        /// http://data.europa.eu/snb/supervision-verification/44314532f9
        /// </summary>
        public string VerificationMethod { get => _verificationMethod; set => _verificationMethod = value; }
        public DocumentRef? Document { get => _document; set => _document = value; }
    }
}
