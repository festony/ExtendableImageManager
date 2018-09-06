using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.Utils
{
    public class RandomFileNameUtils
    {
        private static Random random = new Random();

        private static int MIN_FILE_INT = 100000001;
        private static int MAX_FILE_INT = 999990990;

        public static string GetRandomFileName()
        {
            return random.Next(100000001, 900000000).ToString();
        }

        public static string GetTempFileName(string baseTempFolder, string postfix)
        {
            var path = Path.Combine(baseTempFolder, Path.ChangeExtension(Path.GetRandomFileName(), postfix));
            while (Directory.Exists(path) || File.Exists(path))
            {
                path = Path.Combine(baseTempFolder, Path.ChangeExtension(Path.GetRandomFileName(), postfix));
            }
            return path;
        }

        public static string GetFilePostfixFromContentType(string contentType)
        {
            var startToCheck = 0;
            if (contentType.Contains("/"))
            {
                startToCheck = contentType.IndexOf("/") + 1;
            }
            while (startToCheck < contentType.Length && !char.IsLetter(contentType[startToCheck]))
            {
                startToCheck += 1;
            }
            if (startToCheck == contentType.Length)
            {
                return "";
            }
            int start = startToCheck;
            int end = -1;
            for (int i = startToCheck; i < contentType.Length; i++)
            {
                if (!char.IsLetter(contentType[startToCheck]))
                {
                    end = i;
                    break;
                }
            }
            if (end < 0)
            {
                end = contentType.Length;
            }
            if (start == end)
            {
                return "";
            }
            return "." + contentType.Substring(start, end - start);
        }

        public static string GetFilePostfixFromUrl(string url)
        {
            if (url.Contains("?"))
            {
                url = url.Substring(0, url.IndexOf("?"));
            }
            if (url.Contains("/"))
            {
                url = url.Substring(url.LastIndexOf("/"));
            }
            if (url.Contains("."))
            {
                return url.Substring(url.LastIndexOf("."));
            }
            return "";
        }
    }
}
