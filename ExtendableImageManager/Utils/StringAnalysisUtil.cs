using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Utils
{
    public class StringAnalysisUtil
    {
        public static string GetSubString(string str, string startMark, string endMark)
        {
            int pStart = str.IndexOf(startMark) + startMark.Length;
            int pEnd = str.IndexOf(endMark, pStart);
            return str.Substring(pStart, pEnd - pStart);
        }
    }
}
