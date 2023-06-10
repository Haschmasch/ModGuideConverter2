using ModGuideConverter.Core.Models;
using ModGuideConverter2.Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Git
{
    public class RootService : IRootService
    {
        public RootDirectory RootDirectory { get; }

        public RootService(RootDirectory rootDirectory)
        {
            RootDirectory = rootDirectory;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
