using System;

namespace AprendendoEF.Exceptions
{
    public class ValoresNaoCoincidemException : Exception
    {
        public ValoresNaoCoincidemException() : base()
        {

        }

        public ValoresNaoCoincidemException(string message) : base(message)
        {

        }
    }
}
