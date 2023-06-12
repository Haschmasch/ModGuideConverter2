using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Converters.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs;

namespace ModGuideConverter2.Converters.Readers.Excel
{
    public class ExcelReader : IReader
    {
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public ExcelReader(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }

        public ModuleDTO ReadModule(string branchname, string modulename)
        {
            throw new NotImplementedException();
        }

        public ModuleGuideDTO ReadModuleGuide(string branchname)
        {
            throw new NotImplementedException();
        }
    }
}
