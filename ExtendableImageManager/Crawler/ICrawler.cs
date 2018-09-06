using ExtendableImageManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Crawler
{
    public interface ICrawler
    {
        int Timeout { get; set; }

        void Init(MainControl mainControl);

        string FetchHtml(string url);

        string FetchFile(string url);
    }
}
