using AprendendoEF.DAL.Base;
using AprendendoEF.DAL.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AprendendoEF.DAL
{
    public class VendaDAO : BaseDAO<Venda>
    {
        public override List<Venda> Listar()
        {
            using (var context = new DataContext())
            {
                return context.Vendas
                        .Include(x => x.Cliente)
                        .ToList();
            }
        }

        public override Venda Encontrar(int id)
        {
            using (var context = new DataContext())
            {
                return context.Vendas
                    .Include(x => x.Cliente)
                    .Include(x => x.Itens)
                    .Include(x => x.Itens.Select(i => i.Produto))
                    .FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
