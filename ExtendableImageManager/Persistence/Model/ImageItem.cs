using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Persistence.Model
{
    [Serializable]
    public class ImageItem
    {
        public string fileName;
        public string pageUrl;
        public List<TagItem> tags;

        public DateTime created;
        //public int width = 0;
        //public int height = 0;

        public bool fetched = false;
        public bool visited = false;
        public bool liked = false;
        public bool disliked = false;
    }
}
