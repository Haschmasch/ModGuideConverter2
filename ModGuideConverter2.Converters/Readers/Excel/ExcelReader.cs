using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Converters.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Converters.Readers.Excel
{
    public class ExcelReader : IReader
    {
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public ExcelReader(ModuleGuideDirectory moduleGuideDirectory)
        {
            ModuleGuideDirectory = moduleGuideDirectory;
        }

        public void ReadModule()
        {
            throw new NotImplementedException();
        }

        public void ReadModuleGuide()
        {
            throw new NotImplementedException();
        }
    }
}
