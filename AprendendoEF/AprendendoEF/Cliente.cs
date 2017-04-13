using AprendendoEF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF
{
    public class Cliente : BaseEntidade
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
