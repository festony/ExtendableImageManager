using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendableImageManager.UserException
{
    public class ResourceNotInitializedException : Exception
    {
        public ResourceNotInitializedException()
        {
        }

        public ResourceNotInitializedException(string message) : base(message)
        {
        }

        public ResourceNotInitializedException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
