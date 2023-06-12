using ModGuideConverter2.Converters;
using ModGuideConverter2.Converters.Readers.Json;
using ModGuideConverter2.Converters.Services;
using ModGuideConverter2.Converters.Writers.Json;
using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.DTOs.MicrocredentialDTOs;
using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Storage.DTOs;
using ModGuideConverter2.Storage.Git;
using NPOI.SS.Formula.Functions;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ModGuideConverter2.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RootDirectory rootDirectory = new RootDirectory { Path = @"B:\root" };

            RootService rootService = new RootService(rootDirectory);
            rootService.Add();

            ModuleGuideDirectory moduleGuideDirectory = new ModuleGuideDirectory();
            moduleGuideDirectory.RootDirectory = rootDirectory;
            moduleGuideDirectory.Name = "ModGuide1";

            IWriter writer = new JsonWriter(moduleGuideDirectory);
            StorageOperationService operationService = new StorageOperationService(writer);
            SignatureDTO signatureDTO = new SignatureDTO() { AuthorName = "Robin Hassler", AuthorEmail = "Robin.Hassler@example.com", Timestamp = DateTime.Now };
            operationService.AddModuleGuideDirectory(signatureDTO);

            operationService.AddWorktree("Branch1");
            operationService.AddModule(new ModuleDTO() { ModuleId = "123456"}, "Branch1");
            operationService.AddWorktree("Branch2");
            operationService.AddModule(new ModuleDTO() { ModuleId = "654321" }, "Branch2");
        }
    }
}