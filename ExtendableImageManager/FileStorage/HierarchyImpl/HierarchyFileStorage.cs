using ExtendableImageManager.Core;
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
            _fileFolder = Path.Combine(mainControl.BaseFolder, FILE_FOLDER_NAME);
            _tempFileFolder = Path.Combine(_fileFolder, TEMP_FILE_FOLDER_NAME);
            Directory.CreateDirectory(_tempFileFolder);
            _mainControl = mainControl;
        }

        private string getDirectoryPath(string fileName)
        {
            // TODO: maybe change this to exception throw
            if (_fileFolder == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
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
            if (_fileFolder == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            return RandomFileNameUtils.GetTempFileName(_tempFileFolder, postfix);
        }

        public string PutFile(string filePath)
        {
            if (_fileFolder == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            var targetFileName = getRandomFileName(Path.GetExtension(filePath));
            var targetFileFullPath = getFullPath(targetFileName);
            Directory.CreateDirectory(getDirectoryPath(targetFileName));
            File.Move(filePath, targetFileFullPath);
            return null;
        }

        public string GetFile(string fileName)
        {
            if (_fileFolder == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            return getFullPath(fileName);
        }

    }
}
