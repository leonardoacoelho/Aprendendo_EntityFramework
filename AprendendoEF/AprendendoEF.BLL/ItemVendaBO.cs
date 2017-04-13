using AprendendoEF.BLL.Base;
using AprendendoEF.DAL;
using System;

namespace AprendendoEF.BLL
{
    public class ItemVendaBO : BaseBO<ItemVenda, ItemVendaDAO>
    {
        public override void Salvar(ItemVenda entidade)
        {
            try
            {
                Validar(entidade);

                entidade.Produto = null;

                base.Salvar(entidade);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Validar(ItemVenda entidade)
        {
            try
            {
                if (entidade.Produto_Id <= 0 || entidade.Quantidade <= 0 || entidade.ValorUnitario <= 0)
                    throw new ArgumentOutOfRangeException();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
