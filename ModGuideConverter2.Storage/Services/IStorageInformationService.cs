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
    public interface IStorageInformationService
    {
        ModuleGuideDirectory ModuleGuideDirectory { get; }

        /// <summary>
        /// Gets the master directory of the module guide
        /// </summary>
        /// <returns></returns>
        ModuleGuide GetModuleGuide();

        /// <summary>
        /// Gets a specified branch of the module guide.
        /// </summary>
        /// <param name="branchName"></param>
        /// <returns></returns>
        ModuleGuide GetModuleGuide(string branchName);

        /// <summary>
        /// Gets a specified commit of a branch of the module guide.
        /// </summary>
        /// <param name="branchName"></param>
        /// <param name="commitId"></param>
        /// <returns></returns>
        ModuleGuide GetModuleGuide(string branchName, string commitId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="branchName"></param>
        /// <param name="commitId"></param>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        Module GetModule(string branchName, string commitId, string moduleId);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<CommitDTO> GetCommits();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="branchName"></param>
        /// <returns></returns>
        List<CommitDTO> GetCommits(string branchName);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<TagDTO> GetTags();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="branchName"></param>
        /// <returns></returns>
        List<TagDTO> GetTags(string branchName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="branchName"></param>
        /// <returns></returns>
        List<ConflictDTO> GetConflicts(string branchName);
    }
}
