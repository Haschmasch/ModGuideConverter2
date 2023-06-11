using ModGuideConverter2.Core.DTOs.GerneralDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public abstract class Identity
    {

        private string _email;
        private string _phone;
        private string _address;
        private string _city;
        private string _zipCode;
        private List<TranslationText> _country;

        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string ZipCode { get => _zipCode; set => _zipCode = value; }

        /// <summary>
        /// Country as defined in europass .xml<br/>
        /// http://publications.europa.eu/resource/authority/country<br/>
        /// http://publications.europa.eu/resource/authority/country/DEU
        /// </summary>
        public List<TranslationText> Country { get => _country; set => _country = value; }

        protected Identity()
        {
            _email = "poststelle@dhbw.de";
            _phone = "0497113206600";
            _address = "Friedrichstraße 14";
            _city = "Stuttgart";
            _zipCode = "70174";
            _country = new List<TranslationText>() { new TranslationText { LanguageShort = "en", Text = "Germany" } };
        }
    }
}
