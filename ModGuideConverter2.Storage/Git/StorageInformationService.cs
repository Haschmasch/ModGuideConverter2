using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Storage.DTOs;
using ModGuideConverter2.Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Git
{
    public class StorageInformationService : IStorageInformationService
    {
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public StorageInformationService(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }

        public List<CommitDTO> GetCommits()
        {
            throw new NotImplementedException();
        }

        public List<CommitDTO> GetCommits(string branchName)
        {
            throw new NotImplementedException();
        }

        public List<ConflictDTO> GetConflicts(string branchName)
        {
            throw new NotImplementedException();
        }

        public ModuleDTO GetModule(string branchName, string commitId, string moduleId)
        {
            throw new NotImplementedException();
        }

        public ModuleGuideDTO GetModuleGuide()
        {
            throw new NotImplementedException();
        }

        public ModuleGuideDTO GetModuleGuide(string branchName)
        {
            throw new NotImplementedException();
        }

        public ModuleGuideDTO GetModuleGuide(string branchName, string commitId)
        {
            throw new NotImplementedException();
        }

        public List<TagDTO> GetTags()
        {
            throw new NotImplementedException();
        }

        public List<TagDTO> GetTags(string branchName)
        {
            throw new NotImplementedException();
        }
    }
}
