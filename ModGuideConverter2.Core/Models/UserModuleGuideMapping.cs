using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Core.Models
{
    public class UserModuleGuideMapping
    {
        private int _id;
        private ModuleGuideDirectory _moduleGuideDirectory;
        private int _moduleGuideDirectoryId;
        private ConverterUser _converterUser;
        //String because the user Id is a GUID
        private string _userId;

        public int Id { get => _id; set => _id = value; }

        [ForeignKey(nameof(ModuleGuideDirectory))]
        public int ModuleGuideDirectoryId { get => _moduleGuideDirectoryId; set => _moduleGuideDirectoryId = value; }

        public ModuleGuideDirectory ModuleGuideDirectory { get => _moduleGuideDirectory; set => _moduleGuideDirectory = value; }

        [ForeignKey(nameof(ConverterUser))]
        public string ConverterUserId { get => _userId; set => _userId = value; }

        public ConverterUser ConverterUser { get => _converterUser; set => _converterUser = value; }
    }
}
