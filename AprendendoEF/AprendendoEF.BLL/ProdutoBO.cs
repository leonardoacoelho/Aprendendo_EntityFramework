using AprendendoEF.BLL.Base;
using AprendendoEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.BLL
{
    public class ProdutoBO : BaseBO<Produto, ProdutoDAO>
    {
        public override void Salvar(Produto entidade)
        {
            try
            {
                if (string.IsNullOrEmpty(entidade.Descricao))
                    throw new ArgumentNullException();

                if (entidade.Valor <= 0)
                    throw new ArgumentOutOfRangeException();

                //Ajustar foreignkey
                entidade.GrupoProduto_Id = entidade.GrupoProduto.Id;

                base.Salvar(entidade);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
