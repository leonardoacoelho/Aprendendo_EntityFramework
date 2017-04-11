using AprendendoEF.BLL.Base;
using AprendendoEF.DAL;
using System;

namespace AprendendoEF.BLL
{
    public class VendaBO : BaseBO<Venda, VendaDAO>
    {
        public override void Salvar(Venda entidade)
        {
            try
            {
                if (entidade.Cliente_Id <= 0 || entidade.Data == null)
                    throw new ArgumentOutOfRangeException();

                if ((entidade.Itens?.Count ?? 0) == 0)
                    throw new ArgumentNullException();
                else
                {
                    var itemVendaBO = new ItemVendaBO();

                    foreach (var item in entidade.Itens)
                    {
                        itemVendaBO.Salvar(item);
                    }
                    base.Salvar(entidade);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
