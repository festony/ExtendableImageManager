using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.FileStorage
{
    public interface IFileStorage
    {
        void Init(string baseFolder);

        string PutFile(string filePath);

        string GetFile(string fileName);
    }
}
