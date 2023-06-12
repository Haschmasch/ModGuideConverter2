using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Converters.Services
{
    public interface IWriter
    {
        ModuleGuideDirectory ModuleGuideDirectory { get; }
        
        void Write(ModuleGuideDTO moduleGuide, string branchname);

        void Write(ModuleDTO module, string branchname);
    }
}
