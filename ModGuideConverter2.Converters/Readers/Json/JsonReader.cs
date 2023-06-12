using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Converters.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ModGuideConverter2.Core.DTOs;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace ModGuideConverter2.Converters.Readers.Json
{
    public class JsonReader : IReader
    {

        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public JsonReader(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }
        
        public Module ReadModule(string branchname, string modulename)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchname, "Modules", modulename + ".json");
            using (StreamReader reader = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();

                if (serializer.Deserialize(reader, typeof(Module)) is Module module)
                {
                    return module;
                }
            }
            throw new InvalidOperationException("Deserialized object was not of type Module");
        }

        public ModuleGuide ReadModuleGuide(string branchname)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchname, ModuleGuideDirectory.Name + ".json");
            using (StreamReader reader = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();

                if (serializer.Deserialize(reader, typeof(ModuleGuide)) is ModuleGuide moduleguide)
                {
                    return moduleguide;
                }
            }
            throw new InvalidOperationException("Deserialized object was not of type ModuleGuide");
        }
    }
}
