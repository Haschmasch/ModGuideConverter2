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
        
        void Write(ModuleGuide moduleGuide, string branchname);

        void Write(Module module, string branchname);
    }
}
