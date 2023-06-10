using ModGuideConverter.Core.Models;
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
        /// 
        /// </summary>
        void Add();

        /// <summary>
        /// 
        /// </summary>
        void Remove();
    }
}
