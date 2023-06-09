using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.DTOs.MicrocredentialDTOs
{
    public class PersonalIdentity : Identity
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;

        public string FullName { get { return _firstName + _middleName + _lastName; } }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
    }
}
