using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter.Core.Models
{
    public class RootDirectory
    {
        private int _id;
        private string _name;
        private string _description;
        private DateTime _created;
        private string _path;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Created { get => _created; set => _created = value; }
        public string Path { get => _path; set => _path = value; }

        public RootDirectory()
        {
            _name = String.Empty;
            _description = String.Empty;
            _path = String.Empty;
        }
    }
}
