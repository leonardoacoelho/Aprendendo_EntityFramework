using AprendendoEF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF
{
    public class Produto : BaseEntidade
    {
        public string Descricao { get; set; }

        public double Valor { get; set; }
    }
}
