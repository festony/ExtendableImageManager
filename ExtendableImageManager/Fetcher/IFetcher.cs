using ExtendableImageManager.Core;
using ExtendableImageManager.Persistence.Model;
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

        List<string> ExtractPageUrls(List<string> urls);

        void Fetch(string pageUrl);
    }
}
