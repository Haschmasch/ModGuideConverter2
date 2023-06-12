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
using Org.BouncyCastle.Crypto.Agreement.JPake;

namespace ModGuideConverter2.Converters.Readers.Json
{
    public class JsonReader : IReader
    {

        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public JsonReader(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }
        
        public ModuleDTO ReadModule(string branchname, string modulename)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchname, "Modules", modulename + ".json");
            using (StreamReader reader = File.OpenText(path))
            {
                ModuleDTO? module = JsonConvert.DeserializeObject<ModuleDTO>(reader.ReadToEnd(), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    ObjectCreationHandling = ObjectCreationHandling.Replace
                });

                if (module != null)
                {
                    return module;
                }
            }
            throw new InvalidOperationException("Deserialized object was not of type Module");
        }

        public ModuleGuideDTO ReadModuleGuide(string branchname)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchname, ModuleGuideDirectory.Name + ".json");
            using (StreamReader reader = File.OpenText(path))
            {
                ModuleGuideDTO? moduleGuide = JsonConvert.DeserializeObject<ModuleGuideDTO>(reader.ReadToEnd(), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    ObjectCreationHandling = ObjectCreationHandling.Replace
                });

                if (moduleGuide != null)
                {
                    return moduleGuide;
                }
            }
            throw new InvalidOperationException("Deserialized object was not of type ModuleGuide");
        }
    }
}
