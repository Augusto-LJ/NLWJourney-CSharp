using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.Exception.ExceptionsBase
{
    public class JouneyException : SystemException
    {
        public JouneyException(string message) : base(message)
        {
            
        }
    }
}
