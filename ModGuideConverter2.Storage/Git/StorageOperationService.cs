using ModGuideConverter.Core.DTOs;
using ModGuideConverter.Core.Models;
using ModGuideConverter2.Storage.DTOs;
using ModGuideConverter2.Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Git
{
    public class StorageOperationService : IStorageOperationsService
    {
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public StorageOperationService(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }

        public void AddModule()
        {
            throw new NotImplementedException();
        }

        public void AddModule(Module module)
        {
            throw new NotImplementedException();
        }

        public void AddModuleGuideDirectory()
        {
            throw new NotImplementedException();
        }

        public void CommitChanges(string message, SignatureDTO signature)
        {
            throw new NotImplementedException();
        }

        public void CopyModule(string sourceModuleId, string newModuleId)
        {
            throw new NotImplementedException();
        }

        public void CopyModule(ModuleGuideDirectory targetModuleGuideDirectory, string sourceModuleId, string newModuleId)
        {
            throw new NotImplementedException();
        }

        public void MergeChanges(SignatureDTO signature)
        {
            throw new NotImplementedException();
        }

        public void RemoveModule(string moduleId)
        {
            throw new NotImplementedException();
        }

        public void RemoveModuleGuideDirectory()
        {
            throw new NotImplementedException();
        }

        public void SetTag(string tag, string commitId)
        {
            throw new NotImplementedException();
        }

        public void UpdateModule(Module module)
        {
            throw new NotImplementedException();
        }

        public void UpdateModuleGuide(ModuleGuide moduleGuide)
        {
            throw new NotImplementedException();
        }
    }
}
