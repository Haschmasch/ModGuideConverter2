using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.Models
{
    public class ModuleGuideDirectory
    {
        private int _id;
        private RootDirectory _rootDirectory;
        private int _rootDirectoryId;
        private string _name;
        private DateTime _created;
        private string _description;

        public int Id { get => _id; set => _id = value; }

        [ForeignKey(nameof(Models.RootDirectory))]
        public int RootDirectoryId { get => _rootDirectoryId; set => _rootDirectoryId = value; }

        public RootDirectory RootDirectory { get => _rootDirectory; set => _rootDirectory = value; }

        public string Name { get => _name; set => _name = value; }

        public DateTime Created { get => _created; set => _created = value; }

        public string Description { get => _description; set => _description = value; }
    }
}
