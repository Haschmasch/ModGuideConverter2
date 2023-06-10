﻿using ModGuideConverter.Core.DTOs;
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

        public Module GetModule(string branchName, string commitId, string moduleId)
        {
            throw new NotImplementedException();
        }

        public ModuleGuide GetModuleGuide()
        {
            throw new NotImplementedException();
        }

        public ModuleGuide GetModuleGuide(string branchName)
        {
            throw new NotImplementedException();
        }

        public ModuleGuide GetModuleGuide(string branchName, string commitId)
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