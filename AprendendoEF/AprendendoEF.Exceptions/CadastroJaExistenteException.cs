using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.Exceptions
{
    public class CadastroJaExistenteException : Exception
    {
        public CadastroJaExistenteException() : base()
        {

        }

        public CadastroJaExistenteException(string message) : base(message)
        {

        }
    }
}
