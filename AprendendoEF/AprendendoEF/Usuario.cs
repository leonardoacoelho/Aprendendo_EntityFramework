using AprendendoEF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF
{
    public class Usuario : BaseEntidade
    {
        public string Login { get; set; }

        public string Senha { get; set; }

        public string ConfirmaSenha { get; set; }
    }
}
