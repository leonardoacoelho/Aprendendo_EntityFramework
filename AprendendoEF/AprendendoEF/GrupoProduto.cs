using AprendendoEF.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF
{
    public class GrupoProduto : BaseEntidade
    {
        public string Nome { get; set; }

        public virtual List<Produto> Produtos { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
