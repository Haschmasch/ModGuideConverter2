using ModGuideConverter2.Converters;
using ModGuideConverter2.Converters.Readers.Json;
using ModGuideConverter2.Converters.Writers.Json;
using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.DTOs.MicrocredentialDTOs;
using ModGuideConverter2.Core.Models;
using NPOI.SS.Formula.Functions;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ModGuideConverter2.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModuleGuideDirectory moduleGuideDirectory = new ModuleGuideDirectory();
            ModuleGuideDTO moduleGuide = new ModuleGuideDTO();
            ModuleGuideDTO moduleGuide1 = new ModuleGuideDTO();

            moduleGuideDirectory.RootDirectory = new RootDirectory() { Path = @"C:\Users\nicoh\OneDrive\Desktop\root" };
            moduleGuideDirectory.Name = "ModGuide";

            JsonWriter jsonWriter = new JsonWriter(moduleGuideDirectory);

            string path = Path.Combine(@"C:\Users\nicoh\OneDrive\Desktop\root", "ModGuide", "Master", "test" + ".json");
            string master = "Master";

            foreach (ModuleDTO module in moduleGuide.Modules)
            {
                module.SubAchievements.Add(new SubAchievement { QualifiedLerningSpecification = new QualifiedLerningSpecification()});
            }

            jsonWriter.Write(moduleGuide, master);

            JsonReader jsonReader = new JsonReader(moduleGuideDirectory);

            moduleGuide1 = jsonReader.ReadModuleGuide(master);
        }
    }
}