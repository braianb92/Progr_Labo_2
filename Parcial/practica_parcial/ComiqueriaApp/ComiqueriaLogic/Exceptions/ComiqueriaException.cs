using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Exceptions
{
    public class ComiqueriaException : Exception
    {
        public ComiqueriaException(string msj, Exception inner) : base(msj, inner) { }
    }
}
