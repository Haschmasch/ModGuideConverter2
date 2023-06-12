using ModGuideConverter2.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Services
{
    public interface IRootService
    {
        public RootDirectory RootDirectory { get; }
        /// <summary>
        /// Adds a root directory
        /// </summary>
        void Add();

        /// <summary>
        /// 
        /// </summary>
        void Remove();
    }
}
