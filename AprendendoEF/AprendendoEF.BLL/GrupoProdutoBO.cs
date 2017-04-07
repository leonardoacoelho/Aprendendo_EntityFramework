using AprendendoEF.BLL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.BLL
{
    public class GrupoProdutoBO : BaseBO<GrupoProduto>
    {
        public override void Salvar(GrupoProduto entidade)
        {
            try
            {
                if ((string.IsNullOrEmpty(entidade.Nome)))
                    throw new ArgumentNullException();

                base.Salvar(entidade);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
