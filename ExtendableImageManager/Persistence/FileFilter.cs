using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Persistence
{
    public class FileFilter
    {
        // {criterion OR criterion OR criterion} AND {criterion OR criterion ...} ...
        public HashSet<HashSet<string>> AndOrCriteria { get; set; }

        // exclude these tags
        public HashSet<string> Not { get; set; }

        public bool IncludeVisited { get; set; }

        public bool IncludeNotVisited { get; set; }

        public bool IncludeLiked { get; set; }

        public bool IncludeNotLiked { get; set; }

        public bool IncludeDisliked { get; set; }

        public bool IncludeNotDisliked { get; set; }

        // true: do shuffling
        public bool DoShuffle { get; set; }
    }
}
