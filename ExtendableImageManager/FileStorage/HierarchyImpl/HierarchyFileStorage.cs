using ExtendableImageManager.Core;
using ExtendableImageManager.UserException;
using ExtendableImageManager.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.FileStorage.HierarchyImpl
{
    public class HierarchyFileStorage : IFileStorage
    {
        private static string FILE_FOLDER_NAME = "efiles";
        private static string TEMP_FILE_FOLDER_NAME = "temp";

        private MainControl _mainControl;
        private string _fileFolder;
        private string _tempFileFolder;

        public void Init(MainControl mainControl)
        {
            _mainControl = mainControl;
            _fileFolder = Path.Combine(_mainControl.BaseFolder, FILE_FOLDER_NAME);
            _tempFileFolder = Path.Combine(_fileFolder, TEMP_FILE_FOLDER_NAME);
            Directory.CreateDirectory(_tempFileFolder);
        }

        // TODO: input argument checking - what if null / empty etc etc?

        private string getDirectoryPath(string fileName)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            var fn = Path.GetFileNameWithoutExtension(fileName);
            var path = _fileFolder + Path.DirectorySeparatorChar;
            for(int i=0; i<fn.Length; i+= 2)
            {
                var len = i + 2 <= fn.Length ? 2 : fn.Length - i;
                path += fn.Substring(i, len) + Path.DirectorySeparatorChar;
            }
            return path;
        }

        private string getFullPath(string fileName)
        {
            return Path.Combine(getDirectoryPath(fileName), Path.GetFileName(fileName));
        }

        private string getRandomFileName(string postfix)
        {
            var randomFileName = RandomFileNameUtils.GetRandomFileName();
            var directoryPath = getDirectoryPath(randomFileName);
            while (File.Exists(directoryPath) || Directory.Exists(directoryPath))
            {
                randomFileName = RandomFileNameUtils.GetRandomFileName();
                directoryPath = getDirectoryPath(randomFileName);
            }
            return randomFileName + postfix;
        }

        public string GetTempFilePath(string postfix)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            return RandomFileNameUtils.GetTempFileName(_tempFileFolder, postfix);
        }

        public string PutFile(string filePath)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            var targetFileName = getRandomFileName(Path.GetExtension(filePath));
            var targetFileFullPath = getFullPath(targetFileName);
            Directory.CreateDirectory(getDirectoryPath(targetFileName));
            File.Move(filePath, targetFileFullPath);
            return targetFileName;
        }

        public string GetFile(string fileName)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            return getFullPath(fileName);
        }

        private void deleteEmptyFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                // TODO: or throw exception?
                return;
            }
            if (Directory.EnumerateFileSystemEntries(folderPath).Any())
            {
                return;
            }
            var parentFolder = Directory.GetParent(folderPath).FullName;
            Directory.Delete(folderPath);
            deleteEmptyFolder(parentFolder);
        }

        public bool DeleteFile(string fileName)
        {
            if (_mainControl == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                throw new ResourceNotInitializedException(this.GetType().Name + ": function " + new StackTrace().GetFrame(1).GetMethod().Name + " called without inialization.");
            }
            var filePath = getFullPath(fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            var parentPath = Path.GetDirectoryName(filePath);
            deleteEmptyFolder(parentPath);

            return false;
        }
    }
}
