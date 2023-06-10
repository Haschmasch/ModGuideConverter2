using LibGit2Sharp;
using ModGuideConverter.Core.DTOs;
using ModGuideConverter.Core.Models;
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
        void AddModuleGuideDirectory();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleGuide"></param>
        void UpdateModuleGuide(ModuleGuide moduleGuide);

        /// <summary>
        /// 
        /// </summary>
        void RemoveModuleGuideDirectory();

        /// <summary>
        /// 
        /// </summary>
        void AddModule();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        void AddModule(Module module);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        void UpdateModule(Module module);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceModuleId"></param>
        /// <param name="newModuleId"></param>
        void CopyModule(string sourceModuleId, string newModuleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="targetModuleGuideDirectory"></param>
        /// <param name="sourceModuleId"></param>
        /// <param name="newModuleId"></param>
        void CopyModule(ModuleGuideDirectory targetModuleGuideDirectory, string sourceModuleId, string newModuleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleId"></param>
        void RemoveModule(string moduleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="signature"></param>
        void CommitChanges(string message, SignatureDTO signature);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signature"></param>
        void MergeChanges(SignatureDTO signature);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="commitId"></param>
        void SetTag (string tag, string commitId);
    }
}
