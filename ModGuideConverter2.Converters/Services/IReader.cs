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
    public interface IReader
    {
        ModuleGuideDirectory ModuleGuideDirectory { get; }

        ModuleGuideDTO ReadModuleGuide(string branchname);

        ModuleDTO ReadModule(string branchname, string modulename);
    }
}
