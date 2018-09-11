using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Persistence
{
    public class FileFilter
    {
        public List<List<string>> AndOrCriteria { get; set; }

        public List<string> Not { get; set; }

        public bool Visited { get; set; }

        public bool Liked { get; set; }

        public bool Disliked { get; set; }
    }
}
