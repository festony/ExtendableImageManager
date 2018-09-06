using System;
using System.Collections.Generic;
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
    }
}
