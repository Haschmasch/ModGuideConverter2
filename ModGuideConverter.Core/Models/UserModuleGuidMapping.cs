using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.Models
{
    public class UserModuleGuidMapping
    {
        private int _id;
        private int _moduleGuideDirectoryId;
        private int _userId;

        public int Id { get => _id; set => _id = value; }
        public int ModuleGuideDirectoryId { get => _moduleGuideDirectoryId; set => _moduleGuideDirectoryId = value; }
        public int UserId { get => _userId; set => _userId = value; }
    }
}
