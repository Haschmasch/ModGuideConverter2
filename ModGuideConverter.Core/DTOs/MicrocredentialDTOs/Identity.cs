using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public abstract class Identity
    {

        private string _email;
        private string _phone;
        private string _address;
        private string _city;
        private string _zipCode;
        private string _country;


        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public string City { get => _city; set => _city = value; }
        public string ZipCode { get => _zipCode; set => _zipCode = value; }
        public string Country { get => _country; set => _country = value; }
    }
}
