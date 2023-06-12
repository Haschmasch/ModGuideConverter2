using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Git
{
    public abstract class StorageService
    {
        public const string DEFAULT_FILE_EXTENSION = ".json";
        public const string DEFAULT_BRANCH_NAME = "master";
        public const string FOLDERNAME_MODULES = "Modules";
        public const string FOLDERNAME_UPLOADS = "Uploads";
        public const string GITIGNORE_RESOURCENAME = "ModGuideConverter2.Storage.Templates..gitignore";
        public const string GITIGNORE_NAME = ".gitignore";
    }
}
