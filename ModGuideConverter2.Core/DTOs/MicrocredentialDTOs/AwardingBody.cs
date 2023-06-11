using ModGuideConverter2.Core.DTOs.GerneralDTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public class AwardingBody : Identity
    {
        private string _fullName;
        private string _altName;
        private Uri _homePage;

        public string FullName { get => _fullName; set => _fullName = value; }
        public string AltName { get => _altName; set => _altName = value; }
        public Uri HomePage { get => _homePage; set => _homePage = value; }

        public AwardingBody()
        {
            _fullName = "Duale Hochschule Baden Württemberg";
            _altName = "DHBW";
            _homePage = new Uri("https://www.dhbw.de/startseite");
        }
    }
}
