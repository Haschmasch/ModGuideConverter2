using ModGuideConverter2.Core.DTOs.GerneralDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public class PersonalIdentity : Identity
    {
        private string _firstName;
        private string? _middleName;
        private string _lastName;

        public string FullName
        { 
            get 
            { 
                if (MiddleName == null)
                 return $"{_firstName} {_lastName}"; 
                else
                 return $"{_firstName} {_middleName} {_lastName}"; 
            }
        }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string? MiddleName { get => _middleName; set => _middleName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public PersonalIdentity()
        {
            _firstName = "Max";
            _lastName = "Mustermann";
            base.City = "Musterstadt";
            base.Address = "Musterstraße 42";
            base.Email = "Max.Mustermann@Mustermail.com";
            base.Country = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Germany" } };
            base.ZipCode = "000000";
        }
    }
}
