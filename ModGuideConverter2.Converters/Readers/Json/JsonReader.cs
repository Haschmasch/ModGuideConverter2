using ModGuideConverter.Core.Models;
using ModGuideConverter2.Converters.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Converters.Readers.Json
{
    public class JsonReader : IReader
    {
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public JsonReader(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }

        public void ReadModule()
        {
            throw new NotImplementedException();
        }

        public void ReadModuleGuide()
        {
            throw new NotImplementedException();
        }
    }
}
