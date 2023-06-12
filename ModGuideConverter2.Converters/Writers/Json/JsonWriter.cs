using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Converters.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModGuideConverter2.Converters.Writers.Json
{
    public class JsonWriter : IWriter
    {

        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public JsonWriter(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }

        public void Write(ModuleGuide moduleGuide, string branchname)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchname, ModuleGuideDirectory.Name + ".json");
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, moduleGuide);
            }
        }

        public void Write(Module module, string branchname)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchname, ModuleGuideDirectory.Name + ".json");
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, module);
            }
        }
    }
}
