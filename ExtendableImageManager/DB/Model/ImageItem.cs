using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.DB.Model
{
    public class ImageItem
    {
        public string fileName;
        public string url;
        public List<TagItem> tags;

        public DateTime created;
        //public int width = 0;
        //public int height = 0;

        public bool visited = false;
        public bool liked = false;
        public bool disliked = false;
    }
}
