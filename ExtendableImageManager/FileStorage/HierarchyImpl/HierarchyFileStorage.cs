using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.FileStorage.HierarchyImpl
{
    public class HierarchyFileStorage : IFileStorage
    {
        private string _baseFolder;

        public void Init(string baseFolder)
        {
            _baseFolder = baseFolder;
        }

        public string PutFile(string filePath)
        {
            // TODO: implement this
            return null;
        }

        public string GetFile(string fileName)
        {
            // TODO: implement this
            return null;
        }

    }
}
