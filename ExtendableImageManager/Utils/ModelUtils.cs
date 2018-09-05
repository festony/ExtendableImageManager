using ExtendableImageManager.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Utils
{
    public class ModelUtils
    {
        public static string ToString(TagItem tag)
        {
            if (tag == null)
            {
                return "null";
            }
            return "{tag name: " + tag.tagName + ", tag type: " + tag.tagType + "}";
        }

        public static string ToString(ImageItem image)
        {
            if (image == null)
            {
                return "null";
            }
            string s = "{\n";
            s += "\tfileName: " + image.fileName + ",\n";
            s += "\turl: " + image.url + ",\n";
            s += "\ttags: [\n";
            foreach (var t in image.tags)
            {
                s += "\t\t" + ToString(t) + ",\n";
            }
            s += "\t],\n";
            s += "\tcreated: " + image.created + ",\n";
            s += "\tvisited: " + image.visited + ",\n";
            s += "\tliked: " + image.liked + ",\n";
            s += "\tdisliked: " + image.disliked + "\n}";

            return s;
        }
    }
}
