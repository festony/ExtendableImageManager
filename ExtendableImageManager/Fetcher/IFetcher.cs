using ExtendableImageManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Fetcher
{
    public interface IFetcher
    {
        void Init(MainControl mainControl);

        void Fetch(List<string> urls);
    }
}
