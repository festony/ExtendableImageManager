using ExtendableImageManager.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.DB
{
    public interface IDbForImage
    {
        void Init(string baseFolder);

        void Uninit();

        bool AddImage(string filename, string url, Dictionary<string, string> tags);

        Dictionary<string, TagItem> AllTags { get; }

        List<ImageItem> GetImages(FileFilter filter);

        void IgnoreTag(string tag);

        void UnignoreTag(string tag);
    }
}
