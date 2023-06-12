using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Git
{
    public class RootService : StorageService, IRootService
    {
        public RootDirectory RootDirectory { get; }

        public RootService(RootDirectory rootDirectory)
        {
            RootDirectory = rootDirectory;
        }

        /// <summary>
        /// This is a implementation of adding root directories.<br/>
        /// <inheritdoc/>
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Add()
        {
            DirectoryInfo rootInfo = new DirectoryInfo(RootDirectory.Path);
            if(rootInfo.Exists is false)
            { 
                rootInfo.Create();
            }
        }

        public void Remove()
        {
            DirectoryInfo rootInfo = new DirectoryInfo(RootDirectory.Path);
            if (rootInfo.Exists)
            {
                rootInfo.Delete(true);
            }
        }
    }
}
