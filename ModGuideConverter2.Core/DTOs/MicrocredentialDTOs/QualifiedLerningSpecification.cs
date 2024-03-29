﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public class QualifiedLerningSpecification
    {
        private List<TranslationText> _learningOpportunity;

        private List<TranslationText> _isced_FCode;

        private int _ectsCredits;

        private List<TranslationText> _learningMode;

        private List<TranslationText> _learningSettingTypeMode;

        private List<TranslationText> _entryRequirements;

        private bool _isPartialQualification;

        private List<TranslationText> _eqfLevel;

        private List<TranslationText> _nqfLevel;


        /// <summary>
        /// References to the Europass Standard List of Learning Opportunity Types.<br/>
        /// http://data.europa.eu/snb/learning-opportunity/25831c2 <br/>
        /// http://data.europa.eu/snb/learning-opportunity/05053c1cbe
        /// </summary>
        public List<TranslationText> LearningOpportunity { get => _learningOpportunity; set => _learningOpportunity = value; }
       
        /// <summary>
        /// References to the International Standard Classification of Education: Fields of Education and Training 2013.<br/>
        /// http://data.europa.eu/snb/isced-f/25831c2 <br/>
        /// http://data.europa.eu/snb/isced-f/0613
        /// </summary>
        public List<TranslationText> Isced_FCode { get => _isced_FCode; set => _isced_FCode = value; }

        public int EctsCredits { get => _ectsCredits; set => _ectsCredits = value; }
       
        /// <summary>
        /// References to the Europass Standard List of Modes Of Learning and Assessment.<br/>
        /// http://data.europa.eu/snb/learning-assessment/25831c2 <br/>
        /// http://data.europa.eu/snb/learning-assessment/7813801c77
        /// </summary>
        public List<TranslationText> LearningMode { get => _learningMode; set => _learningMode = value; }
        
        /// <summary>
        /// References to the Europass Standard List Of Learning Setting Types.<br/>
        /// http://data.europa.eu/snb/learning-setting/25831c2 <br/>
        /// http://data.europa.eu/snb/learning-setting/e207a81fc7
        /// </summary>
        public List<TranslationText> LearningSettingTypeMode { get => _learningSettingTypeMode; set => _learningSettingTypeMode = value; }
        
        public List<TranslationText> EntryRequirements { get => _entryRequirements; set => _entryRequirements = value; }
        
        public bool IsPartialQualification { get => _isPartialQualification; set => _isPartialQualification = value; }
        
        /// <summary>
        /// References to the European Qualifications Framework.<br/>
        /// http://data.europa.eu/snb/eqf/25831c2 <br/>
        /// http://data.europa.eu/snb/eqf/2
        /// </summary>
        public List<TranslationText> EqfLevel { get => _eqfLevel; set => _eqfLevel = value; }
        
        /// <summary>
        /// References to the European Qualifications Framework.<br/>
        /// http://data.europa.eu/snb/eqf/25831c2 <br/>
        /// http://data.europa.eu/snb/qdr/c_c71cce15
        /// </summary>
        public List<TranslationText> NqfLevel { get => _nqfLevel; set => _nqfLevel = value; }

        public QualifiedLerningSpecification()
        {
            _learningOpportunity = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Course" } };
            _isced_FCode = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Software and applications development and analysis" } };
            _ectsCredits = 3;
            _learningMode = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Project based" } };
            _learningSettingTypeMode = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "non-formal learning" } };
            _entryRequirements = new List<TranslationText>() { new TranslationText() { LanguageShort = "en", Text = "None" } };
            _isPartialQualification = false;
            _eqfLevel = new List<TranslationText>() { new TranslationText() { LanguageShort = "en", Text = "Level 2" } };
            _nqfLevel = new List<TranslationText>() { new TranslationText() { LanguageShort = "en", Text = "DQR Level 2" } };
        }
    }
}
