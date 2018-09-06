using ExtendableImageManager.Core;
using ExtendableImageManager.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Persistence
{
    public interface IPersistenceForImage
    {
        void Init(MainControl mainControl);

        void Uninit();

        bool AddImage(string filename, string url, Dictionary<string, string> tags);

        Dictionary<string, TagItem> AllTags { get; }

        List<ImageItem> GetImages(FileFilter filter);

        void IgnoreTag(string tag);

        void UnignoreTag(string tag);

        Dictionary<string, TagItem> AllIgnoredTags { get; }
    }
}
