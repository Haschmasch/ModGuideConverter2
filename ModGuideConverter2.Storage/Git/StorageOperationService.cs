using LibGit2Sharp;
using ModGuideConverter2.Converters.Services;
using ModGuideConverter2.Core.DTOs;
using ModGuideConverter2.Core.Models;
using ModGuideConverter2.Storage.DTOs;
using ModGuideConverter2.Storage.Services;
using NPOI.HPSF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModGuideConverter2.Storage.Git
{
    public class StorageOperationService : StorageService, IStorageOperationsService
    {
        private IWriter _fileWriter;
        public ModuleGuideDirectory ModuleGuideDirectory { get; }

        public StorageOperationService(IWriter fileWriter)
        {
            _fileWriter = fileWriter;
            ModuleGuideDirectory = fileWriter.ModuleGuideDirectory;
        }

        public void AddModule(string branchName)
        {
            _fileWriter.Write(new ModuleGuideDTO(), branchName);
        }

        public void AddModule(ModuleDTO module, string branchName)
        {
            _fileWriter.Write(module, branchName);
        }

        public void AddModuleGuideDirectory(SignatureDTO signature)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name);
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            //Create the Module guide directory
            directoryInfo.Create();
            //Setup the master branch
            directoryInfo.CreateSubdirectory(DEFAULT_BRANCH_NAME);
            path = Path.Combine(path, DEFAULT_BRANCH_NAME);
            //Init repo
            Repository.Init(path, false);
            //Create default folders
            directoryInfo = new DirectoryInfo(path);
            directoryInfo.CreateSubdirectory(FOLDERNAME_MODULES);
            directoryInfo.CreateSubdirectory(FOLDERNAME_UPLOADS);

            //add .gitignore
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(GITIGNORE_RESOURCENAME))
            {
                using (var file = new FileStream(Path.Combine(path, GITIGNORE_NAME), FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }

            //Create a empty .gitkeep-file to force git to track this directory
            using (File.Create(Path.Combine(path, FOLDERNAME_UPLOADS, ".gitkeep"))) { }

            //Add default module guide and modules
            _fileWriter.Write(new ModuleGuideDTO(), DEFAULT_BRANCH_NAME);

            //Add initial commit
            using (var repo = new Repository(path))
            {
                RepositoryStatus status = repo.RetrieveStatus();
                //Stage added files/directories
                List<string> filePaths = status.Untracked.Select(mods => mods.FilePath).ToList();
                Commands.Stage(repo, filePaths);

                Signature gitSignature = new Signature(signature.AuthorName, signature.AuthorEmail, signature.Timestamp);
                repo.Commit("Initial commit", gitSignature, gitSignature);
            }
        }

        public void CommitChanges(string branchName, string message, SignatureDTO signature)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchName);
            using (var repo = new Repository(path))
            {
                Signature gitSignature = new Signature(signature.AuthorName, signature.AuthorEmail, signature.Timestamp);

                RepositoryStatus status = repo.RetrieveStatus();
                List<string> filePaths = status.Untracked.Select(mods => mods.FilePath).ToList();
                filePaths.AddRange(status.Added.Select(mods => mods.FilePath).ToList());
                filePaths.AddRange(status.Removed.Select(mods => mods.FilePath).ToList());
                filePaths.AddRange(status.Modified.Select(mods => mods.FilePath).ToList());
                Commands.Stage(repo, filePaths);

                repo.Commit(message, gitSignature, gitSignature);
            }
        }

        public void CopyModule(string branchName, string sourceModuleName, string newModuleName)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchName, FOLDERNAME_MODULES);
            File.Copy(
                Path.Combine(
                    path, sourceModuleName + DEFAULT_FILE_EXTENSION),
                Path.Combine(
                    path, newModuleName + DEFAULT_FILE_EXTENSION), 
                false);

        }

        public void CopyModule(string branchName, ModuleGuideDirectory targetModuleGuideDirectory, string sourceModuleName, string newModuleName)
        {
            string sourcePath = Path.Combine(targetModuleGuideDirectory.RootDirectory.Path, targetModuleGuideDirectory.Name, branchName, FOLDERNAME_MODULES);
            string targetPath = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchName, FOLDERNAME_MODULES);
            File.Copy(
                Path.Combine(
                    sourcePath, sourceModuleName + DEFAULT_FILE_EXTENSION),
                Path.Combine(
                    targetPath, newModuleName + DEFAULT_FILE_EXTENSION),
                false);
        }

        public void MergeChanges(string branchName, SignatureDTO signature)
        {
            string path = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchName);
            using (var repo = new Repository(path))
            {
                Signature gitSignature = new Signature(signature.AuthorName, signature.AuthorEmail, signature.Timestamp);
            }
        }

        public void RemoveModule(string branchName, string moduleName)
        {
            throw new NotImplementedException();
        }

        public void RemoveModuleGuideDirectory()
        {
            throw new NotImplementedException();
        }

        public void SetTag(string tag, string commitId)
        {
            throw new NotImplementedException();
        }

        public void UpdateModule(ModuleDTO module, string branchName)
        {
            throw new NotImplementedException();
        }

        public void UpdateModuleGuide(ModuleGuideDTO moduleGuide, string branchName)
        {
            throw new NotImplementedException();
        }

        public void AddWorktree(string branchName)
        {
            string sourcePath = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, DEFAULT_BRANCH_NAME);
            DirectoryInfo directoryInfo = new DirectoryInfo(sourcePath);
            using (var repo = new Repository(sourcePath))
            {
                var path = Path.Combine(directoryInfo.Parent.FullName, branchName);
                repo.Worktrees.Add(branchName, path, false);
            }
            sourcePath = Path.Combine(ModuleGuideDirectory.RootDirectory.Path, ModuleGuideDirectory.Name, branchName);
            using (var repo = new Repository(sourcePath))
            {
                var path = Path.Combine(directoryInfo.Parent.FullName, branchName);
                repo.Reset(ResetMode.Hard);
            }
        }
    }
}
