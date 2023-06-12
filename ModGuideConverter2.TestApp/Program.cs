using ModGuideConverter2.Converters;
using ModGuideConverter2.Converters.Readers.Json;
using ModGuideConverter2.Converters.Writers.Json;
using ModGuideConverter2.Core.DTOs;
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
            ModuleGuide moduleGuide = new ModuleGuide();
            Console.WriteLine("Hello, World!");
            JsonWriter jsonWriter = new JsonWriter(moduleGuideDirectory);
            string path = Path.Combine("C: /Users/nicoh/OneDrive/Desktop/root", "/ModGuide", "/Master", "test" + ".json");
            jsonWriter.Write(moduleGuide, path);
            JsonReader jsonReader = new JsonReader(moduleGuideDirectory);
            jsonReader.ReadModuleGuide(path);
        }
    }
}