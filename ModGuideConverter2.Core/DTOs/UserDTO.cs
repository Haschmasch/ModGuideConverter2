using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.DTOs
{
    public class UserDTO : LoginUserDTO
    {
        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<string> Roles { get; set; }
    }
}
