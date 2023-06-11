using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Converters.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Converters.Writers.Json
{
    public class JsonWriter : IWriter
    {
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public JsonWriter(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }

        public void Write(ModuleGuideDTO moduleGuide)
        {
            throw new NotImplementedException();
        }

        public void Write(ModuleDTO module)
        {
            throw new NotImplementedException();
        }
    }
}
