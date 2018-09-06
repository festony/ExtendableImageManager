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
        private string _fileFolder;

        public void Init(string baseFolder)
        {
            _fileFolder = Path.Combine(baseFolder, FILE_FOLDER_NAME);
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

        public string PutFile(string filePath)
        {
            if (_fileFolder == null)
            {
                Trace.WriteLine("Error: function called before initialize.");
                return null;
            }
            // TODO: implement this
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
            // TODO: implement this
            return getFullPath(fileName);
        }

    }
}
