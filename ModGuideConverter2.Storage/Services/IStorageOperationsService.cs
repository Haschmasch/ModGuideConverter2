using LibGit2Sharp;
using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Storage.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Services
{
    public interface IStorageOperationsService
    {
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        /// <summary>
        /// 
        /// </summary>
        void AddModuleGuideDirectory(SignatureDTO signature);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleGuide"></param>
        void UpdateModuleGuide(ModuleGuideDTO moduleGuide, string branchName);

        /// <summary>
        /// 
        /// </summary>
        void RemoveModuleGuideDirectory();

        /// <summary>
        /// 
        /// </summary>
        void AddModule(string branchName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        /// <param name="branchName"></param>
        void AddModule(ModuleDTO module, string branchName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        /// <param name="branchName"></param>
        void UpdateModule(ModuleDTO module, string branchName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceModuleName"></param>
        /// <param name="newModuleName"></param>
        void CopyModule(string branchName, string sourceModuleName, string newModuleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetModuleGuideDirectory"></param>
        /// <param name="sourceModuleId"></param>
        /// <param name="newModuleId"></param>
        void CopyModule(string branchName, ModuleGuideDirectory targetModuleGuideDirectory, string sourceModuleId, string newModuleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleName"></param>
        void RemoveModule(string branchName, string moduleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="signature"></param>
        void CommitChanges(string branchName, string message, SignatureDTO signature);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signature"></param>
        void MergeChanges(string sourceBranchName, SignatureDTO signature);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="commitId"></param>
        void SetTag (string tag, string commitId);

        /// <summary>
        /// 
        /// </summary>
        void AddWorktree(string branchName);
    }
}
